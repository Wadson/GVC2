using GVC.Helpers;
using GVC.MODEL;
using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Windows.Forms;

namespace GVC.DALL
{
    internal class UsuarioDal
    {
        public DataTable ListaUsuario()
        {
            var conn = GVC.Helpers.Conexao.Conex();
            try
            {
                var comando = new SqliteCommand("SELECT UsuarioID, NomeCompleto, Cpf, DataNascimento,  Email, NomeUsuario, TipoUsuario, Senha, DataCriacao FROM Usuarios", conn);

                conn.Open();
                var reader = comando.ExecuteReader();

                var dtUsuario = new DataTable();
                dtUsuario.Load(reader);
                return dtUsuario;
            }
            finally
            {
                conn.Close();
            }
        }

        public void GravaUsuario(UsuarioMODEL usuarios)
        {
            var conn = GVC.Helpers.Conexao.Conex();
            try
            {
                var sqlcomm = new SqliteCommand(
                    "INSERT INTO Usuarios (NomeUsuario, Email, Senha, TipoUsuario, Cpf, DataNascimento, NomeCompleto, DataCriacao) " +
                    "VALUES (@NomeUsuario, @Email, @Senha, @TipoUsuario, @Cpf, @DataNascimento, @NomeCompleto, @DataCriacao)", conn);

                sqlcomm.Parameters.AddWithValue("@NomeUsuario", usuarios.NomeUsuario);
                sqlcomm.Parameters.AddWithValue("@Email", usuarios.Email);
                sqlcomm.Parameters.AddWithValue("@Senha", usuarios.Senha);
                sqlcomm.Parameters.AddWithValue("@TipoUsuario", usuarios.TipoUsuario);
                sqlcomm.Parameters.AddWithValue("@Cpf", usuarios.Cpf);
                sqlcomm.Parameters.AddWithValue("@DataNascimento", usuarios.DataNascimento);
                sqlcomm.Parameters.AddWithValue("@NomeCompleto", usuarios.NomeCompleto);
                sqlcomm.Parameters.AddWithValue("@DataCriacao", usuarios.DataCriacao);

                conn.Open();
                sqlcomm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void ExcluiUsuario(UsuarioMODEL usuarios)
        {
            var conn = GVC.Helpers.Conexao.Conex();
            try
            {
                var sqlcomando = new SqliteCommand("DELETE FROM Usuarios WHERE UsuarioID = @UsuarioID", conn);
                sqlcomando.Parameters.AddWithValue("@UsuarioID", usuarios.UsuarioID);

                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void Atualizar(UsuarioMODEL usuarios)
        {
            var conn = GVC.Helpers.Conexao.Conex();
            try
            {
                var sqlcomm = new SqliteCommand(
                    "UPDATE Usuarios SET NomeUsuario = @NomeUsuario, Email = @Email, Senha = @Senha, " +
                    "TipoUsuario = @TipoUsuario, Cpf = @Cpf, DataNascimento = @DataNascimento, NomeCompleto = @NomeCompleto" +
                    " WHERE UsuarioID = @UsuarioID", conn);

                
                sqlcomm.Parameters.AddWithValue("@NomeUsuario", usuarios.NomeUsuario);
                sqlcomm.Parameters.AddWithValue("@Email", usuarios.Email);
                sqlcomm.Parameters.AddWithValue("@Senha", usuarios.Senha);
                sqlcomm.Parameters.AddWithValue("@TipoUsuario", usuarios.TipoUsuario);
                sqlcomm.Parameters.AddWithValue("@Cpf", usuarios.Cpf);
                sqlcomm.Parameters.AddWithValue("@DataNascimento", usuarios.DataNascimento);
                sqlcomm.Parameters.AddWithValue("@NomeCompleto", usuarios.NomeCompleto);
                sqlcomm.Parameters.AddWithValue("@UsuarioID", usuarios.UsuarioID);

                conn.Open();
                sqlcomm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void AtualizaUsuarioSenha(UsuarioMODEL usuarios)
        {
            var conn = GVC.Helpers.Conexao.Conex();
            try
            {
                var sqlcomm = new SqliteCommand("UPDATE Usuarios SET Senha = @Senha WHERE UsuarioID = @UsuarioID", conn);

                sqlcomm.Parameters.AddWithValue("@Senha", usuarios.Senha);
                sqlcomm.Parameters.AddWithValue("@UsuarioID", usuarios.UsuarioID);

                conn.Open();
                sqlcomm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable PesquisarPorNome(string nome)
        {
            var conn = GVC.Helpers.Conexao.Conex();
            try
            {
                var sqlconn = "SELECT SELECT UsuarioID, NomeCompleto, Cpf, DataNascimento,  Email, NomeUsuario, TipoUsuario, Senha, DataCriacao FROM Usuarios WHERE NomeUsuario LIKE @NomeUsuario";
                var cmd = new SqliteCommand(sqlconn, conn);
                cmd.Parameters.AddWithValue("@NomeUsuario", "%" + nome + "%");

                conn.Open();
                var reader = cmd.ExecuteReader();

                var dt = new DataTable();
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
            }
        }
        public DataTable PesquisarPorCodigo(int nome)
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sqlconn = "SELECT UsuarioID, NomeCompleto, Cpf, DataNascimento,  Email, NomeUsuario, TipoUsuario, Senha, DataCriacao FROM Usuarios WHERE UsuarioID = @UsuarioID";

                using (SqliteCommand cmd = new SqliteCommand(sqlconn, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", Convert.ToInt32(nome));

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
