using Dapper;
using GVC.MODEL;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.DALL
{
    internal class PagamentoParcialDal
    {      
        // 1. INSERIR PAGAMENTO PARCIAL       
        public void InserirPagamentoParcial(PagamentoParcialModel pagamentoParcial)
        {
            const string sql = @"INSERT INTO PagamentosParciais (ParcelaID, ValorPago, DataPagamento) 
                VALUES (@ParcelaID, @ValorPago, @DataPagamento)";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, pagamentoParcial);
        }
        // 2. EXCLUIR PAGAMENTO PARCIAL POR ID
        public void ExcluirPagamentoParcial(long pagamentoParcialId)
        {
            const string sql = "DELETE FROM PagamentosParciais WHERE PagamentoParcialID = @Id";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, new { Id = pagamentoParcialId });
        }
        public void Excluir(PagamentoParcialModel pagamentoParcial)
            => ExcluirPagamentoParcial(pagamentoParcial.PagamentoID);
       
        // 3. LISTAR PAGAMENTOS PARCIAIS DE UMA PARCELA        
        public List<PagamentoParcialModel> ObterPagamentosParciaisPorParcela(long parcelaId)
        {
            const string sql = @" SELECT PagamentoParcialID,
                       ParcelaID,
                       ValorPago,
                       DataPagamento
                FROM PagamentosParciais 
                WHERE ParcelaID = @ParcelaID 
                ORDER BY DataPagamento DESC";

            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.Query<PagamentoParcialModel>(sql, new { ParcelaID = parcelaId }).AsList();
        }
        // 4. EXCLUIR TODOS OS PAGAMENTOS PARCIAIS DE UMA PARCELA (ex: ao baixar integral)       
        public void ExcluirPagamentosParciaisPorParcelaID(long parcelaId)
        {
            const string sql = "DELETE FROM PagamentosParciais WHERE ParcelaID = @ParcelaID";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, new { ParcelaID = parcelaId });
        }
        // 5. LISTAR TODOS OS PAGAMENTOS PARCIAIS (para relatório)       
        public DataTable ListarPagamentosParciais()
        {
            const string sql = @" SELECT pp.PagamentoParcialID,
                       pp.ParcelaID,
                       p.NumeroParcela,
                       c.Nome,
                       pp.ValorPago,
                       pp.DataPagamento
                FROM PagamentosParciais pp
                INNER JOIN Parcela p ON pp.ParcelaID = p.ParcelaID
                INNER JOIN Venda v ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                ORDER BY pp.DataPagamento DESC";

            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql));
            return dt;
        }
        // 6. TOTAL PAGO PARCIALMENTE EM UMA PARCELA
        public decimal TotalPagoParcialmente(long parcelaId)
        {
            const string sql = @" SELECT COALESCE(SUM(ValorPago), 0) 
                FROM PagamentosParciais WHERE ParcelaID = @ParcelaID";

            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QuerySingle<decimal>(sql, new { ParcelaID = parcelaId });
        }
        // 7. REGISTRAR PAGAMENTO PARCIAL + ATUALIZAR PARCELA AUTOMATICAMENTE (MÉTODO DOS DEUSES!)       
        public void RegistrarPagamentoParcial(long parcelaId, decimal valorPago, DateTime? dataPagamento = null)
        {
            if (valorPago <= 0) return;
            dataPagamento ??= DateTime.Now;
            using var conn = GVC.Helpers.Conexao.Conex(); conn.Open();
            using var trans = conn.BeginTransaction();

            try
            {
                // 1. Insere o pagamento parcial
                const string sqlInsert = @" INSERT INTO PagamentosParciais (ParcelaID, ValorPago, DataPagamento) 
                    VALUES (@ParcelaID, @ValorPago, @DataPagamento)";

                conn.Execute(sqlInsert, new
                {
                    ParcelaID = parcelaId,
                    ValorPago = valorPago,
                    DataPagamento = dataPagamento
                }, trans);
                // 2. Atualiza a parcela (ValorRecebido, SaldoRestante, Pago)
                const string sqlUpdate = @" UPDATE Parcela SET ValorRecebido = ValorRecebido + @ValorPago,
                        SaldoRestante = ValorParcela - (ValorRecebido + @ValorPago),
                        Pago = (ValorParcela - (ValorRecebido + @ValorPago)) <= 0.005 WHERE ParcelaID = @ParcelaID";
                conn.Execute(sqlUpdate, new { ParcelaID = parcelaId, ValorPago = valorPago }, trans);
                trans.Commit();
            }
            catch
            {
                trans.Rollback();
                throw;
            }
        }
        // 8. BUSCAR PAGAMENTO PARCIAL POR ID
        public PagamentoParcialModel? BuscarPorId(long pagamentoParcialId)
        {
            const string sql = "SELECT * FROM PagamentosParciais WHERE PagamentoParcialID = @Id";
            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QueryFirstOrDefault<PagamentoParcialModel>(sql, new { Id = pagamentoParcialId });
        }
    }
}