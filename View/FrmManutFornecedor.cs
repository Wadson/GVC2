using GVC.BLL;
using GVC.DALL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GVC.View
{
    public partial class FrmManutFornecedor : KryptonForm
    {
        private string StatusOperacao;

        public FrmManutFornecedor(string statusOperacao)
        {
            this.StatusOperacao = statusOperacao;
            InitializeComponent();

            // Personalização do título
            this.Text = "Manutenção de Fornecedor";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 12);
        }
        public void ListarFornecedor()
        {
            FornecedorBll objetoBll = new FornecedorBll();
            dgvFornecedor.DataSource = objetoBll.Listar();
            PersonalizarDataGridView();
            Utilitario.AtualizarTotal(lblTotalRegistros, dgvFornecedor);
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        public void PersonalizarDataGridView()
        {
            dgvFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Cabeçalhos bonitos
            if (dgvFornecedor.Columns["FornecedorID"] != null) dgvFornecedor.Columns["FornecedorID"].HeaderText = "Código";
            if (dgvFornecedor.Columns["Nome"] != null) dgvFornecedor.Columns["Nome"].HeaderText = "Nome";            
            if (dgvFornecedor.Columns["Cnpj"] != null) dgvFornecedor.Columns["Cnpj"].HeaderText = "CNPJ";                        
            if (dgvFornecedor.Columns["IE"] != null) dgvFornecedor.Columns["IE"].HeaderText = "IE";
            if (dgvFornecedor.Columns["Telefone"] != null) dgvFornecedor.Columns["Telefone"].HeaderText = "Telefone";
            if (dgvFornecedor.Columns["Email"] != null) dgvFornecedor.Columns["Email"].HeaderText = "E-mail";
            if (dgvFornecedor.Columns["Logradouro"] != null) dgvFornecedor.Columns["Logradouro"].HeaderText = "Endereço";
            if (dgvFornecedor.Columns["Numero"] != null) dgvFornecedor.Columns["Numero"].HeaderText = "Número";
            if (dgvFornecedor.Columns["Bairro"] != null) dgvFornecedor.Columns["Bairro"].HeaderText = "Bairro";
            if (dgvFornecedor.Columns["Cep"] != null) dgvFornecedor.Columns["Cep"].HeaderText = "CEP";            
            if (dgvFornecedor.Columns["Observacoes"] != null) dgvFornecedor.Columns["Observacoes"].HeaderText = "Obs.";                
            if (dgvFornecedor.Columns["NomeCidade"] != null) dgvFornecedor.Columns["NomeCidade"].HeaderText = "Cidade";
            if (dgvFornecedor.Columns["Estado"] != null) dgvFornecedor.Columns["Estado"].HeaderText = "UF";

            // Larguras fixas
            var largurasFixas = new (string nome, int largura)[]
            {
                ("FornecedorID",      80),
                ("Nome",          300),  
                ("Cnpj",          160),               
                ("IE",            100),
                ("Telefone",      140),
                ("Email",         240),
                ("Logradouro",    280),
                ("Numero",         80),
                ("Bairro",        180),
                ("Cep",            90),                              
                ("Status",         70),
                ("Observacoes",   200),              
                ("DataCriacao",   130),              
                ("NomeCidade",    200),
                ("Estado",         60)
            };

            foreach (var (nome, largura) in largurasFixas)
            {
                if (dgvFornecedor.Columns[nome] != null)
                {
                    dgvFornecedor.Columns[nome].Width = largura;
                    dgvFornecedor.Columns[nome].Resizable = DataGridViewTriState.False;
                }
            }

            // Colunas fixas
            if (dgvFornecedor.Columns["FornecedorID"] != null) dgvFornecedor.Columns["FornecedorID"].Frozen = true;
            if (dgvFornecedor.Columns["Nome"] != null) dgvFornecedor.Columns["Nome"].Frozen = true;
            if (dgvFornecedor.Columns["Cnpj"] != null) dgvFornecedor.Columns["Cnpj"].Frozen = true;

            // Estilo do cabeçalho
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFornecedor.ColumnHeadersHeight = 35;
            dgvFornecedor.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvFornecedor.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvFornecedor.RowHeadersWidth = 30;

            dgvFornecedor.PerformLayout();
        }

        private void CarregaDados(FrmCadFornecedor frmcadFornecedor)
        {
            // Blindagem de estado
            if (string.IsNullOrWhiteSpace(StatusOperacao))
                throw new InvalidOperationException("StatusOperacao não definido.");

            frmcadFornecedor.StatusOperacao = StatusOperacao;
            
            if (StatusOperacao == "NOVO")
            {
                frmcadFornecedor.Text = "Novo Fornecedor";
                frmcadFornecedor.StateCommon.Header.Content.ShortText.Color1 = Color.Green;
                frmcadFornecedor.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frmcadFornecedor.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
                frmcadFornecedor.ShowDialog();
                return;
            }

            DataGridViewRow row = dgvFornecedor.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Selecione um fornecedor na lista!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmcadFornecedor.CarregandoDados = true;
            frmcadFornecedor.CarregarCampos(row);
            frmcadFornecedor.CarregandoDados = false;

            if (StatusOperacao == "ALTERAR")
            {

                frmcadFornecedor.Text = "Alterar Fornecedor";
                frmcadFornecedor.StateCommon.Header.Content.ShortText.Color1 = Color.Orange;
                frmcadFornecedor.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frmcadFornecedor.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
                frmcadFornecedor.btnSalvar.Text = "Alterar";
                frmcadFornecedor.btnNovo.Enabled = false;

                frmcadFornecedor.DefinirModoEdicao(true);
            }
            else if (StatusOperacao == "EXCLUSAO")
            {

                frmcadFornecedor.Text = "Alterar Fornecedor";
                frmcadFornecedor.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
                frmcadFornecedor.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frmcadFornecedor.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
                frmcadFornecedor.btnSalvar.Text = "Excluir";
                frmcadFornecedor.btnNovo.Enabled = false;

                // Bloqueia edição geral
                frmcadFornecedor.DefinirModoEdicao(false);

                // 🔒 BLOQUEIO ESPECÍFICO DOS TEXTBOX
                foreach (Control ctrl in frmcadFornecedor.Controls)
                {
                    BloquearTextBoxRecursivo(ctrl);
                }
            }


            frmcadFornecedor.ShowDialog();
        }
        private void BloquearTextBoxRecursivo(Control controle)
        {
            if (controle is TextBox txt)
            {
                txt.ReadOnly = true;
                txt.BackColor = SystemColors.Control;
                return;
            }

            foreach (Control filho in controle.Controls)
            {
                BloquearTextBoxRecursivo(filho);
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            FrmCadFornecedor cad = new FrmCadFornecedor();

            cad.StatusOperacao = StatusOperacao;
            cad.CarregandoDados = false;            

            cad.ShowDialog();

            if (cad.DialogResult == DialogResult.OK)
                ListarFornecedor();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.CurrentRow == null)
            {
                MessageBox.Show("Selecione um fornecedor na lista!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StatusOperacao = "ALTERAR";

            FrmCadFornecedor cadFornecedor = new FrmCadFornecedor();

            cadFornecedor.FornecedorID = Convert.ToInt32(
                dgvFornecedor.CurrentRow.Cells["FornecedorID"].Value);

            cadFornecedor.StatusOperacao = StatusOperacao;

            CarregaDados(cadFornecedor);

            if (cadFornecedor.DialogResult == DialogResult.OK)
                ListarFornecedor();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.CurrentRow == null)
            {
                MessageBox.Show("Selecione um fornecedor na lista!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este fornecedor?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resposta != DialogResult.Yes)
                return;

            StatusOperacao = "EXCLUSAO";

            FrmCadFornecedor cadFornecedor = new FrmCadFornecedor();
            cadFornecedor.FornecedorID = Convert.ToInt32(
                dgvFornecedor.CurrentRow.Cells["FornecedorID"].Value);

            cadFornecedor.StatusOperacao = StatusOperacao;

            CarregaDados(cadFornecedor);

            if (cadFornecedor.DialogResult == DialogResult.OK)
                ListarFornecedor();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarFornecedor();
            timer1.Enabled = false;
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string texto = txtPesquisa.Text.Trim();

            if (string.IsNullOrEmpty(texto) && !rbtCodigo.Checked)
            {
                ListarFornecedor();
                return;
            }

            var dao = new FornecedorDal();
            DataTable dt = null;

            if (rbtCodigo.Checked && int.TryParse(texto, out int id))
            {
                dt = dao.PesquisarPorCodigo(id);
            }
            else if (rbtDescricao.Checked)
            {
                dt = dao.PesquisarPorNome(texto);
            }           
            else
            {
                ListarFornecedor();
                return;
            }

            dgvFornecedor.DataSource = dt ?? new DataTable();
            PersonalizarDataGridView();
            Utilitario.AtualizarTotal(lblTotalRegistros, dgvFornecedor);
        }

        private void FrmManutFornecedor_Load(object sender, EventArgs e)
        {
            ListarFornecedor();           
            dgvFornecedor.CellFormatting += dataGridPesquisar_CellFormatting;
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }
        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }
       
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridPesquisar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            string columnName = dgvFornecedor.Columns[e.ColumnIndex].Name;
            string raw = e.Value.ToString();

            // Função auxiliar: extrai apenas dígitos
            string Digitos(string s) => new string(s.Where(char.IsDigit).ToArray());

            // Formatar CPF / CNPJ
            if (columnName == "CpfCnpj")
            {
                string cpfcnpj = Digitos(raw);
                if (cpfcnpj.Length == 11 && ulong.TryParse(cpfcnpj, out ulong n11))
                {
                    e.Value = n11.ToString(@"000\.000\.000\-00");
                    e.FormattingApplied = true;
                    return;
                }
                if (cpfcnpj.Length == 14 && ulong.TryParse(cpfcnpj, out ulong n14))
                {
                    e.Value = n14.ToString(@"00\.000\.000\/0000\-00");
                    e.FormattingApplied = true;
                    return;
                }
                // Se não tem tamanho padrão, apenas mostra os dígitos
                if (!string.IsNullOrEmpty(cpfcnpj))
                {
                    e.Value = cpfcnpj;
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar Telefone
            if (columnName == "Telefone")
            {
                string tel = Digitos(raw);
                if (tel.Length == 11 && ulong.TryParse(tel, out ulong t11))
                {
                    // (00) 00000-0000
                    string s = t11.ToString("00000000000");
                    e.Value = $"({s.Substring(0, 2)}) {s.Substring(2, 5)}-{s.Substring(7, 4)}";
                    e.FormattingApplied = true;
                    return;
                }
                if (tel.Length == 10 && ulong.TryParse(tel, out ulong t10))
                {
                    // (00) 0000-0000
                    string s = t10.ToString("0000000000");
                    e.Value = $"({s.Substring(0, 2)}) {s.Substring(2, 4)}-{s.Substring(6, 4)}";
                    e.FormattingApplied = true;
                    return;
                }
                if (!string.IsNullOrEmpty(tel))
                {
                    e.Value = tel;
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar CEP
            if (columnName == "Cep")
            {
                string cep = Digitos(raw);
                if (cep.Length == 8 && ulong.TryParse(cep, out ulong c))
                {
                    e.Value = c.ToString(@"00000\-000");
                    e.FormattingApplied = true;
                    return;
                }
                if (!string.IsNullOrEmpty(cep))
                {
                    e.Value = cep;
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar Datas (ex.: DataNascimento, DataCriacao, DataUltimaCompra)
            if ((columnName == "DataNascimento" || columnName == "DataCriacao" || columnName == "DataAtualizacao" || columnName == "DataUltimaCompra") && !string.IsNullOrWhiteSpace(raw))
            {
                if (DateTime.TryParse(raw, out DateTime dt))
                {
                    if (columnName == "DataCriacao")
                        e.Value = dt.ToString("dd/MM/yyyy HH:mm"); // data + hora
                    else
                        e.Value = dt.ToString("dd/MM/yyyy"); // só data
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar Moeda (ex.: ValorTotal, Saldo, LimiteCredito)
            if ((columnName == "ValorTotal" || columnName == "Saldo" || columnName == "LimiteCredito" ||
                 columnName == "Valor" || columnName == "Preco" || columnName == "Total") && !string.IsNullOrWhiteSpace(raw))
            {
                if (decimal.TryParse(raw, out decimal valor))
                {
                    e.Value = valor.ToString("N2");
                    e.FormattingApplied = true;
                    return;
                }
            }
            // Verifica se a coluna é a de status (supondo que o nome seja "Ativo")
            if (dgvFornecedor.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                // Só tenta converter se ainda for número (0 ou 1)
                if (int.TryParse(e.Value.ToString(), out int valor))
                {
                    if (valor == 1)
                    {
                        e.Value = "Ativo";
                        e.FormattingApplied = true;
                    }
                    else if (valor == 0)
                    {
                        e.Value = "Inativo";
                        e.FormattingApplied = true;
                    }
                }
            }

        }

    }
}
