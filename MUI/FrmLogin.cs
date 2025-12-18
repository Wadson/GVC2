using GVC.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using Krypton.Toolkit;

namespace GVC.MUI
{
    public partial class FrmLogin : KryptonForm
    {
        // Propriedades estáticas para armazenar os dados do usuário
        public static string UsuarioConectado { get; set; }
        public static string NivelAcesso { get; set; }

        public FrmLogin()
        {
            InitializeComponent();

            //Utilitario.AdicionarEfeitoFocoEmTodos(this);
            Utilitario.ConfigurarEnterComoTab(this);

            this.KeyPreview = true; // habilita o preview das teclas
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AtivarCampo(KryptonTextBox textBox, PictureBox pictureBox, Panel panel, Image imagemAtiva)
        {
            ResetarCampos();

            pictureBox.Image = imagemAtiva;
            panel.BackColor = Color.FromArgb(8, 142, 254);
            textBox.ForeColor = Color.FromArgb(78, 184, 206);

            // Fundo verde claro
            textBox.StateCommon.Back.Color1 = Color.FromArgb(200, 255, 200);
        }

        private void DesativarCampo(KryptonTextBox textBox, PictureBox pictureBox, Panel panel, Image imagemInativa)
        {
            pictureBox.Image = imagemInativa;
            panel.BackColor = Color.White;
            textBox.ForeColor = Color.White;

            // Fundo branco
            textBox.StateCommon.Back.Color1 = Color.White;
        }

        private void ResetarCampos()
        {
            // Usuário
            pictureBoxUser.Image = Properties.Resources.Usuario24;
            panel1.BackColor = Color.White;
            txtUsuario.ForeColor = Color.White;
            txtUsuario.StateCommon.Back.Color1 = Color.White;

            // Senha
            pictureBoxRepetePassWord.Image = Properties.Resources.Senhas24;
            panel3.BackColor = Color.White;
            txtSenha.ForeColor = Color.White;
            txtSenha.StateCommon.Back.Color1 = Color.White;
        }


        private void txtRepetPass_Leave(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void ObterDadosUsuario(string usuario, string senhaHash)
        {
            string query = "SELECT NomeUsuario, TipoUsuario FROM Usuarios WHERE NomeUsuario = @Usuario AND Senha = @Senha";

            using (var con = GVC.Helpers.Conexao.Conex())
            {
                using (SqliteCommand cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senhaHash);

                    con.Open();
                    SqliteDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        UsuarioConectado = reader["NomeUsuario"].ToString();
                        NivelAcesso = reader["TipoUsuario"].ToString();
                    }
                }
            }
        }

        private string ValidarLogin(string usuario, string password)
        {
            string senhaHash = GerarHashSHA256(password);

            using (var con = GVC.Helpers.Conexao.Conex())
            {
                // Primeiro: verificar se o usuário existe
                string queryUsuario = "SELECT Senha, TipoUsuario FROM Usuarios WHERE NomeUsuario = @Usuario";
                using (SqliteCommand cmd = new SqliteCommand(queryUsuario, con))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);

                    con.Open();
                    var reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        // Usuário não encontrado → mas vamos checar se a senha existe em algum usuário
                        con.Close();

                        string querySenha = "SELECT 1 FROM Usuarios WHERE Senha = @Senha";
                        using (var cmdSenha = new SqliteCommand(querySenha, con))
                        {
                            cmdSenha.Parameters.AddWithValue("@Senha", senhaHash);
                            con.Open();
                            var senhaReader = cmdSenha.ExecuteReader();

                            if (!senhaReader.Read())
                            {
                                return "Usuário e senha incorretos!";
                            }
                            else
                            {
                                return "Usuário incorreto!";
                            }
                        }
                    }

                    // Usuário existe → verificar senha
                    string senhaBanco = reader["Senha"].ToString();
                    string tipoUsuario = reader["TipoUsuario"].ToString();

                    if (senhaBanco != senhaHash)
                    {
                        return "Senha incorreta!";
                    }

                    // Se chegou aqui, login válido
                    UsuarioConectado = usuario;
                    NivelAcesso = tipoUsuario;
                    return "OK";
                }
            }
        }


        private bool VerificarSenhaHash(string senhaDigitada, string hashBanco)
        {
            // Gera o hash da senha digitada para comparar com o hash armazenado
            string hashSenhaDigitada = GerarHashSHA256(senhaDigitada);
            return hashSenhaDigitada == hashBanco;
        }

        private string GerarHashSHA256(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtSenha.Text;

            string resultado = ValidarLogin(usuario, password);

            if (resultado == "OK")
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FrmTelaPrincipal frm = new FrmTelaPrincipal();
                frm.Show();

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show(resultado, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRepetPass_Validating(object sender, CancelEventArgs e)
        {
            ResetarCampos();
        }

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            FrmRecuperarSenhaOffline frmRecuperarSenhaOffline = new FrmRecuperarSenhaOffline();
            frmRecuperarSenhaOffline.ShowDialog();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Exemplo: fecha o formulário
                this.Close();
                e.Handled = true;
            }
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            AtivarCampo(txtUsuario, pictureBoxUser, panel1,
                Properties.Resources.UsuarioBlue24);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            DesativarCampo(txtUsuario, pictureBoxUser, panel1,
                   Properties.Resources.Usuario24);
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            AtivarCampo(txtSenha, pictureBoxRepetePassWord, panel3,
                Properties.Resources.SenhasBlue24);
        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            DesativarCampo(txtSenha, pictureBoxRepetePassWord, panel3,
                  Properties.Resources.Senhas24);
        }   

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o Enter dentro do campo acione o login
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Opcional: mover para o próximo campo
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o Enter dentro do campo acione o login
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Opcional: acionar o botão de login só aqui
                btnLogin.PerformClick();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

       
    }
}
