using Krypton.Toolkit;
using GVC.BLL;
using GVC.DALL;
using GVC.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace GVC
{
    public partial class FrmManutUsuario : KryptonForm
    {
        private string StatusOperacao { get; set; }
        public FrmManutUsuario(string statusOperacao)
        {
            InitializeComponent();
            this.StatusOperacao = statusOperacao;
            // Personalização do título
            this.Text = "Manutenção de Usuários";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 12);
        }

        private void CarregaDados()
        {
            FrmCadUser cadUsuarios = new FrmCadUser(StatusOperacao);

            if (StatusOperacao != "NOVO" && dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }            
            try
            {
                if (StatusOperacao == "NOVO")
                {
                    //cadUsuarios.Text = "Novo Cadastro";
                    cadUsuarios.ForeColor = Color.FromArgb(8, 142, 254);
                    StatusOperacao = "NOVO";
                    cadUsuarios.ShowDialog();
                }
                else if (StatusOperacao == "ALTERAR")
                {
                    CarregarCamposComuns(cadUsuarios);
                    //cadUsuarios.Text = "Alterar Registro";
                    StatusOperacao = "ALTERAR";
                    cadUsuarios.btnSalvar.Text = "Alterar";
                    cadUsuarios.btnNovo.Enabled = false;
                    cadUsuarios.ShowDialog();
                }
                else if (StatusOperacao == "EXCLUSÃO")
                {
                    CarregarCamposComuns(cadUsuarios);
                    //cadUsuarios.Text = "Excluir Registro";
                    StatusOperacao = "EXCLUSÃO";
                    cadUsuarios.btnSalvar.Text = "Excluir";


                    cadUsuarios.btnNovo.Enabled = false;
                    cadUsuarios.txtNomeUsuario.Enabled = false;
                    cadUsuarios.txtEmail.Enabled = false;
                    cadUsuarios.txtNovaSenha.Enabled = false;
                    cadUsuarios.cmbTipoUsuario.Enabled = false;
                    cadUsuarios.txtRepitaSenha.Enabled = false;
                    cadUsuarios.txtCPF.Enabled = false;
                    cadUsuarios.dtpDataNascimento.Enabled = false;
                    cadUsuarios.txtNomeCompleto.Enabled = false;
                    cadUsuarios.ShowDialog();
                }

                var frmManutUsuario = Application.OpenForms["FrmManutUsuario"] as FrmManutUsuario;
                if (frmManutUsuario != null)
                {
                    frmManutUsuario.HabilitarTimer(true);
                }
                ListaUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }

        private void CarregarCamposComuns(FrmCadUser cadUsuarios)
        {
            int usuarioID = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["UsuarioID"].Value.ToString());
            cadUsuarios.UsuarioID = usuarioID;
            cadUsuarios.txtNomeCompleto.Text = dgvUsuarios.CurrentRow.Cells["NomeCompleto"].Value.ToString();
            cadUsuarios.txtNomeUsuario.Text = dgvUsuarios.CurrentRow.Cells["NomeUsuario"].Value.ToString();
            cadUsuarios.txtEmail.Text = dgvUsuarios.CurrentRow.Cells["Email"].Value.ToString();
            // Não carregar senha para segurança
            cadUsuarios.cmbTipoUsuario.Text = dgvUsuarios.CurrentRow.Cells["TipoUsuario"].Value.ToString();
            cadUsuarios.txtCPF.Text = dgvUsuarios.CurrentRow.Cells["CPF"].Value.ToString();
            cadUsuarios.dtpDataNascimento.Value = Convert.ToDateTime(dgvUsuarios.CurrentRow.Cells["DataNascimento"].Value.ToString());
            cadUsuarios.lblDataCadastro.Text = "Data de Cadastro: " + Convert.ToDateTime(dgvUsuarios.CurrentRow.Cells["DataCriacao"].Value.ToString()).ToString("dd/MM/yyyy");
        }

        private void FrmManutUsuario_Load(object sender, EventArgs e)
        {
            ListaUsuario();
            dgvUsuarios.CellFormatting += dataGridPesquisar_CellFormatting;
        }

        public void PersonalizarDataGridView()
        {
            // 1. Desliga o auto‑resize global
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 2. Cabeçalhos bonitos
            if (dgvUsuarios.Columns["UsuarioID"] != null) dgvUsuarios.Columns["UsuarioID"].HeaderText = "Código";
            if (dgvUsuarios.Columns["NomeCompleto"] != null) dgvUsuarios.Columns["NomeCompleto"].HeaderText = "Nome";
            if (dgvUsuarios.Columns["NomeUsuario"] != null) dgvUsuarios.Columns["NomeUsuario"].HeaderText = "Usuário";
            if (dgvUsuarios.Columns["Email"] != null) dgvUsuarios.Columns["Email"].HeaderText = "E-mail";
            if (dgvUsuarios.Columns["Senha"] != null) dgvUsuarios.Columns["Senha"].HeaderText = "Senha";
            if (dgvUsuarios.Columns["TipoUsuario"] != null) dgvUsuarios.Columns["TipoUsuario"].HeaderText = "Tipo";
            if (dgvUsuarios.Columns["CPF"] != null) dgvUsuarios.Columns["CPF"].HeaderText = "CPF";
            if (dgvUsuarios.Columns["DataNascimento"] != null) dgvUsuarios.Columns["DataNascimento"].HeaderText = "Nascimento";

            // 3. Colunas fixas (largura definida e não mudam)
            var colunasFixas = new (string nome, int largura)[]
            {
        ("UsuarioID", 80),
        ("NomeCompleto", 250),
        ("NomeUsuario", 250),
        ("Email", 250),
        ("TipoUsuario", 100),
        ("CPF", 120),
        ("DataNascimento", 120),
        ("DataCriacao", 120)
            };

            foreach (var (nome, largura) in colunasFixas)
            {
                if (dgvUsuarios.Columns[nome] != null)
                {
                    var col = dgvUsuarios.Columns[nome];
                    col.Width = largura;
                    col.Resizable = DataGridViewTriState.False;
                    col.ReadOnly = true;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // 🔑 fixa
                }
            }

            // 4. Colunas dinâmicas (ajustam conforme conteúdo)
            var colunasAuto = new string[]
            {
                "Senha" // se quiser deixar ajustável, mas oculta depois
            };

            foreach (var nome in colunasAuto)
            {
                if (dgvUsuarios.Columns[nome] != null)
                {
                    var col = dgvUsuarios.Columns[nome];
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    col.ReadOnly = true;
                }
            }

            // 5. Congela algumas colunas
            if (dgvUsuarios.Columns["UsuarioID"] != null) dgvUsuarios.Columns["UsuarioID"].Frozen = true;
            if (dgvUsuarios.Columns["NomeCompleto"] != null) dgvUsuarios.Columns["NomeCompleto"].Frozen = true;

            // 6. Estilo do cabeçalho
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.ColumnHeadersHeight = 35;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.RowHeadersWidth = 30;

            // 7. Formatações especiais
            if (dgvUsuarios.Columns["CPF"] != null)
            {
                dgvUsuarios.Columns["CPF"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvUsuarios.Columns["DataNascimento"] != null)
            {
                dgvUsuarios.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvUsuarios.Columns["DataNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // 8. Ocultar colunas sensíveis
            if (dgvUsuarios.Columns["UsuarioID"] != null) dgvUsuarios.Columns["UsuarioID"].Visible = false;
            if (dgvUsuarios.Columns["Senha"] != null) dgvUsuarios.Columns["Senha"].Visible = false;

            // 9. Força o grid a respeitar tudo
            dgvUsuarios.PerformLayout();
        }


        public void ListaUsuario()
        {
            UsuarioBLL usuariosBll = new UsuarioBLL();
            dgvUsuarios.DataSource = usuariosBll.Listar();
            PersonalizarDataGridView();
            Utilitario.AtualizarTotalKrypton(toolStripStatusLabelTotalRegistros, dgvUsuarios);
        }

        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaUsuario();
            timer1.Enabled = false;
        }

        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string textoPesquisa = txtPesquisa.Text.ToLower();           
            UsuarioDal dao = new UsuarioDal();

            if (rbtCodigo.Checked)
            {
                if (int.TryParse(textoPesquisa, out int codigo)) // só tenta se for número
                {
                    dgvUsuarios.DataSource = dao.PesquisarPorCodigo(codigo);
                    PersonalizarDataGridView();
                }
                else
                {
                    dgvUsuarios.DataSource = null; // limpa se não for número válido
                }
            }
            else
            {
                string nome = "%" + textoPesquisa + "%";
                dgvUsuarios.DataSource = dao.PesquisarPorNome(nome);
                PersonalizarDataGridView();
            }
            Utilitario.AtualizarTotalKrypton(toolStripStatusLabelTotalRegistros, dgvUsuarios);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para alterar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "ALTERAR";
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "EXCLUSÃO";
            CarregaDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridPesquisar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;
            string columnName = dgvUsuarios.Columns[e.ColumnIndex].Name;
            string raw = e.Value.ToString();
            string Digitos(string s) => new string(s.Where(char.IsDigit).ToArray());
            if (columnName == "CPF")
            {
                string cpf = Digitos(raw);
                if (cpf.Length == 11 && ulong.TryParse(cpf, out ulong n11))
                {
                    e.Value = n11.ToString(@"000\.000\.000\-00");
                    e.FormattingApplied = true;
                    return;
                }
                if (!string.IsNullOrEmpty(cpf))
                {
                    e.Value = cpf;
                    e.FormattingApplied = true;
                    return;
                }
            }
            if (columnName == "DataNascimento" || columnName == "DataCriacao")
            {
                try
                {
                    if (e.Value is DateTime dt)
                    {
                        e.Value = dt.ToString("dd/MM/yyyy");
                        e.FormattingApplied = true;
                        return;
                    }
                    else if (DateTime.TryParse(e.Value.ToString(), out DateTime parsedDate))
                    {
                        e.Value = parsedDate.ToString("dd/MM/yyyy");
                        e.FormattingApplied = true;
                        return;
                    }
                }
                catch
                {
                    // Mantém o valor original
                }
            }
        }

        private void FrmManutUsuario_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }
    }
}