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
    public partial class FrmManutCliente : KryptonForm
    {
        private string StatusOperacao;

        public FrmManutCliente(string statusOperacao)
        {
            this.StatusOperacao = statusOperacao;
            InitializeComponent();

            // Personalização do título
            this.Text = "Manutenção de Clientes";            
            this.StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 12);
        }
        public void ListarCliente()
        {
            ClienteBLL objetoBll = new ClienteBLL();
            dgvCliente.DataSource = objetoBll.Listar();
            PersonalizarDataGridView();
            Utilitario.AtualizarTotal(lblTotalRegistros, dgvCliente);
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        public void PersonalizarDataGridView()
        {
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Cabeçalhos bonitos
            if (dgvCliente.Columns["ClienteID"] != null) dgvCliente.Columns["ClienteID"].HeaderText = "Código";
            if (dgvCliente.Columns["Nome"] != null) dgvCliente.Columns["Nome"].HeaderText = "Nome";
            if (dgvCliente.Columns["Cpf"] != null) dgvCliente.Columns["Cpf"].HeaderText = "CPF";
            if (dgvCliente.Columns["Cnpj"] != null) dgvCliente.Columns["Cnpj"].HeaderText = "CNPJ";
            if (dgvCliente.Columns["RG"] != null) dgvCliente.Columns["RG"].HeaderText = "RG";
            if (dgvCliente.Columns["OrgaoExpedidorRG"] != null) dgvCliente.Columns["OrgaoExpedidorRG"].HeaderText = "Órgão Exp.";
            if (dgvCliente.Columns["IE"] != null) dgvCliente.Columns["IE"].HeaderText = "IE";
            if (dgvCliente.Columns["Telefone"] != null) dgvCliente.Columns["Telefone"].HeaderText = "Telefone";
            if (dgvCliente.Columns["Email"] != null) dgvCliente.Columns["Email"].HeaderText = "E-mail";
            if (dgvCliente.Columns["Logradouro"] != null) dgvCliente.Columns["Logradouro"].HeaderText = "Endereço";
            if (dgvCliente.Columns["Numero"] != null) dgvCliente.Columns["Numero"].HeaderText = "Número";
            if (dgvCliente.Columns["Bairro"] != null) dgvCliente.Columns["Bairro"].HeaderText = "Bairro";
            if (dgvCliente.Columns["Cep"] != null) dgvCliente.Columns["Cep"].HeaderText = "CEP";
            if (dgvCliente.Columns["DataNascimento"] != null) dgvCliente.Columns["DataNascimento"].HeaderText = "Dt. Nasc.";
            if (dgvCliente.Columns["TipoCliente"] != null) dgvCliente.Columns["TipoCliente"].HeaderText = "Tipo";
            if (dgvCliente.Columns["Status"] != null) dgvCliente.Columns["Status"].HeaderText = "Status";
            if (dgvCliente.Columns["Observacoes"] != null) dgvCliente.Columns["Observacoes"].HeaderText = "Obs.";
            if (dgvCliente.Columns["DataUltimaCompra"] != null) dgvCliente.Columns["DataUltimaCompra"].HeaderText = "Últ. Compra";
            if (dgvCliente.Columns["LimiteCredito"] != null) dgvCliente.Columns["LimiteCredito"].HeaderText = "Limite";
            if (dgvCliente.Columns["DataCriacao"] != null) dgvCliente.Columns["DataCriacao"].HeaderText = "Criação";
            if (dgvCliente.Columns["DataAtualizacao"] != null) dgvCliente.Columns["DataAtualizacao"].HeaderText = "Atualização";
            if (dgvCliente.Columns["UsuarioCriacao"] != null) dgvCliente.Columns["UsuarioCriacao"].HeaderText = "Usuário Criação";
            if (dgvCliente.Columns["UsuarioAtualizacao"] != null) dgvCliente.Columns["UsuarioAtualizacao"].HeaderText = "Usuário Atualização";
            if (dgvCliente.Columns["NomeCidade"] != null) dgvCliente.Columns["NomeCidade"].HeaderText = "Cidade";
            if (dgvCliente.Columns["Estado"] != null) dgvCliente.Columns["Estado"].HeaderText = "UF";

            // Larguras fixas
            var largurasFixas = new (string nome, int largura)[]
            {
                ("ClienteID",      80),
                ("Nome",          300),
                ("Cpf",           120),
                ("OrgaoExpedidorRG",150),
                ("Cnpj",          160),
                ("RG",            100),
                ("IE",            100),
                ("Telefone",      140),
                ("Email",         240),
                ("Logradouro",    280),
                ("Numero",         80),
                ("Bairro",        180),
                ("Cep",            90),
                ("DataNascimento",100),
                ("TipoCliente",   100),
                ("Status",         70),
                ("Observacoes",   200),
                ("DataUltimaCompra",120),
                ("LimiteCredito", 110),
                ("DataCriacao",   130),
                ("DataAtualizacao",130),
                ("UsuarioCriacao",150),
                ("UsuarioAtualizacao",150),
                ("NomeCidade",    200),
                ("Estado",         60)
            };

            foreach (var (nome, largura) in largurasFixas)
            {
                if (dgvCliente.Columns[nome] != null)
                {
                    dgvCliente.Columns[nome].Width = largura;
                    dgvCliente.Columns[nome].Resizable = DataGridViewTriState.False;
                }
            }

            // Colunas fixas
            if (dgvCliente.Columns["ClienteID"] != null) dgvCliente.Columns["ClienteID"].Frozen = true;
            if (dgvCliente.Columns["Nome"] != null) dgvCliente.Columns["Nome"].Frozen = true;
            if (dgvCliente.Columns["Cpf"] != null) dgvCliente.Columns["Cpf"].Frozen = true;

            // Estilo do cabeçalho
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCliente.ColumnHeadersHeight = 35;
            dgvCliente.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCliente.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvCliente.RowHeadersWidth = 30;

            dgvCliente.PerformLayout();
        }

        private void CarregaDados(FrmCadCliente frmcadCliente)
        {
            // Blindagem de estado
            if (string.IsNullOrWhiteSpace(StatusOperacao))
                throw new InvalidOperationException("StatusOperacao não definido.");

            frmcadCliente.StatusOperacao = StatusOperacao;

            // MODO NOVO
            if (StatusOperacao == "NOVO")
            {

               frmcadCliente.Text = "Novo Cliente";
               frmcadCliente.StateCommon.Header.Content.ShortText.Color1 = Color.Green;
               frmcadCliente.StateCommon.Header.Content.ShortText.Color2 = Color.White;
               frmcadCliente.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
                
                frmcadCliente.ShowDialog();
                return;
            }

            DataGridViewRow row = dgvCliente.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Selecione um cliente na lista!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmcadCliente.CarregandoDados = true;
            frmcadCliente.CarregarCampos(row);
            frmcadCliente.CarregandoDados = false;

            if (StatusOperacao == "ALTERAR")
            {
                frmcadCliente.Text = "Alterar Cliente";
                frmcadCliente.StateCommon.Header.Content.ShortText.Color1 = Color.Orange;
                frmcadCliente.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frmcadCliente.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
                frmcadCliente.btnSalvar.Text = "Alterar";
                frmcadCliente.btnNovo.Enabled = false;
                frmcadCliente.DefinirModoEdicao(true);
            }
            else if (StatusOperacao == "EXCLUSAO")
            {
                frmcadCliente.Text = "Excluir Cliente";
                frmcadCliente.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
                frmcadCliente.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frmcadCliente.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
                frmcadCliente.btnSalvar.Text = "Excluir";
                frmcadCliente.btnNovo.Enabled = false;                

                // Bloqueia edição geral
                frmcadCliente.DefinirModoEdicao(false);

                // 🔒 BLOQUEIO ESPECÍFICO DOS TEXTBOX
                foreach (Control ctrl in frmcadCliente.Controls)
                {
                    BloquearTextBoxRecursivo(ctrl);
                }
            }


            frmcadCliente.ShowDialog();
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

            FrmCadCliente cad = new FrmCadCliente();
            cad.StatusOperacao = StatusOperacao;
            cad.CarregandoDados = false;
            cad.Text = "Novo Cliente";
            cad.ForeColor = Color.FromArgb(8, 142, 254);

            cad.ShowDialog();

            if (cad.DialogResult == DialogResult.OK)
                ListarCliente();


        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente na lista!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StatusOperacao = "ALTERAR";

            FrmCadCliente cadCliente = new FrmCadCliente();
            cadCliente.ClienteID = Convert.ToInt32(
                dgvCliente.CurrentRow.Cells["ClienteID"].Value);

            cadCliente.StatusOperacao = StatusOperacao;

            CarregaDados(cadCliente);

            if (cadCliente.DialogResult == DialogResult.OK)
                ListarCliente();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente na lista!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este cliente?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resposta != DialogResult.Yes)
                return;

            StatusOperacao = "EXCLUSAO";

            FrmCadCliente cadCliente = new FrmCadCliente();
            cadCliente.ClienteID = Convert.ToInt32(
                dgvCliente.CurrentRow.Cells["ClienteID"].Value);

            cadCliente.StatusOperacao = StatusOperacao;

            CarregaDados(cadCliente);

            if (cadCliente.DialogResult == DialogResult.OK)
                ListarCliente();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarCliente();
            timer1.Enabled = false;
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string texto = txtPesquisa.Text.Trim();

            if (string.IsNullOrEmpty(texto) && !rbtCodigo.Checked)
            {
                ListarCliente();
                return;
            }

            var dao = new ClienteDal();
            DataTable dt = null;

            if (rbtCodigo.Checked && int.TryParse(texto, out int id))
            {
                dt = dao.PesquisarPorCodigo(id);
            }
            else if (rbtDescricao.Checked)
            {
                dt = dao.PesquisarPorNome(texto);
            }
            else if (rbClientes.Checked || rbFornecedores.Checked)
            {
                dt = dao.PesquisarGeral(texto);

                if (dt?.Rows.Count > 0)
                {
                    string tipoFiltro = rbClientes.Checked ? "Física" : "Jurídica";
                    dt.DefaultView.RowFilter = $"TipoCliente = '{tipoFiltro}'";
                    dt = dt.DefaultView.ToTable();
                }
            }
            else
            {
                ListarCliente();
                return;
            }

            dgvCliente.DataSource = dt ?? new DataTable();
            PersonalizarDataGridView();
            Utilitario.AtualizarTotal(lblTotalRegistros, dgvCliente);
        }

        private void FrmManutCliente_Load(object sender, EventArgs e)
        {

            ListarCliente();           
            dgvCliente.CellFormatting += dataGridPesquisar_CellFormatting;
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
        private void rbClientes_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void rbFornecedores_CheckedChanged(object sender, EventArgs e)
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

            string columnName = dgvCliente.Columns[e.ColumnIndex].Name;
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
            if (dgvCliente.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
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
