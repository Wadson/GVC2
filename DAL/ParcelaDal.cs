using Dapper;
using GVC.MODEL;
using iText.Kernel.Pdf.Canvas.Wmf;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DALL
{
    public class ParcelaDal
    {
        public void InsertParcela(ParcelaModel parcela)
        {
            const string sql = @" INSERT INTO Parcela (
                    VendaID, NumeroParcela, DataVencimento, ValorParcela, ValorRecebido,
                    Status, DataPagamento, Juros, Multa, Observacao
                )
                VALUES (
                    @VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                    @Status, @DataPagamento, @Juros, @Multa, @Observacao
                )";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, parcela);
        }

        public void InsertParcelas(List<ParcelaModel> parcelas)
        {
            if (!parcelas.Any()) return;

            const string sql = @" INSERT INTO Parcela (
                    VendaID, NumeroParcela, DataVencimento, ValorParcela, ValorRecebido,
                    Status, DataPagamento, Juros, Multa, Observacao
                )
                VALUES (
                    @VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                    @Status, @DataPagamento, @Juros, @Multa, @Observacao
                )";

            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, parcelas);
        }      

      
        //===========================NOVOS MÉTODOS ABAIXO===========================
        // ==========================================================
        // UPDATE COMPLETO
        // ==========================================================
        public void UpdateParcela(ParcelaModel parcela)
        {
            const string sql = @"UPDATE Parcela 
                SET DataVencimento = @DataVencimento,
                    ValorParcela   = @ValorParcela,
                    ValorRecebido  = @ValorRecebido,
                    Status         = @Status,
                    DataPagamento  = @DataPagamento,
                    Juros          = @Juros,
                    Multa          = @Multa,
                    Observacao     = @Observacao
                WHERE ParcelaID = @ParcelaID";

            using var conn = Helpers.Conexao.Conex();
            conn.Execute(sql, parcela);
        }


        // ==========================================================
        // BAIXA CORRETA (INSERE EM PagamentosParciais)
        // ==========================================================
        public void BaixarParcela(long parcelaId, decimal valorPago, DateTime dataPagamento)
        {
            const string sql = @" UPDATE Parcela
           SET ValorRecebido = ValorRecebido + @ValorPago,
               DataPagamento = @DataPagamento   -- será ajustado pelo trigger se quitada
         WHERE ParcelaID = @ParcelaID";

            using var conn = Helpers.Conexao.Conex();
            conn.Execute(sql, new
            {
                ParcelaID = parcelaId,
                ValorPago = valorPago,  // já em reais (decimal)
                DataPagamento = dataPagamento
            });
        }
        /// <summary>
        /// Realiza baixa total em múltiplas parcelas de uma vez (usado no lote com checkbox)
        /// </summary>
        /// <param name="parcelasIds">Lista de IDs das parcelas a baixar</param>
        /// <param name="dataPagamento">Data do pagamento (geralmente DateTime.Now)</param>
        public void BaixarParcelasEmLote(List<long> parcelasIds, DateTime dataPagamento)
        {
            if (parcelasIds == null || parcelasIds.Count == 0)
                return;

            using var conn = Helpers.Conexao.Conex();
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                // 1. Baixa o valor restante para quitar cada parcela
                const string sqlBaixa = @"
            UPDATE Parcela
            SET ValorRecebido = ValorParcela + Juros + Multa,
                DataPagamento = @DataPagamento
            WHERE ParcelaID = @ParcelaID";

                foreach (var parcelaId in parcelasIds)
                {
                    conn.Execute(sqlBaixa, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento
                    }, transaction);
                }

                // 2. Registra cada baixa como valor positivo no histórico (opcional, mas recomendado)
                const string sqlHistorico = @"
            INSERT INTO PagamentosParciais (ParcelaID, DataPagamento, ValorPago, Observacao)
            SELECT 
                ParcelaID,
                @DataPagamento,
                (ValorParcela + Juros + Multa - ValorRecebido),  -- valor que estava faltando
                'Baixa total em lote'
            FROM Parcela
            WHERE ParcelaID = @ParcelaID";

                foreach (var parcelaId in parcelasIds)
                {
                    conn.Execute(sqlHistorico, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento
                    }, transaction);
                }

                transaction.Commit();

                // O trigger tr_atualiza_status_parcela vai disparar para cada parcela
                // e definir Status = 'Paga' automaticamente
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        // ==========================================================
        // SELECT
        // ==========================================================
        public ParcelaModel? BuscarPorId(decimal parcelaId)
        {
            const string sql = "SELECT * FROM Parcela WHERE ParcelaID = @Id";
            using var conn = Helpers.Conexao.Conex();
            return conn.QueryFirstOrDefault<ParcelaModel>(sql, new { Id = parcelaId });
        }


        public List<ParcelaModel> GetParcelas(int vendaId)
        {
            const string sql = @"SELECT *
                FROM Parcela
                WHERE VendaID = @VendaID
                ORDER BY NumeroParcela";

            using var conn = Helpers.Conexao.Conex();
            return conn.Query<ParcelaModel>(sql, new { VendaID = vendaId }).AsList();
        }

        public DataTable ListarParcelas()
        {
            AtualizarParcelasAtrasadas();
            const string sql = "SELECT * FROM Parcela ORDER BY DataVencimento";

            using var conn = Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql));
            return dt;
        }

        public DataTable ListarParcelasPendentesPorCliente(int clienteId)
        {
            const string sql = @"SELECT p.*,
                       v.DataVenda,
                       c.Nome
                FROM Parcela p
                INNER JOIN Venda v   ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                WHERE c.ClienteID = @ClienteID
                  AND p.Status = 'Pendente'
                ORDER BY p.DataVencimento";

            using var conn = Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, new { ClienteID = clienteId }));
            return dt;
        }

        // ==========================================================
        // DELETE
        // ==========================================================
        public void Excluir(ParcelaModel parcela)
        {
            const string sql = "DELETE FROM Parcela WHERE ParcelaID = @Id";

            using var conn = Helpers.Conexao.Conex();
            conn.Execute(sql, new { Id = parcela.ParcelaID });
        }


        //public void EstornarPagamento(long parcelaId, decimal valorEstorno, DateTime dataEstorno, string motivo = null)
        //{
        //    if (valorEstorno <= 0m) throw new ArgumentException("Valor do estorno deve ser maior que zero.");
        //    if (string.IsNullOrWhiteSpace(motivo)) motivo = "Estorno sem motivo informado";

        //    string linhaHistorico = $"[{dataEstorno:dd/MM/yyyy HH:mm}] Estorno de {valorEstorno:C2} - Motivo: {motivo}";

        //    const string sql = @"
        //UPDATE Parcela
        //SET ValorRecebido = ValorRecebido - @ValorEstorno,
        //    Observacao = CASE
        //        WHEN Observacao IS NULL OR Observacao = '' THEN @LinhaHistorico
        //        ELSE Observacao || char(13) || char(10) || @LinhaHistorico
        //    END
        //WHERE ParcelaID = @ParcelaID;

        //INSERT INTO PagamentosParciais (ParcelaID, DataPagamento, ValorPago, Observacao)
        //VALUES (@ParcelaID, @DataEstorno, @ValorNegativo, @MotivoCompleto);";

        //    using var conn = Helpers.Conexao.Conex();
        //    conn.Execute(sql, new
        //    {
        //        ParcelaID = parcelaId,
        //        ValorEstorno = valorEstorno,
        //        LinhaHistorico = linhaHistorico,
        //        DataEstorno = dataEstorno,
        //        ValorNegativo = -valorEstorno,
        //        MotivoCompleto = $"Estorno: {motivo}"
        //    });
        //}
        public void EstornarPagamento(long parcelaId, decimal valorEstorno, DateTime dataEstorno, string motivo = null)
        {
            if (valorEstorno <= 0m) throw new ArgumentException("Valor do estorno deve ser maior que zero.");
            if (string.IsNullOrWhiteSpace(motivo)) motivo = "Estorno sem motivo informado";

            string linhaHistorico = $"[{dataEstorno:dd/MM/yyyy HH:mm}] Estorno de {valorEstorno:C2} - Motivo: {motivo}";

            // 🔴 CORREÇÃO: REMOVER o INSERT na PagamentosParciais
            const string sql = @"
UPDATE Parcela
SET ValorRecebido = ValorRecebido - @ValorEstorno,
    Observacao = CASE
        WHEN Observacao IS NULL OR Observacao = '' THEN @LinhaHistorico
        ELSE Observacao || char(13) || char(10) || @LinhaHistorico
    END
WHERE ParcelaID = @ParcelaID;";

            using var conn = Helpers.Conexao.Conex();
            conn.Execute(sql, new
            {
                ParcelaID = parcelaId,
                ValorEstorno = valorEstorno,
                LinhaHistorico = linhaHistorico
                // 🔴 REMOVIDO: DataEstorno, ValorNegativo, MotivoCompleto
            });
        }
        /// <summary>
        /// Estorna um pagamento e registra o motivo na Observacao da parcela
        /// </summary>

        //CRIADO EM 18/12/2025

        //✅ 3️⃣ SOLUÇÃO CORRETA(SEM INVENTAR)
        //🔹 Passo A — Criar método na VendaDal

        //👉 Método simples, usando apenas o que existe

        public void AtualizarParcelasAtrasadas()
        {
            const string sql = @"
    UPDATE Parcela
    SET Status = 'Atrasada'
    WHERE Status IN ('Pendente', 'Parcialmente Paga')
      AND DataVencimento < date('now')";

            using var conn = Helpers.Conexao.Conex();
            conn.Execute(sql);
        }





    }
}
