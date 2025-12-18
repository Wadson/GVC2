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
    public partial class FrmCadCliente : KryptonForm
    {
        public bool CarregandoDados { get; set; }

        private readonly ClienteBLL _clienteBll = new ClienteBLL();
        private readonly string QueryClientes = "SELECT MAX(ClienteID) FROM Cliente";
        public string StatusOperacao { get; set; }
        public string cidadeSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        private bool bloqueiaPesquisa = false;
        public int ClienteID { get; set; }
        public int CidadeID { get; set; }

        public FrmCadCliente()
        {
            InitializeComponent();
            cmbTipoCliente.Items.Clear();
            cmbTipoCliente.Items.AddRange(new[]
            {"Física", "Jurídica", "Operador", "Administrador", "Consumidor Final"});
        }
        // campo da classe

        public void DefinirModoEdicao(bool habilitar)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBoxBase || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is CheckBox)
                {
                    ctrl.Enabled = habilitar;
                }
            }
            txtClienteID.Enabled = false;// Sempre deixa o ID travado                       
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
                txtClienteID.Text = row.Cells["ClienteID"].Value?.ToString() ?? "";
                if (int.TryParse(txtClienteID.Text, out int id))
                    this.ClienteID = id;
                else
                    this.ClienteID = 0;

                txtNomeCliente.Text = row.Cells["Nome"].Value?.ToString() ?? "";

                // Documentos
                txtCpf.Text = row.Cells["Cpf"].Value?.ToString() ?? "";
                txtRg.Text = row.Cells["RG"].Value?.ToString() ?? "";
                txtOrgaoExpedidorRG.Text = row.Cells["OrgaoExpedidorRG"].Value?.ToString() ?? "";               

                // Contato
                txtTelefone.Text = row.Cells["Telefone"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

                // Endereço
                txtLogradouro.Text = row.Cells["Logradouro"].Value?.ToString() ?? "";
                txtNumero.Text = row.Cells["Numero"].Value?.ToString() ?? "";
                txtBairro.Text = row.Cells["Bairro"].Value?.ToString() ?? "";
                txtCep.Text = row.Cells["Cep"].Value?.ToString() ?? "";
                this.CidadeID = int.TryParse(row.Cells["CidadeID"].Value?.ToString(), out int cid) ? cid : 0;
                txtNomeCidade.Text = row.Cells["NomeCidade"].Value?.ToString() ?? "";
                txtUF.Text = row.Cells["Estado"].Value?.ToString() ?? "";

                // Cliente
                string tipoCliente = row.Cells["TipoCliente"].Value?.ToString() ?? "";
                if (!string.IsNullOrWhiteSpace(tipoCliente))
                    cmbTipoCliente.SelectedItem = tipoCliente;


                // Recupera o valor literal do BD (0 ou 1)
                string statusValue = row.Cells["Status"].Value?.ToString() ?? "";

                string statusText = "";

                if (statusValue == "1")
                {
                    statusText = "Ativo";
                }
                else if (statusValue == "0")
                {
                    statusText = "Inativo";
                }
                // Note: Se o valor for null/vazio, statusText permanece vazio.

                // Tenta selecionar o texto correspondente no ComboBox
                if (!string.IsNullOrWhiteSpace(statusText))
                {
                    // Use SelectedItem para selecionar o item cujo texto é "Ativo" ou "Inativo"
                    cmbStatus.SelectedItem = statusText;
                }




                txtObservacoes.Text = row.Cells["Observacoes"].Value?.ToString() ?? "";

                // Datas
                ToolStripLabelDataUtimaCompra.Text = row.Cells["DataUltimaCompra"].Value?.ToString() ?? "";
                ToolStripLabelDataCriacao.Text = row.Cells["DataCriacao"].Value?.ToString() ?? "";
                toolStripStatusLabelDataAtualizacao.Text = row.Cells["DataAtualizacao"].Value?.ToString() ?? "";
                toolStripStatusLabelUsuarioCriacao.Text = row.Cells["UsuarioCriacao"].Value?.ToString() ?? "";
                toolStripStatusLabelUsuarioAtualizacao.Text = row.Cells["UsuarioAtualizacao"].Value?.ToString() ?? "";

                // CPF — formatação
                string cpf = row.Cells["Cpf"].Value?.ToString() ?? "";
                cpf = new string(cpf.Where(char.IsDigit).ToArray());
                if (!string.IsNullOrWhiteSpace(cpf))
                {
                    if (cpf.Length == 11)
                        txtCpf.Text = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
                    else
                        txtCpf.Text = cpf;
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

                // Limite de crédito — formatação
                decimal limite = 0;
                decimal.TryParse(row.Cells["LimiteCredito"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out limite);
                txtLimiteCredito.Text = limite.ToString("#,##0.00");

                // Data de nascimento
                if (DateTime.TryParse(row.Cells["DataNascimento"].Value?.ToString(), out DateTime dtN))
                    dtpDataNascimento.Value = dtN;
                else
                    dtpDataNascimento.Value = DateTime.Now;
            }
            finally
            {
                CarregandoDados = false;
            }
        }

        // Colocar dentro do FrmCadCliente
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
        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            {
                if (CarregandoDados)
                {
                    // apenas garante máscara/Tag sem limpar o campo
                    bool isCpf = cmbTipoCliente.Text == "Física" ||
                                 cmbTipoCliente.Text == "Operador" ||
                                 cmbTipoCliente.Text == "Administrador" ||
                                 cmbTipoCliente.Text == "Consumidor Final";

                    // CPF sempre usa máscara de CPF
                    txtCpf.Tag = "CPF";
                    //txtCpf.KeyPress -= Utilitario.MascaraCPF;
                    //txtCpf.KeyPress += Utilitario.MascaraCPF;

                    return;
                }

                // ================================
                // 👍 SE MODO NOVO → Gerar código
                // ================================
                if (StatusOperacao == "NOVO")
                {
                    
                    GerarNovoCodigo();   // <-- AQUI FUNCIONA!

                    var frmManutCliente = Application.OpenForms["FrmManutCliente"] as FrmManutCliente;
                    frmManutCliente?.HabilitarTimer(true);

                    toolStripStatusLabelUsuarioCriacao.Text = FrmLogin.UsuarioConectado;
                    ToolStripLabelDataCriacao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    // Como é novo, não existe atualização ainda:
                    toolStripStatusLabelUsuarioAtualizacao.Text = "-";
                    ToolStripLabelDataUtimaCompra.Text = "-";

                    cmbTipoCliente.SelectedValue = 1;
                    // Fallback caso ainda não esteja selecionado (ex.: DataSource não preparado)
                    if (cmbStatus.SelectedValue == null || !cmbStatus.SelectedValue.Equals(1))
                        cmbStatus.SelectedIndex = 0; // índice do item "Ativo" na sua lista

                    
                    // Fallback caso ainda não esteja selecionado (ex.: DataSource não preparado)
                    if (cmbTipoCliente.SelectedValue == null || !cmbTipoCliente.SelectedValue.Equals(1))
                        cmbTipoCliente.SelectedIndex = 0; // índice do item "Ativo" na sua lista

                }

                // Ajusta rótulo e máscara normalmente
                bool isCpf2 = cmbTipoCliente.Text == "Física" ||
                              cmbTipoCliente.Text == "Operador" ||
                              cmbTipoCliente.Text == "Administrador" ||
                              cmbTipoCliente.Text == "Consumidor Final";   

                CarregandoDados = false;
            }
        }

        private void GerarNovoCodigo()
        {
            int novoId = Utilitario.ProximoId(QueryClientes);
            ClienteID = novoId;
            txtClienteID.Text = Utilitario.ZerosEsquerda(novoId, 6);
        }

        public void SalvarRegistro()
        {
            try
            {
                var cliente = MontarObjetoCliente();
                _clienteBll.Salvar(cliente);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                var frmManutCliente = Application.OpenForms["FrmManutCliente"] as FrmManutCliente;
                if (frmManutCliente != null)
                {
                    frmManutCliente.HabilitarTimer(true);
                }
                LimparCampos();
                GerarNovoCodigo();
                txtNomeCliente.Focus();
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
                var cliente = MontarObjetoCliente();
                cliente.UsuarioAtualizacao = FrmLogin.UsuarioConectado;
                cliente.DataAtualizacao = DateTime.Now;

                _clienteBll.Alterar(cliente);

                MessageBox.Show("Cliente alterado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                toolStripStatusLabelUsuarioAtualizacao.Text = FrmLogin.UsuarioConectado;
                ToolStripLabelDataUtimaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                this.Close();

                var frmManutCliente = Application.OpenForms["FrmManutCliente"] as FrmManutCliente;
                if (frmManutCliente != null)
                {
                    frmManutCliente.HabilitarTimer(true);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Outro cliente já está cadastrado"))
                    MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ExcluirRegistro()
        {
            if (MessageBox.Show($"Deseja realmente excluir o cliente:\n\n{txtNomeCliente.Text}?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _clienteBll.Excluir(ClienteID);
                    MessageBox.Show("Cliente excluído com sucesso!", "Excluído",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    var frmManutCliente = Application.OpenForms["FrmManutCliente"] as FrmManutCliente;
                    if (frmManutCliente != null)
                    {
                        frmManutCliente.HabilitarTimer(true);
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

        private ClienteMODEL MontarObjetoCliente()
        {
            var cliente = new ClienteMODEL();

            cliente.Nome = txtNomeCliente.Text.Trim();
            cliente.Cpf = Utilitario.ApenasNumeros(txtCpf.Text);           
            cliente.RG = txtRg.Text.Trim();                     
            cliente.OrgaoExpedidorRG = txtOrgaoExpedidorRG.Text.Trim();
            cliente.Telefone = Utilitario.ApenasNumeros(txtTelefone.Text);
            cliente.Email = txtEmail.Text.Trim();
            if (int.TryParse(txtClienteID.Text, out int id)) cliente.ClienteID = id;
            cliente.CidadeID = CidadeID;
            cliente.Logradouro = txtLogradouro.Text.Trim();
            cliente.Numero = txtNumero.Text.Trim();
            cliente.Bairro = txtBairro.Text.Trim();
            cliente.Cep = Utilitario.ApenasNumeros(txtCep.Text);
            cliente.DataNascimento = dtpDataNascimento.Checked ? dtpDataNascimento.Value.Date : null;
            cliente.TipoCliente = cmbTipoCliente.Text;
            cliente.Status = cmbStatus.Text == "Ativo" ? 1 : 0;
            cliente.Observacoes = txtObservacoes.Text.Trim();
            if (decimal.TryParse(txtLimiteCredito.Text, out decimal limite))
            cliente.LimiteCredito = limite;
            cliente.DataCriacao = DateTime.Now;
            cliente.UsuarioCriacao = FrmLogin.UsuarioConectado;
            return cliente;
        }

        private void AbrirFrmLocalizarCidadeDinamico()
        {
            // Desliga temporariamente o evento para evitar loop
            txtNomeCidade.TextChanged -= txtNomeCidade_TextChanged;

            using (FrmLocalizarCidade frmLocalizarCidade = new FrmLocalizarCidade(this, cidadeSelecionado))
            {
                frmLocalizarCidade.Owner = this;
                frmLocalizarCidade.ShowDialog();
                txtNomeCidade.Text = frmLocalizarCidade.cidadeSelecionado; // Define o nome do cliente retornado
            }

            // Religa o evento após modificar o texto
            txtNomeCidade.TextChanged += txtNomeCidade_TextChanged;
        }

        public void PreencherCampos(ClienteMODEL cliente)
        {
            ClienteID = cliente.ClienteID;
            txtClienteID.Text = Utilitario.ZerosEsquerda(cliente.ClienteID, 6);
            txtNomeCliente.Text = cliente.Nome;

            // Detectar se é CPF ou CNPJ pelo tamanho
            string doc = cliente.Cpf?.Trim();
            if (!string.IsNullOrEmpty(doc))
            {
                if (doc.Length == 11)
                {
                    cmbTipoCliente.Text = "Física";
                    txtCpf.Text = Utilitario.FormatarCPF(doc);
                }
                else if (doc.Length == 14)
                {
                    cmbTipoCliente.Text = "Jurídica";
                    txtCpf.Text = Utilitario.FormatarCNPJ(doc);
                }
                else
                {
                    txtCpf.Text = doc; // fallback
                }
            }

            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;
            txtNomeCidade.Text = cliente.Nome ?? ""; // ← aqui tem um erro no seu código! deveria ser NomeCidade ou algo assim
            txtLogradouro.Text = cliente.Logradouro;
            txtNumero.Text = cliente.Numero;
            txtBairro.Text = cliente.Bairro;
            txtCep.Text = cliente.Cep;

            if (cliente.DataNascimento.HasValue)
                txtDataNascimento.Text = cliente.DataNascimento.Value.ToString("dd/MM/yyyy");

            txtRg.Text = cliente.RG;           
            cmbTipoCliente.Text = cliente.TipoCliente ?? "Física";
            cmbStatus.Text = cliente.Status == 1 ? "Ativo" : "Inativo";

            txtObservacoes.Text = cliente.Observacoes;

            var culture = CultureInfo.GetCultureInfo("pt-BR");

            txtLimiteCredito.Text = cliente.LimiteCredito.HasValue && cliente.LimiteCredito.Value > 0 ? cliente.LimiteCredito.Value.ToString("C", culture): "";            

            // Auditoria
            if (cliente.DataCriacao > DateTime.MinValue)
                ToolStripLabelDataCriacao.Text = $"Criado em: {cliente.DataCriacao:dd/MM/yyyy HH:mm}";
            if (!string.IsNullOrEmpty(cliente.UsuarioCriacao))
                toolStripStatusLabelUsuarioCriacao.Text = $"Por: {cliente.UsuarioCriacao}";

            toolStripStatusLabelUsuarioCriacao.Text = cliente.UsuarioCriacao;
            ToolStripLabelDataCriacao.Text = cliente.DataCriacao.ToString("dd/MM/yyyy HH:mm:ss");

            toolStripStatusLabelUsuarioAtualizacao.Text = cliente.UsuarioAtualizacao;
            ToolStripLabelDataUtimaCompra.Text = cliente.DataUltimaCompra?.ToString("dd/MM/yyyy") ?? "-";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
                SalvarRegistro();
            else if (StatusOperacao == "ALTERAR")
                AlterarRegistro();
            else if (StatusOperacao == "EXCLUSAO")
                ExcluirRegistro();btnSalvar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            GerarNovoCodigo();
            txtNomeCliente.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            AbrirFrmLocalizarCidadeDinamico();
        }

        private void btnSair_Click(object sender, EventArgs e) => this.Close();

        private void LimparCampos() => Utilitario.LimparCampos(this);


        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarregandoDados) return; // impede apagar o campo durante carregamento

            // Define se o cliente é pessoa física (usa CPF) ou jurídica (usa CNPJ)
            bool isCpf = cmbTipoCliente.Text == "Física" ||
                         cmbTipoCliente.Text == "Operador" ||
                         cmbTipoCliente.Text == "Administrador" ||
                         cmbTipoCliente.Text == "Consumidor Final";
           
            // Remove máscaras antigas
            txtCpf.KeyPress -= Utilitario.MascaraCPF;           

            // Aplica máscara correta
            if (isCpf)
            {
                txtCpf.KeyPress += Utilitario.MascaraCPF;
   
                txtCpf.Visible = true;
                lblCpf.Visible = true;
                txtRg.Visible = true;
                lblRG.Visible = true;
                txtOrgaoExpedidorRG.Visible = true;
                lblOrgaoExpedidorRG.Visible = true;
            }
            else
            {
                // Pessoa Jurídica → mostra CNPJ e IE               
                txtCpf.Visible = false;
                lblCpf.Visible = false;
                txtOrgaoExpedidorRG.Visible = false;
                lblRotuloDtNascDtCriacao.Text = "Data Criação:";
                lblOrgaoExpedidorRG.Visible = false;
                lblRG.Visible = false;
                txtRg.Visible = false;
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.AplicarMascaraCEP(e, txtCep);
        }
        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtLimiteCredito_TextChanged(object sender, EventArgs e)
        {
            KryptonTextBox txt = (KryptonTextBox)sender;

            // Captura posição do cursor
            int pos = txt.SelectionStart;

            // Remove tudo que não é número
            string apenasNumeros = Utilitario.ApenasNumeros(txt.Text);

            if (string.IsNullOrEmpty(apenasNumeros))
            {
                txt.Text = "0,00";
                txt.SelectionStart = txt.Text.Length;
                return;
            }

            // Garante que sempre tenha pelo menos 3 dígitos (0,00)
            if (apenasNumeros.Length < 3)
                apenasNumeros = apenasNumeros.PadLeft(3, '0');

            // Converte para decimal formatado
            decimal valor = decimal.Parse(apenasNumeros) / 100m;

            txt.Text = valor.ToString("#,##0.00");

            // Reposiciona o cursor sempre no final
            txt.SelectionStart = txt.Text.Length;
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

        private void btnListarControles_Click(object sender, EventArgs e)
        {
        }

        private void txtCpfCnpjJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpfCnpjJ_Leave(object sender, EventArgs e)
        {
            // Preferência: leia o modo do Tag (mais confiável)
            string modo = (txtCpf.Tag as string) ?? cmbTipoCliente.Text;
            bool isCpf = modo.Equals("CPF", StringComparison.OrdinalIgnoreCase)
                         || modo.Equals("Física", StringComparison.OrdinalIgnoreCase);

            string numero = Utilitario.ApenasNumeros(txtCpf.Text);

            if (string.IsNullOrEmpty(numero))
            {
                txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
                return;
            }

            if (isCpf)
            {
                if (numero.Length != 11 || !Utilitario.ValidarCPF(numero))
                {
                    MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCpf.Focus();
                    txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.Crimson;
                    return;
                }

                txtCpf.Text = Utilitario.FormatarCPF(numero);
            }
            else // CNPJ
            {
                if (numero.Length != 14 || !Utilitario.ValidarCNPJ(numero))
                {
                    MessageBox.Show("CNPJ inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCpf.Focus();
                    txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.Crimson;
                    return;
                }

                txtCpf.Text = Utilitario.FormatarCNPJ(numero);
            }

            txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.MediumSeaGreen;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.MascaraTelefone(sender, e);
        }

        private void FrmCadCliente_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmCadCliente_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            string numero = Utilitario.ApenasNumeros(txtCpf.Text);

            if (string.IsNullOrEmpty(numero))
            {
                txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
                return;
            }

            if (numero.Length != 11 || !Utilitario.ValidarCPF(numero))
            {
                MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.Crimson;
                return;
            }

            txtCpf.Text = Utilitario.FormatarCPF(numero);
            txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.MediumSeaGreen;
        }
    }
}