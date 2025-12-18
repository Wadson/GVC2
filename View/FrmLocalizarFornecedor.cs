using GVC.DALL;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmLocalizarFornecedor : KryptonForm
    {
        // Variável para controlar a linha atual
        private int linhaAtual = -1;
        public int FornecedorID { get; private set; }  // Adicione esta linha na classe
        public int numeroComZeros { get; set; }       
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        private Form _formChamador;
        private bool recebendoTextoExterno = false;
        public string FornecedorSelecionado { get; set; }

        public FrmLocalizarFornecedor(Form formChamador, string textoDigitado)
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
        private void ConfigurarDataGridView()
        {
            // Configurações do DataGridView
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPesquisar.MultiSelect = false;
            dataGridPesquisar.ReadOnly = true;
            dataGridPesquisar.RowHeadersVisible = false;
            dataGridPesquisar.AllowUserToAddRows = false;
            dataGridPesquisar.AllowUserToDeleteRows = false;
            dataGridPesquisar.AllowUserToResizeRows = false;

            // Eventos do DataGridView
            dataGridPesquisar.KeyDown += dataGridPesquisar_KeyDown;
            dataGridPesquisar.DoubleClick += dataGridPesquisar_DoubleClick;
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
                PesquisarFornecedor();
                SelecionarPrimeiroFornecedor();
            }
        }
        public new int ObterLinhaAtual()
        {
            return linhaAtual;
        }
        public void PersonalizarDataGridView()
        {
            // Função auxiliar para renomear somente se existir
            void Renomear(string coluna, string titulo)
            {
                if (dataGridPesquisar.Columns.Contains(coluna))
                    dataGridPesquisar.Columns[coluna].HeaderText = titulo;
            }

            // ✔ Ajustar cabeçalhos (somente colunas presentes no SELECT)
            Renomear("FornecedorID", "Cód.Fornecedor");
            Renomear("Nome", "Nome do Fornecedor");           
            Renomear("Cnpj", "Cnpj");
            Renomear("Telefone", "Telefone");
            Renomear("Email", "E-mail");           
            Renomear("Logradouro", "Logradouro");
            Renomear("Numero", "Número");
            Renomear("Bairro", "Bairro");
            Renomear("Cep", "CEP");            
            Renomear("CidadeID", "Cód. Cidade");
            Renomear("Nome", "Nome da Cidade");
            Renomear("Uf", "UF");           
            Renomear("NomeEstado", "Nome do Estado");

            // ✔ Modo somente leitura
            dataGridPesquisar.ReadOnly = true;

            // ✔ Ajuste automático de colunas
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
        }

        public void ListarFornecedor()
        {
            FornecedorDal dao = new();
            dataGridPesquisar.DataSource = dao.PesquisarGeral();

            PersonalizarDataGridView();
        }
        private void FrmLocalizarFornecedor_Load(object sender, EventArgs e)
        {
            ListarFornecedor();
            txtPesquisar.Focus();

            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }

        private void PesquisarFornecedor()
        {
            FornecedorDal dao = new FornecedorDal();

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

        private void FrmLocalizarFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {            
            isSelectingProduct = false;
        }

        private bool isSelectingProduct = false;
        private Form formChamador;
        private void SelecionarFornecedor()
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

                if (dataGridPesquisar["FornecedorID", linhaAtual]?.Value == null ||                   
                    dataGridPesquisar["Cnpj", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Telefone", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Nome", linhaAtual]?.Value == null)
                {
                    MessageBox.Show("Dados do fornecedor inválidos.");
                    return;
                }
                FornecedorID = Convert.ToInt32(dataGridPesquisar["FornecedorID", linhaAtual].Value);
                FornecedorSelecionado = dataGridPesquisar["Nome", linhaAtual].Value.ToString();               
                Cnpj = dataGridPesquisar["Cnpj", linhaAtual].Value.ToString();
                Telefone = dataGridPesquisar["Telefone", linhaAtual].Value.ToString();

                if (this.Owner is FrmCadProdutos frmCadProdutos)
                {
                    frmCadProdutos.txtFornecedorID.Text = FornecedorID.ToString();
                    frmCadProdutos.txtFornecedor.Text = FornecedorSelecionado;
                }               
                else
                {
                    MessageBox.Show("O formulário chamador não é reconhecido.");
                }

                this.DialogResult = DialogResult.OK; // Confirma que um fornecedor foi selecionado
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
                    // Enter no DataGridView: seleciona fornecedor
                    SelecionarFornecedor(); // Chama seu método existente
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
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarFornecedor();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            // SE TEM ALGUMA LINHA SELECIONADA → carrega os dados antes de sair
            if (dataGridPesquisar.CurrentRow != null && dataGridPesquisar.CurrentRow.Index >= 0)
            {
                linhaAtual = dataGridPesquisar.CurrentRow.Index;
                SelecionarFornecedor(); // ← agora carrega mesmo clicando em Sair
                return; // sai com DialogResult.OK
            }

            // Se não tem nada selecionado → só fecha (sem carregar nada)
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmLocalizarFornecedor_Shown(object sender, EventArgs e)
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
                        SelecionarFornecedor(); // Chama seu método existente
                    }
                    e.Handled = true;
                    break;

                case Keys.Escape:
                    this.Close();
                    e.Handled = true;
                    break;
            }
        }
        // Seleciona o primeiro fornecedor da lista
        private void SelecionarPrimeiroFornecedor()
        {
            if (dataGridPesquisar.Rows.Count > 0)
            {
                dataGridPesquisar.Rows[0].Selected = true;
                dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
            }
        }

        private void dataGridPesquisar_Enter(object sender, EventArgs e)
        {
            // Quando o DataGridView recebe foco, seleciona a primeira linha se nenhuma estiver selecionada
            if (dataGridPesquisar.Rows.Count > 0 && dataGridPesquisar.CurrentRow == null)
            {
                dataGridPesquisar.Rows[0].Selected = true;
                dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
            }
        }

        private void dataGridPesquisar_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                SelecionarFornecedor();
            }
        }

        private void FrmLocalizarFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    // Mesmo comportamento do botão Sair
                    if (dataGridPesquisar.CurrentRow != null && dataGridPesquisar.CurrentRow.Index >= 0)
                    {
                        linhaAtual = dataGridPesquisar.CurrentRow.Index;
                        SelecionarFornecedor();
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
    }
}