using Dapper;
using GVC.DAL;
using GVC.Helpers;
using GVC.MODEL;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Text.RegularExpressions;

namespace GVC.DALL
{
    internal class ClienteDal
    {
            private const string SqlBase = @"
            SELECT
                c.ClienteID,
                c.Nome,
                c.Cpf,
                c.RG,
                c.OrgaoExpedidorRG,
                c.Cnpj,
                c.IE,
                c.Telefone,
                c.Email,
                c.Logradouro,
                c.Numero,
                c.Bairro,
                c.Cep,
                c.DataNascimento,
                c.TipoCliente,
                c.Status,
                c.Observacoes,
                c.DataUltimaCompra,
                c.LimiteCredito,
                c.DataCriacao,
                c.DataAtualizacao,
                c.UsuarioCriacao,
                c.UsuarioAtualizacao,
                c.CidadeID,
                ci.Nome AS NomeCidade,
                e.Uf AS Estado
            FROM Cliente c
            LEFT JOIN Cidade ci ON ci.CidadeID = c.CidadeID
            LEFT JOIN Estado e ON e.EstadoID = ci.EstadoID";

        public DataTable ListarClientes()
        {
            const string sql = SqlBase + " ORDER BY c.Nome";
            using var conn = Helpers.Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql);
        }

        public bool ClienteExiste(string? nome, string? cpf)
        {
            const string sql = @"
            SELECT 1
            FROM Cliente
            WHERE (Nome = @Nome OR Cpf = @Cpf)
            LIMIT 1;";

            var p = new
            {
                Nome = string.IsNullOrWhiteSpace(nome) ? null : nome,
                Cpf = string.IsNullOrWhiteSpace(cpf) ? null : cpf
            };

            using var conn = Helpers.Conexao.Conex();
            return conn.ExecuteScalar<int?>(sql, p) != null;
        }


