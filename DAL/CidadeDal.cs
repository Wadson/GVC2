using Dapper;
using GVC.Helpers;
using GVC.MODEL;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVC.DALL
{
    internal class CidadeDal
    {
        // SELECT completo com todos os campos da tabela Cliente + dados da Cidade/Estado
        private const string SqlBase = @"  SELECT ci.CidadeID, ci.Nome, ci.EstadoID FROM Cidade ci";

        public DataTable Listar_Cidades()
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sql = @" SELECT Cidade.CidadeID, Cidade.Nome, Cidade.EstadoID, Estado.Uf
            FROM Cidade  INNER JOIN Estado ON Cidade.EstadoID = Estado.EstadoID LIMIT 30"; // Substitui TOP (30) por LIMIT 30

                using var cmd = new SqliteCommand(sql, conn); conn.Open();
                using var reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao listar cidades: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Salvar(CidadeMODEL Cidades)
        {
            var conn = Conexao.Conex();
            try
            {
                SqliteCommand sqlcomando = new SqliteCommand("INSERT INTO Cidade (CidadeID, Nome, EstadoID) VALUES  (@CidadeID, @Nome, @EstadoID )", conn);
                                
                sqlcomando.Parameters.AddWithValue("@CidadeID", Cidades.CidadeID);
                sqlcomando.Parameters.AddWithValue("@Nome", Cidades.Nome);
                sqlcomando.Parameters.AddWithValue("@EstadoID", Cidades.EstadoID);                

                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (SqliteException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void Excluir(CidadeMODEL Cidades)
        {
            var conn = Conexao.Conex();
            try
            {
                SqliteCommand sqlcomando = new SqliteCommand("DELETE FROM Cidade WHERE CidadeID = @CidadeID", conn);
                sqlcomando.Parameters.AddWithValue("@Id", Cidades.CidadeID);
                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }

        public void Atualizar(CidadeMODEL Cidades)
        {
            var conn = Conexao.Conex();
            try
            {
                SqliteCommand sqlcomando = new SqliteCommand("UPDATE Cidade SET Nome = @Nome, EstadoID = @EstadoID WHERE CidadeID = @CidadeID", conn);
                
                sqlcomando.Parameters.AddWithValue("@Nome", Cidades.Nome);
                sqlcomando.Parameters.AddWithValue("@EstadoID", Cidades.EstadoID);
                sqlcomando.Parameters.AddWithValue("@CidadeID", Cidades.CidadeID);

                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable PesquisarPorNome(string nome)
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sql = @" SELECT Cidade.CidadeID, Cidade.Nome, Cidade.EstadoID, Estado.Uf
            FROM Cidade INNER JOIN Estado ON Cidade.EstadoID = Estado.EstadoID WHERE Cidade.Nome LIKE @Nome LIMIT 30"; // SQLite usa LIMIT em vez de TOP

                using var cmd = new SqliteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", $"%{nome}%");

                conn.Open();
                using var reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public DataTable PesquisarPorCodigo(int codigo)
        {
            const string sql = SqlBase + " WHERE CidadeID = @CidadeID";
            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, new { CidadeID = codigo }));
            return dt;
        }
        public DataTable PesquisarPorCodigo(string nome)
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sqlconn = "SELECT Cidade.CidadeID, Cidade.Nome, Cidade.EstadoID, Estado.Uf " +
                                "FROM Cidade INNER JOIN Estado ON Cidade.EstadoID = Estado.EstadoID " +
                                "WHERE CidadeID LIKE @CidadeID LIMIT 30";

                using (SqliteCommand cmd = new SqliteCommand(sqlconn, conn))
                {
                    cmd.Parameters.AddWithValue("@CidadeID", "%" + nome + "%");
                    conn.Open();
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
            }
        }
        public DataTable PesquisarGeral()
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();
                string sqlconn = " SELECT Cidade.CidadeID, Cidade.Nome, Cidade.EstadoID, Estado.Uf FROM Cidade INNER JOIN Estado ON Cidade.EstadoID = Estado.EstadoID LIMIT 30";

                using (SqliteCommand cmd = new SqliteCommand(sqlconn, conn))
                {
                    conn.Open();                    
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
            }
        }

    }
}
