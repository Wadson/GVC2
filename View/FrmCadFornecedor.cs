using GVC.BLL;
using GVC.MODEL;
using GVC.MUI;
using Krypton.Toolkit;
using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmCadFornecedor : KryptonForm
    {
        public bool CarregandoDados { get; set; }

        private readonly FornecedorBll _fornecedorBll = new FornecedorBll();
        private readonly string QueryFornecedor = "SELECT MAX(FornecedorID) FROM Fornecedor";
        public string StatusOperacao { get; set; }
        public string cidadeSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        private bool bloqueiaPesquisa = false;
        public int FornecedorID { get; set; }
        public int CidadeID { get; set; }

        public FrmCadFornecedor()
        {
            InitializeComponent();
        }

        public void DefinirModoEdicao(bool habilitar)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBoxBase || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is CheckBox)
                {
                    ctrl.Enabled = habilitar;
                }
            }
            txtFornecedorID.Enabled = false;// Sempre deixa o ID travado                       
        }

        // método público chamado pelo formulário pai
        public void CarregarCampos(DataGridViewRow row)
        {
            if (row == null)
                return;

            CarregandoDados = true; // evita eventos indevidos (especialmente SelectedIndexChanged)

            try
            {
                // Identificação
                txtFornecedorID.Text = row.Cells["FornecedorID"].Value?.ToString() ?? "";
                if (int.TryParse(txtFornecedorID.Text, out int id))
                    this.FornecedorID = id;
                else
                    this.FornecedorID = 0;

                txtNomeFornecedor.Text = row.Cells["Nome"].Value?.ToString() ?? "";
                txtCnpj.Text = row.Cells["Cnpj"].Value?.ToString() ?? "";
                txtIE.Text = row.Cells["IE"].Value?.ToString() ?? "";
                txtTelefone.Text = row.Cells["Telefone"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtLogradouro.Text = row.Cells["Logradouro"].Value?.ToString() ?? "";
                txtNumero.Text = row.Cells["Numero"].Value?.ToString() ?? "";
                txtBairro.Text = row.Cells["Bairro"].Value?.ToString() ?? "";
                txtCep.Text = row.Cells["Cep"].Value?.ToString() ?? "";
                this.CidadeID = int.TryParse(row.Cells["CidadeID"].Value?.ToString(), out int cid) ? cid : 0;
                txtNomeCidade.Text = row.Cells["NomeCidade"].Value?.ToString() ?? "";
                txtUF.Text = row.Cells["Estado"].Value?.ToString() ?? "";
                txtObservacoes.Text = row.Cells["Observacoes"].Value?.ToString() ?? "";
                ToolStripLabelDataCriacao.Text = row.Cells["DataCriacao"].Value?.ToString() ?? "";

                // CNPJ — formatação
                string cnpj = row.Cells["Cnpj"].Value?.ToString() ?? "";
                cnpj = new string(cnpj.Where(char.IsDigit).ToArray());
                if (!string.IsNullOrWhiteSpace(cnpj))
                {
                    if (cnpj.Length == 14)
                        txtCnpj.Text = Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
                    else
                        txtCnpj.Text = cnpj;
                }

                // Telefone — formatação
                string telefone = row.Cells["Telefone"].Value?.ToString() ?? "";
                telefone = new string(telefone.Where(char.IsDigit).ToArray());
                if (telefone.Length == 10)
                    txtTelefone.Text = Convert.ToUInt64(telefone).ToString(@"(00) 0000\-0000");
                else if (telefone.Length == 11)
                    txtTelefone.Text = Convert.ToUInt64(telefone).ToString(@"(00) 00000\-0000");
                else
                    txtTelefone.Text = telefone;

                // CEP — formatação
                string cep = row.Cells["Cep"].Value?.ToString() ?? "";
                cep = new string(cep.Where(char.IsDigit).ToArray());
                if (cep.Length == 8)
                    txtCep.Text = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";
                else
                    txtCep.Text = cep;

                // Data de nascimento
                if (DateTime.TryParse(row.Cells["DataCriacao"].Value?.ToString(), out DateTime dtN))
                    dtpDataCriacao.Value = dtN;
                else
                    dtpDataCriacao.Value = DateTime.Now;
            }
            finally
            {
                CarregandoDados = false;
            }
        }

        // Colocar dentro do FrmCadFornecedor
        private void HabilitarCampos(bool habilitar)
        {
            // iniciar a recursão a partir do próprio formulário (this)
            SetControlsEnabled(this, habilitar);
        }
        private void SetControlsEnabled(Control parent, bool enabled)
        {
            foreach (Control c in parent.Controls)
            {
                // Habilita/Desabilita TextBox COMUM e KryptonTextBox
                if (c is TextBoxBase ||
                    c is Krypton.Toolkit.KryptonTextBox ||
                    c is MaskedTextBox ||
                    c is ComboBox)
                {
                    c.Enabled = enabled;
                }
                // Continua recursão
                if (c.HasChildren)
                    SetControlsEnabled(c, enabled);
            }
        }
        // 👉 aqui entra o seu método
        private void FrmCadFornecedor_Load(object sender, EventArgs e)
        {
            // Sempre configura máscaras necessárias
            txtCnpj.Tag = "CNPJ";

            // Se está carregando dados (e.g., Alterar/Exclusão), não faz setup de "novo"
            if (CarregandoDados)
            {
                return; // Apenas garante máscaras e sai
            }

            if (StatusOperacao == "NOVO")
            {
                this.Text = "Novo Fornecedor";
                this.StateCommon.Header.Content.ShortText.Color1 = Color.Green;
                this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);

                GerarNovoCodigo();

                var frmManutFornecedor = Application.OpenForms["FrmManutFornecedor"] as FrmManutFornecedor;
                frmManutFornecedor?.HabilitarTimer(true);

                toolStripStatusLabelUsuarioCriacao.Text = FrmLogin.UsuarioConectado;
                ToolStripLabelDataCriacao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                // Como é novo, não existe atualização ainda:
                toolStripStatusLabelUsuarioAtualizacao.Text = "-";
                ToolStripLabelDataUtimaCompra.Text = "-";
            }

            // Finaliza o estado de carregamento
            CarregandoDados = false;
        }

        private void GerarNovoCodigo()
        {
            int novoId = Utilitario.ProximoId(QueryFornecedor);
            FornecedorID = novoId;
            txtFornecedorID.Text = Utilitario.ZerosEsquerda(novoId, 6);
        }

        public void SalvarRegistro()
        {
            try
            {
                var fornecedor = MontarObjetoFornecedor();
                _fornecedorBll.Salvar(fornecedor);

                MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                var frmManutFornecedor = Application.OpenForms["FrmManutFornecedor"] as FrmManutFornecedor;
                if (frmManutFornecedor != null)
                {
                    frmManutFornecedor.HabilitarTimer(true);
                }
                LimparCampos();
                GerarNovoCodigo();
                txtNomeFornecedor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AlterarRegistro()
        {
            try
            {
                var fornecedor = MontarObjetoFornecedor();
                _fornecedorBll.Alterar(fornecedor);

                MessageBox.Show("Fornecedor alterado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                toolStripStatusLabelUsuarioAtualizacao.Text = FrmLogin.UsuarioConectado;
                ToolStripLabelDataUtimaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                this.Close();

                var frmManutFornecedor = Application.OpenForms["FrmManutFornecedor"] as FrmManutFornecedor;
                if (frmManutFornecedor != null)
                {
                    frmManutFornecedor.HabilitarTimer(true);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Outro fornecedor já está cadastrado"))
                    MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ExcluirRegistro()
        {
            if (MessageBox.Show($"Deseja realmente excluir o fornecedor:\n\n{txtNomeFornecedor.Text}?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _fornecedorBll.Excluir(FornecedorID);
                    MessageBox.Show("Fornecedor excluído com sucesso!", "Excluído",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    var frmManutFornecedor = Application.OpenForms["FrmManutFornecedor"] as FrmManutFornecedor;
                    if (frmManutFornecedor != null)
                    {
                        frmManutFornecedor.HabilitarTimer(true);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private FornecedorModel MontarObjetoFornecedor()
        {
            var fornecedor = new FornecedorModel();

            fornecedor.Nome = txtNomeFornecedor.Text.Trim();
            fornecedor.Cnpj = Utilitario.ApenasNumeros(txtCnpj.Text);
            fornecedor.IE = txtIE.Text.Trim();
            fornecedor.Telefone = Utilitario.ApenasNumeros(txtTelefone.Text);
            fornecedor.Email = txtEmail.Text.Trim();
            if (int.TryParse(txtFornecedorID.Text, out int id)) fornecedor.FornecedorID = id;
            fornecedor.CidadeID = CidadeID;
            fornecedor.Logradouro = txtLogradouro.Text.Trim();
            fornecedor.Numero = txtNumero.Text.Trim();
            fornecedor.Bairro = txtBairro.Text.Trim();
            fornecedor.Cep = Utilitario.ApenasNumeros(txtCep.Text);
            fornecedor.Observacoes = txtObservacoes.Text.Trim();
            fornecedor.DataCriacao = DateTime.Now;
            return fornecedor;
        }

        private void AbrirFrmLocalizarCidadeDinamico()
        {
            // Desliga temporariamente o evento para evitar loop
            txtNomeCidade.TextChanged -= txtNomeCidade_TextChanged;

            using (FrmLocalizarCidade frmLocalizarCidade = new FrmLocalizarCidade(this, cidadeSelecionado))
            {
                frmLocalizarCidade.Owner = this;
                frmLocalizarCidade.ShowDialog();
                txtNomeCidade.Text = frmLocalizarCidade.cidadeSelecionado; // Define o nome do fornecedor retornado
            }

            // Religa o evento após modificar o texto
            txtNomeCidade.TextChanged += txtNomeCidade_TextChanged;
        }

        public void PreencherCampos(FornecedorModel fornecedor)
        {
            FornecedorID = (int)fornecedor.FornecedorID;
            txtFornecedorID.Text = Utilitario.ZerosEsquerda((int)fornecedor.FornecedorID, 6);
            txtNomeFornecedor.Text = fornecedor.Nome;

            txtTelefone.Text = fornecedor.Telefone;
            txtEmail.Text = fornecedor.Email;
            txtNomeCidade.Text = fornecedor.Nome ?? ""; // ← aqui tem um erro no seu código! deveria ser NomeCidade ou algo assim
            txtLogradouro.Text = fornecedor.Logradouro;
            txtNumero.Text = fornecedor.Numero;
            txtBairro.Text = fornecedor.Bairro;
            txtCep.Text = fornecedor.Cep;

            if (fornecedor.DataCriacao.HasValue)
                dtpDataCriacao.Text = fornecedor.DataCriacao.Value.ToString("dd/MM/yyyy");

            txtIE.Text = fornecedor.IE;
            txtObservacoes.Text = fornecedor.Observacoes;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
                SalvarRegistro();
            else if (StatusOperacao == "ALTERAR")
                AlterarRegistro();
            else if (StatusOperacao == "EXCLUSAO")
                ExcluirRegistro(); btnSalvar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            GerarNovoCodigo();
            txtNomeFornecedor.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            AbrirFrmLocalizarCidadeDinamico();
        }

        private void btnSair_Click(object sender, EventArgs e) => this.Close();

        private void LimparCampos() => Utilitario.LimparCampos(this);

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.AplicarMascaraCEP(e, txtCep);
        }

        private void txtIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.MascaraIE(e, txtIE);
        }

        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private async Task txtCep_LeaveAsync(object sender, EventArgs e)
        {
            Utilitario.ValidarEFormatarCEPnoTextbox(txtCep);
            // Validação e formatação
            // Validação e formatação (aceita vazio)
            bool valido = Utilitario.ValidarEFormatarCEPnoTextbox(txtCep);
            if (!valido) return;

            string apenasNum = Utilitario.ApenasNumeros(txtCep.Text);
            if (string.IsNullOrWhiteSpace(apenasNum)) return;

            try
            {
                // Opcional: desabilitar o campo enquanto consulta para evitar race conditions
                txtCep.Enabled = false;

                var result = await Utilitario.BuscarCepAsync(apenasNum);

                if (result == null)
                {
                    txtCep.StateCommon.Border.Color1 = Color.Crimson;
                    MessageBox.Show("CEP não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Preenche os campos (ajuste nomes dos controles conforme seu form)
                txtLogradouro.Text = result.logradouro ?? string.Empty;
                txtBairro.Text = result.bairro ?? string.Empty;
                txtNomeCidade.Text = result.localidade ?? string.Empty; // ou txtCidade
                txtUF.Text = result.uf ?? string.Empty;

                txtCep.StateCommon.Border.Color1 = Color.MediumSeaGreen;
            }
            catch (Exception ex)
            {
                // Trate erro de rede/exceção de forma adequada
                txtCep.StateCommon.Border.Color1 = Color.Crimson;
                MessageBox.Show($"Erro ao consultar CEP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtCep.Enabled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.MascaraTelefone(sender, e);
        }

        private void FrmCadFornecedor_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmCadFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNomeCidade_TextChanged(object sender, EventArgs e)
        {
            if (bloqueiaPesquisa || string.IsNullOrWhiteSpace(txtNomeCidade.Text))
                return;

            // SALVA O TEXTO ATUAL ANTES DE PERDER O FOCO
            string textoDigitado = txtNomeCidade.Text;

            // VERIFICA SE O CONTROLE JÁ TEM UM HANDLE VÁLIDO
            if (!this.IsHandleCreated || txtNomeCidade.IsDisposed)
                return;

            // Usa BeginInvoke para "adiar" a abertura da pesquisa até o Windows terminar de processar a digitação
            this.BeginInvoke(new Action(() =>
            {
                if (bloqueiaPesquisa || txtNomeCidade.IsDisposed)
                    return;

                // pode ter sido bloqueado enquanto esperava
                bloqueiaPesquisa = true;
                try
                {
                    using (var pesquisaCidade = new FrmLocalizarCidade(this, textoDigitado))
                    {
                        pesquisaCidade.Owner = this;
                        if (pesquisaCidade.ShowDialog() == DialogResult.OK)
                        {
                            bloqueiaPesquisa = true;
                            txtNomeCidade.Text = pesquisaCidade.cidadeSelecionado;
                            CidadeID = pesquisaCidade.CidadeID;
                            txtNomeCidade.SelectionStart = txtNomeCidade.Text.Length;
                        }
                    }
                }
                finally
                {
                    bloqueiaPesquisa = false;
                }
            }));
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            string numero = Utilitario.ApenasNumeros(txtCnpj.Text);

            if (string.IsNullOrEmpty(numero))
            {
                txtCnpj.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
                return;
            }

            if (numero.Length != 14 || !Utilitario.ValidarCNPJ(numero))
            {
                MessageBox.Show("CNPJ inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCnpj.Focus();
                txtCnpj.StateCommon.Border.Color1 = System.Drawing.Color.Crimson;
                return;
            }

            txtCnpj.Text = Utilitario.FormatarCNPJ(numero);
            txtCnpj.StateCommon.Border.Color1 = System.Drawing.Color.MediumSeaGreen;
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.MascaraCNPJ(sender,e);
        }
    }
}