        public void SalvarCliente(ClienteMODEL cliente)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));
            if (ClienteExiste(cliente.Nome, cliente.Cpf))
                throw new InvalidOperationException("Já existe um cliente com este nome ou CPF.");

            const string sql = @"
    INSERT INTO Cliente (
      Nome, Cpf, RG, OrgaoExpedidorRG, Cnpj, IE, Telefone, Email, CidadeID,
      Logradouro, Numero, Bairro, Cep, DataNascimento, TipoCliente, Status,
      Observacoes, LimiteCredito, DataCriacao, DataAtualizacao, UsuarioCriacao, UsuarioAtualizacao
    )
    VALUES (
      @Nome, @Cpf, @RG, @OrgaoExpedidorRG, @Cnpj, @IE, @Telefone, @Email, @CidadeID,
      @Logradouro, @Numero, @Bairro, @Cep, @DataNascimento, @TipoCliente, @Status,
      @Observacoes, @LimiteCredito, @DataCriacao, @DataAtualizacao, @UsuarioCriacao, @UsuarioAtualizacao
    );
    SELECT LAST_INSERT_ROWID();";

            string? NullIfEmpty(string? s) => string.IsNullOrWhiteSpace(s) ? null : s;

            var p = new
            {
                Nome = NullIfEmpty(cliente.Nome),
                Cpf = NullIfEmpty(cliente.Cpf),   // aqui evita DBNull
                RG = NullIfEmpty(cliente.RG),
                OrgaoExpedidorRG = NullIfEmpty(cliente.OrgaoExpedidorRG),
                Cnpj = NullIfEmpty(cliente.Cnpj), // aqui evita DBNull
                IE = NullIfEmpty(cliente.IE),
                Telefone = NullIfEmpty(cliente.Telefone),
                Email = NullIfEmpty(cliente.Email),
                CidadeID = cliente.CidadeID == 0 ? (int?)null : cliente.CidadeID,
                Logradouro = NullIfEmpty(cliente.Logradouro),
                Numero = NullIfEmpty(cliente.Numero),
                Bairro = NullIfEmpty(cliente.Bairro),
                Cep = NullIfEmpty(cliente.Cep),
                DataNascimento = cliente.DataNascimento,
                TipoCliente = NullIfEmpty(cliente.TipoCliente),
                Status = cliente.Status,
                Observacoes = NullIfEmpty(cliente.Observacoes),
                LimiteCredito = cliente.LimiteCredito,
                DataCriacao = cliente.DataCriacao,
                DataAtualizacao = (DateTime?)null,
                UsuarioCriacao = NullIfEmpty(cliente.UsuarioCriacao),
                UsuarioAtualizacao = (string?)null
            };

            using var conn = Helpers.Conexao.Conex();
            cliente.ClienteID = (int)conn.QuerySingle<long>(sql, p);
        }



        public void Atualizar(ClienteMODEL cliente)
        {
            const string sql = @"
                                UPDATE Cliente SET
                                    Nome = @Nome,
                                    Cpf = @Cpf,
                                    RG = @RG,
                                    OrgaoExpedidorRG = @OrgaoExpedidorRG,
                                    Cnpj = @Cnpj,
                                    IE = @IE,
                                    Telefone = @Telefone,
                                    Email = @Email,
                                    CidadeID = @CidadeID,
                                    Logradouro = @Logradouro,
                                    Numero = @Numero,
                                    Bairro = @Bairro,
                                    Cep = @Cep,
                                    DataNascimento = @DataNascimento,
                                    TipoCliente = @TipoCliente,
                                    Status = @Status,
                                    Observacoes = @Observacoes,
                                    LimiteCredito = @LimiteCredito,
                                    DataAtualizacao = @DataAtualizacao,
                                    UsuarioAtualizacao = @UsuarioAtualizacao
                                WHERE ClienteID = @ClienteID";


            using var conn = Helpers.Conexao.Conex();
            conn.Execute(sql, cliente);
        }

        public void ExcluirCliente(int clienteID)
        {
            const string sql = "DELETE FROM Cliente WHERE ClienteID = @ClienteID";
            using var conn = Helpers.Conexao.Conex();
            conn.Execute(sql, new { ClienteID = clienteID });
        }

        public void ExcluirCliente(ClienteMODEL cliente) => ExcluirCliente(cliente.ClienteID);

        public DataTable PesquisarPorNome(string nome)
        {
            const string sql = SqlBase + " WHERE c.Nome LIKE @Nome ORDER BY c.Nome";
            using var conn = Helpers.Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql, new { Nome = $"%{nome?.Trim()}%" });
        }

        public DataTable PesquisarPorCodigo(int codigo)
        {
            const string sql = SqlBase + " WHERE c.ClienteID = @ClienteID";
            using var conn = Helpers.Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql, new { ClienteID = codigo });
        }

        public DataTable ListarPorTipoDePessoa(string tipoCliente)
        {
            const string sql = SqlBase + " WHERE c.TipoCliente = @TipoCliente";
            using var conn = Helpers.Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql, new { TipoCliente = tipoCliente });
        }

        public DataTable PesquisarGeral(string texto = "")
        {
            const string sql = SqlBase + @"
                                            WHERE c.Nome LIKE @Texto
                                               OR c.Cpf LIKE @Texto
                                               OR c.Cnpj LIKE @Texto
                                               OR c.Telefone LIKE @Texto
                                               OR c.Email LIKE @Texto
                                               OR c.Logradouro LIKE @Texto
                                               OR c.Bairro LIKE @Texto
                                               OR ci.Nome LIKE @Texto
                                            ORDER BY c.Nome
                                            LIMIT 100";

            var filtro = $"%{texto?.Trim() ?? ""}%";
            using var conn = Helpers.Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql, new { Texto = filtro });
        }

        public ClienteMODEL? BuscarPorCpf(string? cpf)
        {
            const string sql = @"
                                SELECT *
                                FROM Cliente
                                WHERE Cpf = @Cpf
                                LIMIT 1;";

            var p = new { Cpf = string.IsNullOrWhiteSpace(cpf) ? null : cpf };

            using var conn = Helpers.Conexao.Conex();
            return conn.QueryFirstOrDefault<ClienteMODEL>(sql, p);
        }

        public ClienteMODEL? BuscarPorCnpj(string? cnpj)
        {
            const string sql = @"
                                SELECT *
                                FROM Cliente
                                WHERE Cnpj = @Cnpj
                                LIMIT 1;";

            var p = new { Cnpj = string.IsNullOrWhiteSpace(cnpj) ? null : cnpj };

            using var conn = Helpers.Conexao.Conex();
            return conn.QueryFirstOrDefault<ClienteMODEL>(sql, p);
        }

        public ClienteMODEL? BuscarPorId(int clienteID)
        {
            const string sql = SqlBase + " WHERE c.ClienteID = @Id";
            using var conn = Conexao.Conex();
            return conn.QueryFirstOrDefault<ClienteMODEL>(sql, new { Id = clienteID });
        }

        // ========================= NOVA TELA DE VENDAS =========================
        public List<Cliente> Listar()
        {
            const string sql = @"SELECT ClienteID, Nome, Telefone, Cpf 
                     FROM Cliente ORDER BY Nome";

            using var conn = Conexao.Conex();
            return conn.Query<Cliente>(sql).ToList();
        }
    }

    // Classe simples para lista de vendas
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string CPF { get; set; } = "";
    }
}