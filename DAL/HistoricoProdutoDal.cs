using Dapper;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Linq;

namespace GVC.DALL
{
    internal class HistoricoProdutoDal
    {
        // INSERT - Inserir novo histórico de preço
        public void InserirHistorico(BLL.HistoricoPrecoBLL historico)
        {
            const string sql = @"INSERT INTO HistoricoPreco (ProdutoID, DataRegistro, PrecoCusto, Lucro, PrecoVenda) 
                VALUES (@ProdutoID, @DataRegistro, @PrecoCusto, @Lucro, @PrecoVenda)";

            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, historico);
        }
        // SELECT - Obter todo o histórico de um produto (mais recente primeiro)
        public List<BLL.HistoricoPrecoBLL> ObterHistoricoPorProduto(int produtoID)
        {
            const string sql = @"
                SELECT HistoricoID,
                       ProdutoID,
                       DataRegistro,
                       PrecoCusto,
                       Lucro,
                       PrecoVenda
                FROM HistoricoPreco 
                WHERE ProdutoID = @ProdutoID 
                ORDER BY DataRegistro DESC";

            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.Query<BLL.HistoricoPrecoBLL>(sql, new { ProdutoID = produtoID }).AsList();
        }
        // EXTRA: Último preço registrado de um produto (muito útil!)
        public BLL.HistoricoPrecoBLL? ObterUltimoPreco(int produtoID)
        {
            const string sql = @"
                SELECT HistoricoID,
                       ProdutoID,
                       DataRegistro,
                       PrecoCusto,
                       Lucro,
                       PrecoVenda
                FROM HistoricoPreco 
                WHERE ProdutoID = @ProdutoID 
                ORDER BY DataRegistro DESC 
                LIMIT 1";

            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QueryFirstOrDefault<BLL.HistoricoPrecoBLL>(sql, new { ProdutoID = produtoID });
        }
        // EXTRA: Deletar histórico (opcional, se precisar)
        public void ExcluirHistorico(int historicoID)
        {
            const string sql = "DELETE FROM HistoricoPreco WHERE HistoricoID = @HistoricoID";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, new { HistoricoID = historicoID });
        }
        // EXTRA: Limpar todo histórico de um produto (útil ao excluir produto)
        public void LimparHistoricoDoProduto(int produtoID)
        {
            const string sql = "DELETE FROM HistoricoPreco WHERE ProdutoID = @ProdutoID";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, new { ProdutoID = produtoID });
        }

    }
}
