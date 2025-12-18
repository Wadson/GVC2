using Dapper;
using GVC.DAL;
using GVC.Helpers;
using GVC.MODEL;
using Microsoft.Data.Sqlite;
using System.Data;

namespace GVC.DALL
{
    internal class FornecedorDal
    {
        private const string SqlBase = @"
            SELECT
                f.FornecedorID,
                f.Nome,
                f.Cnpj,
                f.IE,
                f.Telefone,
                f.Email,
                f.Logradouro,
                f.Numero,
                f.Bairro,
                f.Cep,
                f.DataCriacao,
                f.Observacoes,
                f.CidadeID,
                ci.Nome AS NomeCidade,
                e.Uf AS Estado
            FROM Fornecedor f
            LEFT JOIN Cidade ci ON ci.CidadeID = f.CidadeID
            LEFT JOIN Estado e ON e.EstadoID = ci.EstadoID";

        public DataTable ListarFornecedores()
        {
            const string sql = SqlBase + " ORDER BY f.Nome";
            using var conn = Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql);
        }

        public bool FornecedorExiste(string? nome, string? cnpj)
        {
            const string sql = @"
            SELECT 1
            FROM Fornecedor
            WHERE (Nome = @Nome OR Cnpj = @Cnpj)
            LIMIT 1;";

            var p = new
            {
                Nome = string.IsNullOrWhiteSpace(nome) ? null : nome,
                Cnpj = string.IsNullOrWhiteSpace(cnpj) ? null : cnpj
            };

            using var conn = Conexao.Conex();
            return conn.ExecuteScalar<int?>(sql, p) != null;
        }

        public void SalvarFornecedor(FornecedorModel fornecedor)
        {
            if (fornecedor == null) throw new ArgumentNullException(nameof(fornecedor));
            if (FornecedorExiste(fornecedor.Nome, fornecedor.Cnpj))
                throw new InvalidOperationException("Já existe um fornecedor com este nome ou CNPJ.");

            const string sql = @"
    INSERT INTO Fornecedor (
      Nome, Cnpj, IE, Telefone, Email, CidadeID,
      Logradouro, Numero, Bairro, Cep, DataCriacao, Observacoes
    )
    VALUES (
      @Nome, @Cnpj, @IE, @Telefone, @Email, @CidadeID,
      @Logradouro, @Numero, @Bairro, @Cep, @DataCriacao, @Observacoes
    );
    SELECT LAST_INSERT_ROWID();";

            string? NullIfEmpty(string? s) => string.IsNullOrWhiteSpace(s) ? null : s;

            var p = new
            {
                Nome = NullIfEmpty(fornecedor.Nome),
                Cnpj = NullIfEmpty(fornecedor.Cnpj),
                IE = NullIfEmpty(fornecedor.IE),
                Telefone = NullIfEmpty(fornecedor.Telefone),
                Email = NullIfEmpty(fornecedor.Email),
                CidadeID = fornecedor.CidadeID,
                Logradouro = NullIfEmpty(fornecedor.Logradouro),
                Numero = NullIfEmpty(fornecedor.Numero),
                Bairro = NullIfEmpty(fornecedor.Bairro),
                Cep = NullIfEmpty(fornecedor.Cep),
                DataCriacao = fornecedor.DataCriacao ?? DateTime.Now,
                Observacoes = NullIfEmpty(fornecedor.Observacoes)
            };

            using var conn = Conexao.Conex();
            fornecedor.FornecedorID = (int)conn.QuerySingle<long>(sql, p);
        }

        public void Atualizar(FornecedorModel fornecedor)
        {
            const string sql = @"
                UPDATE Fornecedor SET
                    Nome = @Nome,
                    Cnpj = @Cnpj,
                    IE = @IE,
                    Telefone = @Telefone,
                    Email = @Email,
                    CidadeID = @CidadeID,
                    Logradouro = @Logradouro,
                    Numero = @Numero,
                    Bairro = @Bairro,
                    Cep = @Cep,
                    Observacoes = @Observacoes,
                    DataCriacao = @DataCriacao
                WHERE FornecedorID = @FornecedorID";

            using var conn = Conexao.Conex();
            conn.Execute(sql, fornecedor);
        }

        public void ExcluirFornecedor(int fornecedorID)
        {
            const string sql = "DELETE FROM Fornecedor WHERE FornecedorID = @FornecedorID";
            using var conn = Conexao.Conex();
            conn.Execute(sql, new { FornecedorID = fornecedorID });
        }

        public void ExcluirFornecedor(FornecedorModel fornecedor) => ExcluirFornecedor((int)fornecedor.FornecedorID);

        public DataTable PesquisarPorNome(string nome)
        {
            const string sql = SqlBase + " WHERE f.Nome LIKE @Nome ORDER BY f.Nome";
            using var conn = Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql, new { Nome = $"%{nome?.Trim()}%" });
        }

        public DataTable PesquisarPorCodigo(int codigo)
        {
            const string sql = SqlBase + " WHERE f.FornecedorID = @FornecedorID";
            using var conn = Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql, new { FornecedorID = codigo });
        }

        public DataTable PesquisarGeral(string texto = "")
        {
            const string sql = SqlBase + @"
                WHERE f.Nome LIKE @Texto
                   OR f.Cnpj LIKE @Texto
                   OR f.Telefone LIKE @Texto
                   OR f.Email LIKE @Texto
                   OR f.Logradouro LIKE @Texto
                   OR f.Bairro LIKE @Texto
                   OR ci.Nome LIKE @Texto
                ORDER BY f.Nome
                LIMIT 100";

            var filtro = $"%{texto?.Trim() ?? ""}%";
            using var conn = Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql, new { Texto = filtro });
        }

        public FornecedorModel? BuscarPorCnpj(string? cnpj)
        {
            const string sql = @"
                SELECT *
                FROM Fornecedor
                WHERE Cnpj = @Cnpj
                LIMIT 1;";

            var p = new { Cnpj = string.IsNullOrWhiteSpace(cnpj) ? null : cnpj };

            using var conn = Conexao.Conex();
            return conn.QueryFirstOrDefault<FornecedorModel>(sql, p);
        }

        public FornecedorModel? BuscarPorId(int fornecedorID)
        {
            const string sql = SqlBase + " WHERE f.FornecedorID = @Id";
            using var conn = Conexao.Conex();
            return conn.QueryFirstOrDefault<FornecedorModel>(sql, new { Id = fornecedorID });
        }

        // ========================= LISTA SIMPLES =========================
        public List<Fornecedor> Listar()
        {
            const string sql = @"SELECT FornecedorID, Nome, Telefone, Cnpj 
                     FROM Fornecedor ORDER BY Nome";

            using var conn = Conexao.Conex();
            return conn.Query<Fornecedor>(sql).ToList();
        }
    }

    // Classe simples para lista rápida
    public class Fornecedor
    {
        public int FornecedorID { get; set; }
        public string Nome { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string? Cnpj { get; set; }
    }
}
