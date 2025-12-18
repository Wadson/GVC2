using Krypton.Toolkit;
using GVC.BLL;
using GVC.DALL;
using System;
using System.Drawing;
using System.Windows.Forms;
using GVC.View;

namespace GVC
{
    public partial class FrmManutEstado : KryptonForm
    {
        private string StatusOperacao;
        public FrmManutEstado(string statusOperacao)
        {
            InitializeComponent();
            PersonalizarDataGridView(dgvPesquisar);
            this.StatusOperacao = statusOperacao;
            // Personalização do título
            this.Text = "Manutenção de Estados";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 12);
        }
        public void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            // Verifica se há colunas no DataGridView antes de tentar personalizá-las
            if (dgv.Columns.Count > 0)
            {
                // Redimensionar as colunas manualmente
                dgv.Columns["EstadoID"].Width = 60;
                dgv.Columns["EstadoID"].Width = 60;
                dgv.Columns["Nome"].Width = 500;
                dgv.Columns["Uf"].Width = 50;
                dgv.Columns["Regiao"].Width = 60;

                // Centralizar cabeçalhos das colunas
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    // Centralizar o conteúdo das células nas colunas especificadas
                    if (column.Name == "EstadoID")
                    {
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    else if (column.Name == "Nome")
                    {
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Alinhar à esquerda
                    }
                }
            }
        }
        private void CarregaDados()
        {
            //FrmCadEstado frm = new FrmCadEstado(StatusOperacao);

            try
            {
                if (StatusOperacao == "NOVO")
                {
                    //frm.lblStatus.Text = "NOVO CADASTRO DE ESTADO";
                    //frm.lblStatus.ForeColor = Color.FromArgb(8, 142, 254);
                    //StatusOperacao = "NOVO";
                    //frm.ShowDialog();

                    //var frmManutEstado = Application.OpenForms["FrmManutEstado"] as FrmManutEstado;
                    //if (frmManutEstado != null)
                    //{
                    //    frmManutEstado.HabilitarTimer(true);
                    //}

                }
                if (StatusOperacao == "ALTERAR")
                {
                    //frm.txtEstadoID.Text = dgvPesquisar.CurrentRow.Cells["EstadoID"].Value.ToString();
                    //frm.txtEstadoID.Text = dgvPesquisar.CurrentRow.Cells["EstadoID"].Value.ToString();
                    //frm.txtNomeEstado.Text = dgvPesquisar.CurrentRow.Cells["Nome"].Value.ToString();
                    //frm.txtUf.Text = dgvPesquisar.CurrentRow.Cells["Uf"].Value.ToString();
                    //frm.txtUf.Text = dgvPesquisar.CurrentRow.Cells["Regiao"].Value.ToString();

                    //frm.lblStatus.Text = "ALTERAR REGISTRO";
                    //frm.lblStatus.ForeColor = Color.Orange;
                    //StatusOperacao = "ALTERAR";

                    //frm.btnSalvar.Text = "Alterar";
                    //frm.btnNovo.Enabled = false;
                    //frm.ShowDialog();
                    //var frmManutEstado = Application.OpenForms["FrmManutEstado"] as FrmManutEstado;
                    //if (frmManutEstado != null)
                    //{
                    //    frmManutEstado.HabilitarTimer(true);
                    //}
                }
                if (StatusOperacao == "EXCLUSÃO")
                {
                //    frm.txtEstadoID.Text = dgvPesquisar.CurrentRow.Cells["EstadoID"].Value.ToString();
                //    frm.txtNomeEstado.Text = dgvPesquisar.CurrentRow.Cells["Nome"].Value.ToString();
                //    frm.txtUf.Text = dgvPesquisar.CurrentRow.Cells["Uf"].Value.ToString();

                //    frm.lblStatus.Text = "EXCLUSÃO DE REGISTRO";
                //    frm.lblStatus.ForeColor = Color.Orange;
                //    StatusOperacao = "EXCLUSÃO";

                //    frm.btnSalvar.Text = "Excluir";
                //    frm.btnNovo.Enabled = false;
                //    frm.ShowDialog();

                //    var frmManutEstado = Application.OpenForms["FrmManutEstado"] as FrmManutEstado;
                //    if (frmManutEstado != null)
                //    {
                //        frmManutEstado.HabilitarTimer(true);
                //    }
                }

                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
        private void FrmManutUsuario_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            EstadoBLL estadobll = new EstadoBLL();
            dgvPesquisar.DataSource = estadobll.Listar();
            PersonalizarDataGridView(dgvPesquisar);
            Utilitario.AtualizarTotalKrypton(toolStripStatusLabelTotalRegistros, dgvPesquisar);
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Listar();
            timer1.Enabled = false;
        }
        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            txtPesquisar.Focus();
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            txtPesquisar.Focus();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            EstadoDal dao = new EstadoDal();

            if (rbtCodigo.Checked)
            {
                // pesquisa numérica pura
                if (int.TryParse(txtPesquisar.Text, out int id))
                    dgvPesquisar.DataSource = dao.PesquisarPorCodigo(id);
                else
                    dgvPesquisar.DataSource = null;
            }
            else
            {
                // pesquisa textual normal
                string nome = "%" + txtPesquisar.Text + "%";
                dgvPesquisar.DataSource = dao.PesquisarPorNome(nome);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "ALTERAR";
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            StatusOperacao = "ALTERAR";
            CarregaDados();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            StatusOperacao = "EXCLUSÃO";
            CarregaDados();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
