using Dapper;
using GVC.MODEL;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DALL
{
    public class ItemVendaDal
    {
        // 1. ADICIONAR ITEM NA VENDA       
        public void AddItemVenda(ItemVendaModel itemVenda)
        {
            const string sql = @" INSERT INTO ItemVenda (
                    VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem
                )
                VALUES (
                    @VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Subtotal, @DescontoItem
                )";

            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, itemVenda);
        }

        // 2. ATUALIZAR ITEM DA VENDA       
        public void UpdateItemVenda(ItemVendaModel itemVenda)
        {
            const string sql = @" UPDATE ItemVenda 
                SET ProdutoID = @ProdutoID, 
                    Quantidade = @Quantidade,
                    PrecoUnitario = @PrecoUnitario,
                    Subtotal = @Subtotal,
                    DescontoItem = @DescontoItem
                WHERE ItemVendaID = @ItemVendaID";

            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, itemVenda);
        }

        // 3. EXCLUIR ITEM POR ID       
        public void DeleteItemVenda(long itemVendaId)
        {
            const string sql = "DELETE FROM ItemVenda WHERE ItemVendaID = @ItemVendaID";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, new { ItemVendaID = itemVendaId });
        }

        public void Excluir(ItemVendaModel itemVenda) => DeleteItemVenda(itemVenda.ItemVendaID);

        // 4. LISTAR TODOS OS ITENS DE UMA VENDA       
        public List<ItemVendaModel> ConsultarItensVenda(int vendaId)
        {
            const string sql = @"
                SELECT ItemVendaID,
                       VendaID,
                       ProdutoID,
                       Quantidade,
                       PrecoUnitario,
                       Subtotal,
                       DescontoItem
                FROM ItemVenda 
                WHERE VendaID = @VendaID 
                ORDER BY ItemVendaID";

            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.Query<ItemVendaModel>(sql, new { VendaID = vendaId }).AsList();
        }

        // 5. EXCLUIR TODOS OS ITENS DE UMA VENDA (útil ao cancelar venda)       
        public void ExcluirItensPorVendaID(int vendaID)
        {
            const string sql = "DELETE FROM ItemVenda WHERE VendaID = @VendaID";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, new { VendaID = vendaID });
        }

        // 6. LISTAR TODOS OS ITENS (para relatórios, etc)        
        public DataTable ListarItensVenda()
        {
            const string sql = "SELECT * FROM ItemVenda ORDER BY VendaID, ItemVendaID";

            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql));
            return dt;
        }

        // 7. BUSCAR ITEM POR ID (muito útil em edição de venda)       
        public ItemVendaModel? BuscarPorId(int itemVendaId)
        {
            const string sql = "SELECT * FROM ItemVenda WHERE ItemVendaID = @Id";
            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QueryFirstOrDefault<ItemVendaModel>(sql, new { Id = itemVendaId });
        }

        // 8. CALCULAR TOTAL DA VENDA (método extra MUITO útil!)       
        public decimal CalcularTotalVenda(int vendaId)
        {
            const string sql = @"SELECT COALESCE(SUM((Quantidade * PrecoUnitario) - DescontoItem), 0) 
                                 FROM ItemVenda 
                                 WHERE VendaID = @VendaID";

            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QuerySingle<decimal>(sql, new { VendaID = vendaId });
        }

        // 9. LISTAR ITENS COM DADOS DO PRODUTO (nome, código, etc) - TOP!        
        public DataTable ListarItensComProduto(int vendaId)
        {
            const string sql = @" SELECT 
                    iv.ItemVendaID,
                    iv.VendaID,
                    iv.ProdutoID,
                    p.NomeProduto,
                    p.CodigoBarras,
                    iv.Quantidade,
                    iv.PrecoUnitario,
                    iv.Subtotal,
                    iv.DescontoItem,
                    (iv.Quantidade * iv.PrecoUnitario - iv.DescontoItem) AS TotalItem
                FROM ItemVenda iv
                INNER JOIN Produto p ON iv.ProdutoID = p.ProdutoID
                WHERE iv.VendaID = @VendaID
                ORDER BY iv.ItemVendaID";

            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, new { VendaID = vendaId }));
            return dt;
        }
    }
}
