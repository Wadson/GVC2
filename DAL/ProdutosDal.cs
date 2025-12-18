using Dapper;
using GVC.MODEL;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace GVC.DAL
{
    public class ProdutoDALL
    {
        // SELECT completo com todos os campos da tabela Produto + dados do Fornecedor/Marca
        private const string SqlBase = @"
SELECT 
    p.ProdutoID,
    p.NomeProduto,
    p.Referencia,
    p.PrecoCusto,
    p.Lucro,
    p.PrecoDeVenda,
    p.Estoque,
    p.DataDeEntrada,
    p.Status,
    p.Situacao,
    p.Unidade,
    p.Marca,
    p.DataValidade,
    p.GtinEan,
    p.Imagem,
    p.FornecedorID,
    COALESCE(f.Nome, '') AS NomeFornecedor
FROM Produtos p
LEFT JOIN Fornecedor f ON p.FornecedorID = f.FornecedorID";



        private readonly string _connectionString = GVC.Helpers.Conexao.Conex().ConnectionString;
        // ==================== LISTAR TODOS ====================
        public List<ProdutosModel> ListarTodos()
        {
            var lista = new List<ProdutosModel>();
            using (var con = new SqliteConnection(_connectionString))
            {
                // 🔹 CORREÇÃO: A tabela é "Cliente" (singular)
                string sql = SqlBase + @" ORDER BY p.NomeProduto LIMIT 100";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }
            return lista;
        }
       

        // ==================== BUSCAR POR ID ====================
        public ProdutosModel? BuscarPorId(long id)
        {
            using (var con = new SqliteConnection(_connectionString))
            {
                string sql = "SELECT * FROM Produtos WHERE ProdutoID = @id";
                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return Mapear(reader);
                    }
                }
            }
            return null;
        }
        // ==================== INSERIR ====================
        public long Inserir(ProdutosModel produto)
        {
            using (var con = new SqliteConnection(_connectionString))
            {
                string sql = @"INSERT INTO Produtos 
                    (NomeProduto, Referencia, PrecoCusto, Lucro, PrecoDeVenda, Estoque, DataDeEntrada, 
                     Status, Situacao, Unidade, Marca, DataValidade, GtinEan, Imagem, FornecedorID)
                    VALUES (@NomeProduto, @Referencia, @Custo, @Lucro, @Venda, @Estoque, @Entrada, 
                     @Status, @Situacao, @Unidade, @Marca, @Validade, @Gtin, @Imagem, @FornecedorID); SELECT last_insert_rowid();";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    AdicionarParametros(cmd, produto);
                    con.Open();
                    return (long)cmd.ExecuteScalar();
                }
            }
        }
        // ==================== ATUALIZAR ====================
        public bool Alterar(ProdutosModel produto)
        {
            using (var con = new SqliteConnection(_connectionString))
            {
                string sql = @"UPDATE Produtos SET  NomeProduto = @NomeProduto, Referencia = @Referencia, PrecoCusto = @Custo, Lucro = @Lucro,
                    PrecoDeVenda = @Venda, Estoque = @Estoque, 
                    Status = @Status, Situacao = @Situacao, Unidade = @Unidade, Marca = @Marca,
                    DataValidade = @Validade, GtinEan = @Gtin, Imagem = @Imagem, FornecedorID = @FornecedorID
                    WHERE ProdutoID = @Id";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    AdicionarParametros(cmd, produto);
                    cmd.Parameters.AddWithValue("@Id", produto.ProdutoID);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        // ==================== EXCLUIR ====================
        public bool Excluir(long id)
        {
            using (var con = new SqliteConnection(_connectionString))
            {
                string sql = "DELETE FROM Produtos WHERE ProdutoID = @id";
                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        // ==================== MÉTODO AUXILIAR ====================
        private ProdutosModel Mapear(SqliteDataReader reader)
        {
            return new ProdutosModel
            {
                ProdutoID = Convert.ToInt32(reader["ProdutoID"]),
                NomeProduto = reader["NomeProduto"].ToString(),
                Referencia = reader["Referencia"].ToString() ?? "",
                PrecoCusto = Convert.ToDecimal(reader["PrecoCusto"]),
                Lucro = Convert.ToDecimal(reader["Lucro"]),
                PrecoDeVenda = Convert.ToDecimal(reader["PrecoDeVenda"]),
                Estoque = Convert.ToInt64(reader["Estoque"]),
                DataDeEntrada = Convert.ToDateTime(reader["DataDeEntrada"]),
                Status = reader["Status"].ToString(),
                Situacao = reader["Situacao"].ToString() ?? "",
                Unidade = reader["Unidade"].ToString() ?? "",
                Marca = reader["Marca"].ToString() ?? "",
                DataValidade = reader["DataValidade"] != DBNull.Value ? Convert.ToDateTime(reader["DataValidade"]) : (DateTime?)null,
                GtinEan = reader["GtinEan"].ToString() ?? "",
                Imagem = reader["Imagem"].ToString() ?? "",

                // 🔧 CORREÇÃO AQUI: Tratamento mais seguro para FornecedorID
                FornecedorID = SafeConvertToLong(reader["FornecedorID"]),

                Fornecedor = reader["NomeFornecedor"].ToString() ?? ""
            };
        }

        // Método auxiliar para conversão segura
        private long SafeConvertToLong(object value)
        {
            if (value == null || value == DBNull.Value)
                return 0;

            if (value is long)
                return (long)value;

            if (value is int)
                return (int)value;

            if (long.TryParse(value.ToString(), out long result))
                return result;

            return 0; // ou lance uma exceção se preferir
        }

        // ==================== PESQUISAR POR NOME ====================

        // ==================== PESQUISAR POR NOME ====================
        public List<ProdutosModel> PesquisarProdutoPorNome(string nome)
        {
            var lista = new List<ProdutosModel>();
            string sql = SqlBase + @"
        WHERE p.NomeProduto LIKE @nome
        ORDER BY p.NomeProduto
        LIMIT 100";

            using (var con = new SqliteConnection(_connectionString))
            {
                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }
            return lista;
        }

        // ==================== PESQUISAR POR CÓDIGO ====================
        public List<ProdutosModel> PesquisarProdutoPorCodigo(string codigo)
        {
            var lista = new List<ProdutosModel>();
            string sql = SqlBase + @"
        WHERE CAST(p.ProdutoID AS TEXT) LIKE @codigo
           OR p.Referencia LIKE @codigo
        ORDER BY p.ProdutoID
        LIMIT 100";

            using (var con = new SqliteConnection(_connectionString))
            {
                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", $"%{codigo}%");  // Adicionei % para busca parcial
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }
            return lista;
        }
        public DataTable PesquisarPorCodigo(int codigo)
        {
            const string sql = SqlBase + " WHERE p.ProdutoID = @ProdutoID";
            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, new { ProdutoID = codigo }));  // Corrigido nome do parâmetro
            return dt;
        }
        private void AdicionarParametros(SqliteCommand cmd, ProdutosModel p)
        {
            cmd.Parameters.AddWithValue("@NomeProduto", p.NomeProduto ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Referencia", p.Referencia ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Custo", p.PrecoCusto);
            cmd.Parameters.AddWithValue("@Lucro", p.Lucro);
            cmd.Parameters.AddWithValue("@Venda", p.PrecoDeVenda);
            cmd.Parameters.AddWithValue("@Estoque", p.Estoque);
            cmd.Parameters.AddWithValue("@Entrada", p.DataDeEntrada);
            cmd.Parameters.AddWithValue("@Status", p.Status ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Situacao", p.Situacao ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Unidade", p.Unidade ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Marca", p.Marca ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Validade", p.DataValidade.HasValue ? p.DataValidade.Value : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Gtin", p.GtinEan ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Imagem", p.Imagem ?? (object)DBNull.Value);

            // 🔹 CORREÇÃO: Use p.FornecedorID em vez de p.Fornecedor
            if (p.FornecedorID > 0)
                cmd.Parameters.AddWithValue("@FornecedorID", p.FornecedorID);
            else
                cmd.Parameters.AddWithValue("@FornecedorID", DBNull.Value);
        }       
    }
}