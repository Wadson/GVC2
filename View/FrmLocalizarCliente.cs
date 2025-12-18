using GVC.DALL;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmLocalizarCliente : KryptonForm
    {
        // Variável para controlar a linha atual
        private int linhaAtual = -1;
        public int ClienteID { get; private set; }  // Adicione esta linha na classe
        public int numeroComZeros { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }

        private Form _formChamador;
        private bool recebendoTextoExterno = false;
        public string ClienteSelecionado { get; set; }

        public FrmLocalizarCliente(Form formChamador, string textoDigitado)
        {
            InitializeComponent();
            ConfigurarEventosTeclado();
            _formChamador = formChamador;

            // Configura DataGridView
            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            this.dataGridPesquisar.KeyDown += dataGridPesquisar_KeyDown;
            this.txtPesquisar.KeyDown += txtPesquisar_KeyDown; // Corrigido: txtPesquisar_KeyDown
            this.dataGridPesquisar.Enter += dataGridPesquisar_Enter;
            this.KeyPreview = true;
            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            this.dataGridPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridPesquisar_KeyDown);

            // Define o texto inicial passado pelo form chamador
            if (!string.IsNullOrEmpty(textoDigitado))
            {
                DefinirTextoPesquisa(textoDigitado);
            }
        }

        // Adicione este método para seleção rápida quando houver apenas um resultado
        private void VerificarSelecaoAutomatica()
        {
            // Se houver apenas um resultado na pesquisa, seleciona automaticamente
            if (dataGridPesquisar.Rows.Count == 1)
            {
                // Opção 2: Apenas seleciona a linha mas não confirma (deixa usuário decidir)
                dataGridPesquisar.Rows[0].Selected = true;
                dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                dataGridPesquisar.Focus();
            }
        }
        private void ConfigurarEventosTeclado()
        {
            // Configura KeyPreview no formulário
            this.KeyPreview = true;

            // Evento de teclado no formulário (opcional, para atalhos globais)
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F2)
                {
                    txtPesquisar.Focus();
                    e.Handled = true;
                }
            };
        }
        // Método para definir o texto da pesquisa vindo do formulário chamador
        public void DefinirTextoPesquisa(string texto)
        {
            recebendoTextoExterno = true;
            txtPesquisar.Text = texto;
            txtPesquisar.SelectionStart = texto.Length; // cursor no final
            recebendoTextoExterno = false;

            if (!string.IsNullOrEmpty(texto))
            {
                PesquisarCliente();
                SelecionarPrimeiroCliente();
            }
        }
        public new int ObterLinhaAtual()
        {
            return linhaAtual;
        }
        public void ConfigurarDataGridView()
        {
            // Função auxiliar para renomear somente se existir
            void Renomear(string coluna, string titulo)
            {
                if (dataGridPesquisar.Columns.Contains(coluna))
                    dataGridPesquisar.Columns[coluna].HeaderText = titulo;
            }

            // ✔ Ajustar cabeçalhos
            Renomear("ClienteID", "Cód. Cliente");
            Renomear("Nome", "Nome do Cliente");
            Renomear("Cpf", "CPF");
            Renomear("Cnpj", "CNPJ");
            Renomear("Telefone", "Telefone");
            Renomear("Email", "E-mail");
            Renomear("Logradouro", "Logradouro");
            Renomear("Numero", "Número");
            Renomear("Bairro", "Bairro");
            Renomear("Cep", "CEP");
            Renomear("CidadeID", "Cód. Cidade");
            Renomear("Uf", "UF");
            Renomear("NomeEstado", "Nome do Estado");

            // ✔ Lista de colunas a ocultar
            string[] colunasOcultas = {
        "ClienteID", "Email", "DataCriacao", "DataAtualizacao",
        "UsuarioCriacao", "UsuarioAtualizacao", "CidadeID",
        "Status", "TipoCliente", "DataUltimaCompra"
    };

            // ✔ Se a célula atual estiver em uma dessas colunas, limpa antes
            if (dataGridPesquisar.CurrentCell != null &&
                colunasOcultas.Contains(dataGridPesquisar.CurrentCell.OwningColumn.Name))
            {
                dataGridPesquisar.CurrentCell = null;
            }

            // ✔ Ocultar colunas
            foreach (var coluna in colunasOcultas)
            {
                if (dataGridPesquisar.Columns.Contains(coluna))
                    dataGridPesquisar.Columns[coluna].Visible = false;
            }

            // ✔ Definir largura fixa para coluna Nome
            if (dataGridPesquisar.Columns.Contains("Nome"))
            {
                dataGridPesquisar.Columns["Nome"].Width = 400;
                dataGridPesquisar.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            // ✔ Configurações gerais
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPesquisar.MultiSelect = false;
            dataGridPesquisar.ReadOnly = true;
            dataGridPesquisar.RowHeadersVisible = false;
            dataGridPesquisar.AllowUserToAddRows = false;
            dataGridPesquisar.AllowUserToDeleteRows = false;
            dataGridPesquisar.AllowUserToResizeRows = false;

            // ✔ Ajuste automático das demais colunas
            dataGridPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // ✔ Fundo amarelo claro
            dataGridPesquisar.DefaultCellStyle.BackColor = Color.LightYellow;

            // ✔ Cabeçalhos mais elegantes
            dataGridPesquisar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPesquisar.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            // ✔ Largura do cabeçalho da linha
            dataGridPesquisar.RowHeadersWidth = 10;

            // ✔ Centralizar cabeçalhos e definir largura mínima
            foreach (DataGridViewColumn column in dataGridPesquisar.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.MinimumWidth = 90;
            }

            // ✔ Eventos
            dataGridPesquisar.KeyDown += dataGridPesquisar_KeyDown;
            dataGridPesquisar.DoubleClick += dataGridPesquisar_DoubleClick;
            dataGridPesquisar.DataBindingComplete += dataGridPesquisar_DataBindingComplete;
            dataGridPesquisar.Enter += dataGridPesquisar_Enter;
        }

        // Função auxiliar para selecionar a primeira linha em coluna visível
        private void SelecionarPrimeiraLinhaSegura()
        {
            if (dataGridPesquisar.Rows.Count == 0 || dataGridPesquisar.Columns.Count == 0)
                return;

            // Encontra o primeiro índice de coluna VISÍVEL
            int firstVisibleColIndex = -1;
            foreach (DataGridViewColumn col in dataGridPesquisar.Columns)
            {
                if (col.Visible)
                {
                    firstVisibleColIndex = col.Index;
                    break;
                }
            }

            if (firstVisibleColIndex == -1)
                return; // não há nenhuma coluna visível

            var firstRow = dataGridPesquisar.Rows[0];

            // Evita conflito com célula atual em coluna invisível
            if (dataGridPesquisar.CurrentCell != null &&
                !dataGridPesquisar.CurrentCell.OwningColumn.Visible)
            {
                dataGridPesquisar.CurrentCell = null;
            }

            firstRow.Selected = true;
            dataGridPesquisar.CurrentCell = firstRow.Cells[firstVisibleColIndex];
        }
        public void ListarCliente()
        {
            ClienteDal dao = new();
            dataGridPesquisar.DataSource = dao.PesquisarGeral();
            ConfigurarDataGridView();
        }
        private void FrmLocalizarCliente_Load(object sender, EventArgs e)
        {
            ListarCliente();
            txtPesquisar.Focus();

            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }

        private void PesquisarCliente()
        {
            ClienteDal dao = new ClienteDal();

            if (rbtCodigo.Checked)
            {
                if (int.TryParse(txtPesquisar.Text, out int id))
                {
                    dataGridPesquisar.DataSource = dao.PesquisarPorCodigo(id);
                }
                else
                {
                    dataGridPesquisar.DataSource = null;
                }
            }
            else
            {
                string nome = "%" + txtPesquisar.Text + "%";
                dataGridPesquisar.DataSource = dao.PesquisarPorNome(nome);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLocalizarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            isSelectingProduct = false;
        }

        private bool isSelectingProduct = false;
        private Form formChamador;
        private void SelecionarCliente()
        {
            if (isSelectingProduct) return;
            isSelectingProduct = true;

            try
            {
                // Obtém a linha atual selecionada na grid
                linhaAtual = ObterLinhaAtual();
                if (linhaAtual < 0 || linhaAtual >= dataGridPesquisar.Rows.Count)
                {
                    MessageBox.Show("Linha inválida.");
                    return;
                }

                if (dataGridPesquisar["ClienteID", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Cpf", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Cnpj", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Telefone", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Logradouro", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Numero", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Bairro", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Nome", linhaAtual]?.Value == null)

                {
                    MessageBox.Show("Dados do cliente inválidos.");
                    return;
                }
                ClienteID = Convert.ToInt32(dataGridPesquisar["ClienteID", linhaAtual].Value);
                ClienteSelecionado = dataGridPesquisar["Nome", linhaAtual].Value.ToString();
                Cpf = dataGridPesquisar["Cpf", linhaAtual].Value.ToString();
                Cnpj = dataGridPesquisar["Cnpj", linhaAtual].Value.ToString();
                Telefone = dataGridPesquisar["Telefone", linhaAtual].Value.ToString();
                Logradouro = dataGridPesquisar["Logradouro", linhaAtual].Value.ToString();
                Numero = dataGridPesquisar["Numero", linhaAtual].Value.ToString();
                Bairro = dataGridPesquisar["Bairro", linhaAtual].Value.ToString();
                Cidade = dataGridPesquisar["NomeCidade", linhaAtual].Value.ToString();
                // Cep = Convert.ToInt32(dataGridPesquisar["Cep", linhaAtual].Value);
                var cepValue = dataGridPesquisar["Cep", linhaAtual].Value;
                if (cepValue != null && cepValue != DBNull.Value && int.TryParse(cepValue.ToString(), out int cep))
                    Cep = cep;
                else
                    Cep = 0; // ou string.Empty se preferir tratar como texto



                if (this.Owner is FrmContasAReceber frmContaReceberr)
                {
                    frmContaReceberr.ClienteID = ClienteID;
                    frmContaReceberr.txtNomeCliente.Text = ClienteSelecionado;
                }
                else if (this.Owner is FrmRelatorios frmRelatorios)
                {
                    frmRelatorios.txtClienteID.Text = ClienteID.ToString();
                    frmRelatorios.txtNomeCliente.Text = ClienteSelecionado;
                }
                else if (this.Owner is FrmVendas frmVendas)
                {
                    frmVendas.ClienteID = ClienteID;

                    frmVendas.txtNomeCliente.Text = ClienteSelecionado;
                    frmVendas.txtCpf.Text = Utilitario.FormatarCPF(Cpf);
                }
                else
                {
                    MessageBox.Show("O formulário chamador não é reconhecido.");
                }

                this.DialogResult = DialogResult.OK; // Confirma que um cliente foi selecionado
                this.Close();
            }
            finally
            {
                isSelectingProduct = false;
            }
        }
        private void dataGridPesquisar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                linhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dataGridPesquisar.Focus();
                if (dataGridPesquisar.Rows.Count > 0)
                {
                    dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                }
            }
        }

        private void dataGridPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // Enter no DataGridView: seleciona cliente
                    SelecionarCliente(); // Chama seu método existente
                    e.Handled = true;
                    break;

                case Keys.Up:
                    // Tecla para cima na primeira linha: volta para o txtPesquisa
                    if (dataGridPesquisar.CurrentRow != null &&
                        dataGridPesquisar.CurrentRow.Index == 0)
                    {
                        txtPesquisar.Focus();
                        e.Handled = true;
                    }
                    break;

                case Keys.Down:
                    // Tecla para baixo na última linha: não faz nada especial
                    // O próprio DataGridView já trata a navegação
                    e.Handled = false; // Permite o comportamento padrão
                    break;

                case Keys.Escape:
                    this.Close();
                    e.Handled = true;
                    break;
            }
        }
        private void AtualizarFormularioChamador()
        {
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarCliente();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            // SE TEM ALGUMA LINHA SELECIONADA → carrega os dados antes de sair
            if (dataGridPesquisar.CurrentRow != null && dataGridPesquisar.CurrentRow.Index >= 0)
            {
                linhaAtual = dataGridPesquisar.CurrentRow.Index;
                SelecionarCliente(); // ← agora carrega mesmo clicando em Sair
                return; // sai com DialogResult.OK
            }

            // Se não tem nada selecionado → só fecha (sem carregar nada)
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmLocalizarCliente_Shown(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
            // Em vez disso, posicione o cursor no final
            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    // Tecla para baixo: move foco para o DataGridView
                    if (dataGridPesquisar.Rows.Count > 0)
                    {
                        dataGridPesquisar.Focus();

                        // Seleciona a primeira linha se nenhuma estiver selecionada
                        if (dataGridPesquisar.CurrentRow == null && dataGridPesquisar.Rows.Count > 0)
                        {
                            dataGridPesquisar.Rows[0].Selected = true;
                            dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                        }
                    }
                    e.Handled = true;
                    break;

                case Keys.Enter:
                    // Enter no campo de pesquisa: seleciona primeiro resultado
                    if (dataGridPesquisar.Rows.Count > 0)
                    {
                        dataGridPesquisar.Focus();
                        dataGridPesquisar.Rows[0].Selected = true;
                        dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                        SelecionarCliente(); // Chama seu método existente
                    }
                    e.Handled = true;
                    break;

                case Keys.Escape:
                    this.Close();
                    e.Handled = true;
                    break;
            }
        }
        // Seleciona o primeiro cliente da lista
        private void SelecionarPrimeiroCliente()
        {
            if (dataGridPesquisar.Rows.Count > 0)
            {
                dataGridPesquisar.Rows[0].Selected = true;
                dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
            }
        }

        private void dataGridPesquisar_Enter(object sender, EventArgs e)
        {
            if (dataGridPesquisar.Rows.Count > 0 && dataGridPesquisar.CurrentRow == null)
            {
                SelecionarPrimeiraLinhaSegura();
            }
            //// Quando o DataGridView recebe foco, seleciona a primeira linha se nenhuma estiver selecionada
            //if (dataGridPesquisar.Rows.Count > 0 && dataGridPesquisar.CurrentRow == null)
            //{
            //    dataGridPesquisar.Rows[0].Selected = true;
            //    dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
            //}
        }

        private void dataGridPesquisar_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                SelecionarCliente();
            }
        }

        private void FrmLocalizarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    // Mesmo comportamento do botão Sair
                    if (dataGridPesquisar.CurrentRow != null && dataGridPesquisar.CurrentRow.Index >= 0)
                    {
                        linhaAtual = dataGridPesquisar.CurrentRow.Index;
                        SelecionarCliente();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                    e.Handled = true;
                    break;

                    // Adicione outras teclas aqui, se precisar
                    // case Keys.Enter:
                    //     ...
                    //     break;
            }

        }

        private void dataGridPesquisar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SelecionarPrimeiraLinhaSegura();
        }
    }
}