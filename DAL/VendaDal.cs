using Dapper;
using GVC.MODEL;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using static GVC.View.FrmVendas;

namespace GVC.DALL
{
    public class VendaDal
    {
        private string CalcularStatusVendaPorParcelas(List<ParcelaModel> parcelas)
        {
            if (parcelas == null || !parcelas.Any())
                return null;

            decimal total = parcelas.Sum(p => p.ValorParcela + p.Juros + p.Multa);
            decimal recebido = parcelas.Sum(p => p.ValorRecebido);

            if (recebido <= 0)
                return EnumStatusVenda.Aberta.ToDb();

            if (recebido >= total)
                return EnumStatusVenda.Concluida.ToDb();

            return EnumStatusVenda.ParcialmentePago.ToDb();
        }

        public int AddVendaCompleta(VendaModel venda, List<ItemVendaModel> itens, List<ParcelaModel> parcelas = null)
        {
            if (parcelas != null && parcelas.Any())
            {
                var statusCalculado = CalcularStatusVendaPorParcelas(parcelas);

                if (!string.IsNullOrWhiteSpace(statusCalculado))
                    venda.StatusVenda = statusCalculado;
            }

            const string sqlVenda = @" INSERT INTO Venda (DataVenda, ClienteID, ValorTotal, FormaPgtoID, Desconto, Observacoes, StatusVenda) 
            VALUES (@DataVenda, @ClienteID, @ValorTotal, @FormaPgtoID, @Desconto, @Observacoes, @StatusVenda);
            SELECT LAST_INSERT_ROWID();";

            const string sqlItem = @" INSERT INTO ItemVenda (VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem)
            VALUES (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Quantidade * @PrecoUnitario, @DescontoItem)";

            const string sqlParcela = @"INSERT INTO Parcela ( VendaID, NumeroParcela, DataVencimento,
                ValorParcela, ValorRecebido, Status, DataPagamento, Juros, Multa, Observacao )
            VALUES ( @VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                @Status, @DataPagamento, @Juros, @Multa, @Observacao )";


            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                int vendaId = conn.QuerySingle<int>(sqlVenda, new
                {
                    venda.ClienteID,
                    venda.FormaPgtoID,
                    venda.DataVenda,                    
                    venda.ValorTotal,
                    venda.Desconto,
                    venda.Observacoes,
                    venda.StatusVenda
                }, transaction);

                // 2. Atualiza os itens com o VendaID correto
                foreach (var item in itens)
                    item.VendaID = vendaId;

                // 3. Insere itens
                if (itens.Any())
                    conn.Execute(sqlItem, itens, transaction);

                // 4. Insere parcelas (se houver)
                foreach (var p in parcelas)
                {
                    p.VendaID = vendaId;

                    if (p.Status == EnumStatusParcela.Paga.ToDb() && p.DataPagamento == null)
                        p.DataPagamento = DateTime.Now;
                }


                transaction.Commit();
                return vendaId;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void UpdateVenda(VendaModel venda)
        {
            const string sql = @"UPDATE Venda 
            SET DataVenda = @DataVenda,
                ClienteID = @ClienteID,
                ValorTotal = @ValorTotal,
                FormaPgtoID = @FormaPgtoID,
                Desconto = @Desconto,
                Observacoes = @Observacoes,
                StatusVenda = @StatusVenda
            WHERE VendaID = @VendaID";

            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, venda);
        }      
        public void DeleteVenda(long vendaId)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            using var trans = conn.BeginTransaction();

            try
            {
                conn.Execute("DELETE FROM ItemVenda WHERE VendaID = @Id", new { Id = vendaId }, trans);
                conn.Execute("DELETE FROM Parcela WHERE VendaID = @Id", new { Id = vendaId }, trans);
                conn.Execute("DELETE FROM Venda WHERE VendaID = @Id", new { Id = vendaId }, trans);
                trans.Commit();
            }
            catch
            {
                trans.Rollback();
                throw;
            }
        }

        public void DeleteVenda(VendaModel venda) => DeleteVenda(venda.VendaID);
        public VendaModel? GetVenda(int vendaId)
        {
            const string sql = "SELECT * FROM Venda WHERE VendaID = @VendaID";
            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QueryFirstOrDefault<VendaModel>(sql, new { VendaID = vendaId });
        }
     
        public DataTable ListarVendas()
        {
            const string sql = @" SELECT 
                v.VendaID,
                v.DataVenda,
                c.Nome,
                v.ValorTotal,
                v.Desconto,
                v.Observacoes,
                v.StatusVenda,
                f.FormaPgto AS FormaPagamento
            FROM Venda v
            INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
            LEFT JOIN FormaPgto f ON v.FormaPgtoID = f.FormaPgtoID
            ORDER BY v.DataVenda DESC";


            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql));
            return dt;
        }
   
        public DataTable VendaLocalizarPorCliente(long clienteId)
        {
            const string sql = @" SELECT 
                v.VendaID,
                v.DataVenda,
                v.ValorTotal,
                v.Desconto,
                v.Observacoes,
                v.StatusVenda,
                f.FormaPgto AS FormaPagamento
            FROM Venda v
            LEFT JOIN FormaPgto f ON v.FormaPgtoID = f.FormaPgtoID
            WHERE v.ClienteID = @ClienteID
            ORDER BY v.DataVenda DESC";


            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, new { ClienteID = clienteId }));
            return dt;
        }    
        public DataTable RelatorioVendasPorPeriodo(DateTime inicio, DateTime fim)
        {
            const string sql = @" SELECT 
                v.VendaID,
                v.DataVenda,
                c.Nome,
                v.ValorTotal,
                v.Desconto,
                v.Observacoes,
                v.StatusVenda,
                f.FormaPgto AS FormaPagamento
            FROM Venda v
            INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
            LEFT JOIN FormaPgto f ON v.FormaPgtoID = f.FormaPgtoID
            WHERE v.DataVenda BETWEEN @Inicio AND @Fim
            ORDER BY v.DataVenda DESC";


            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, new { Inicio = inicio.Date, Fim = fim.Date.AddDays(1).AddSeconds(-1) }));
            return dt;
        }
       
        public decimal TotalVendidoHoje()
        {
            const string sql = @" SELECT COALESCE(SUM(ValorTotal), 0) 
            FROM Venda WHERE DATE(DataVenda) = DATE('now','localtime')";

            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QuerySingle<decimal>(sql);
        }       
        public int UltimaVendaId()
        {
            const string sql = "SELECT MAX(VendaID) FROM Venda";
            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QuerySingleOrDefault<int>(sql);
        }
        public void AtualizarStatusVenda(long vendaId, string novoStatus)
        {
            const string sql = @"UPDATE Venda
                         SET StatusVenda = @Status
                         WHERE VendaID = @VendaID";

            using var conn = Helpers.Conexao.Conex();
            conn.Execute(sql, new
            {
                VendaID = vendaId,
                Status = novoStatus
            });
        }
    }
}