using Krypton.Toolkit;
using GVC.BLL;
using GVC.DALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GVC.DAL;

namespace GVC.View
{
    public partial class FrmLocalizarProduto : KryptonForm
    {
        private string _ClienteID;
        protected int LinhaAtual = -1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProdutoID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeProduto { get; set; }

        public decimal PrecoUnitario { get; set; }
        private String referencia;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ProdutoSelecionado { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Form FormChamador { get; set; }

        public FrmLocalizarProduto(Form formChamador, string textoDigitado)
        {
            InitializeComponent();
            // Verifica se o formulário chamador é válido
            if (formChamador != null)
            {
                this.FormChamador = formChamador;
            }
            this.Owner = formChamador;

            txtPesquisar.Text = textoDigitado; // Define a letra pressionada no campo de pesquisa

            txtPesquisar.SelectionStart = txtPesquisar.Text.Length; // Coloca o cursor no final
            txtPesquisar.Focus(); // Foca o campo para continuar digitando

            //Configurar o TextBox para capturar o evento KeyDown

            this.txtPesquisar.KeyDown += new KeyEventHandler(dataGridPesquisar_KeyDown);
            this.dataGridPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridPesquisar_KeyDown);

            // Configurar o DataGridView (apenas exemplo, configure conforme necessário)
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void PersonalizarDataGridView()
        {
            // 1. Desliga o auto‑resize global
            dataGridPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 2. Cabeçalhos bonitos
            if (dataGridPesquisar.Columns["ProdutoID"] != null) dataGridPesquisar.Columns["ProdutoID"].HeaderText = "Código";
            if (dataGridPesquisar.Columns["NomeProduto"] != null) dataGridPesquisar.Columns["NomeProduto"].HeaderText = "Produto";
            if (dataGridPesquisar.Columns["Referencia"] != null) dataGridPesquisar.Columns["Referencia"].HeaderText = "Referência";
            if (dataGridPesquisar.Columns["PrecoCusto"] != null) dataGridPesquisar.Columns["PrecoCusto"].HeaderText = "Preço Custo";
            if (dataGridPesquisar.Columns["Lucro"] != null) dataGridPesquisar.Columns["Lucro"].HeaderText = "Lucro";
            if (dataGridPesquisar.Columns["PrecoDeVenda"] != null) dataGridPesquisar.Columns["PrecoDeVenda"].HeaderText = "Preço Venda";
            if (dataGridPesquisar.Columns["Estoque"] != null) dataGridPesquisar.Columns["Estoque"].HeaderText = "Estoque";
            if (dataGridPesquisar.Columns["DataDeEntrada"] != null) dataGridPesquisar.Columns["DataDeEntrada"].HeaderText = "Entrada";
            if (dataGridPesquisar.Columns["DataValidade"] != null) dataGridPesquisar.Columns["DataValidade"].HeaderText = "Validade";
            if (dataGridPesquisar.Columns["NomeFornecedor"] != null) dataGridPesquisar.Columns["NomeFornecedor"].HeaderText = "Fornecedor";
            if (dataGridPesquisar.Columns["FornecedorID"] != null) dataGridPesquisar.Columns["FornecedorID"].HeaderText = "FornecedorID";
            if (dataGridPesquisar.Columns["Marca"] != null) dataGridPesquisar.Columns["Marca"].HeaderText = "Marca";

            // 3. Colunas fixas (largura definida e não mudam)
            var colunasFixas = new (string nome, int largura)[]
            {
        ("ProdutoID", 80),
        ("NomeProduto", 550),          // 🔒 Fixa em 550
        ("PrecoCusto", 80),
        ("Lucro", 80),
        ("PrecoDeVenda", 80),
        ("Estoque", 80),
        ("DataDeEntrada", 100),
        ("DataValidade", 100)
            };

            foreach (var (nome, largura) in colunasFixas)
            {
                if (dataGridPesquisar.Columns[nome] != null)
                {
                    var col = dataGridPesquisar.Columns[nome];
                    col.Width = largura;
                    col.Resizable = DataGridViewTriState.False;
                    col.ReadOnly = true;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // 🔑 fixa
                }
            }

            // 4. Colunas dinâmicas (ajustam conforme conteúdo)
            var colunasAuto = new string[]
            {
        "Referencia",
        "NomeFornecedor",
        "Marca"
            };

            foreach (var nome in colunasAuto)
            {
                if (dataGridPesquisar.Columns[nome] != null)
                {
                    var col = dataGridPesquisar.Columns[nome];
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // 🔄 ajusta ao conteúdo
                    col.ReadOnly = true;
                }
            }

            // 5. Congela algumas colunas
            if (dataGridPesquisar.Columns["ProdutoID"] != null) dataGridPesquisar.Columns["ProdutoID"].Frozen = true;
            if (dataGridPesquisar.Columns["NomeProduto"] != null) dataGridPesquisar.Columns["NomeProduto"].Frozen = true;

            // 6. Estilo do cabeçalho
            dataGridPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridPesquisar.ColumnHeadersHeight = 35;
            dataGridPesquisar.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            dataGridPesquisar.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridPesquisar.RowHeadersWidth = 30;

            // 7. Formatações especiais
            if (dataGridPesquisar.Columns["PrecoCusto"] != null)
            {
                dataGridPesquisar.Columns["PrecoCusto"].DefaultCellStyle.Format = "N2";
                dataGridPesquisar.Columns["PrecoCusto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dataGridPesquisar.Columns["Lucro"] != null)
            {
                dataGridPesquisar.Columns["Lucro"].DefaultCellStyle.Format = "N2";
                dataGridPesquisar.Columns["Lucro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dataGridPesquisar.Columns["PrecoDeVenda"] != null)
            {
                dataGridPesquisar.Columns["PrecoDeVenda"].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10F, FontStyle.Bold);
                dataGridPesquisar.Columns["PrecoDeVenda"].DefaultCellStyle.ForeColor = Color.DarkGreen;
                dataGridPesquisar.Columns["PrecoDeVenda"].DefaultCellStyle.BackColor = Color.LightYellow;
            }
            if (dataGridPesquisar.Columns["Estoque"] != null)
            {
                dataGridPesquisar.Columns["Estoque"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataGridPesquisar.Columns["DataDeEntrada"] != null)
            {
                dataGridPesquisar.Columns["DataDeEntrada"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridPesquisar.Columns["DataDeEntrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataGridPesquisar.Columns["DataValidade"] != null)
            {
                dataGridPesquisar.Columns["DataValidade"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridPesquisar.Columns["DataValidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // 8. Força o grid a respeitar tudo
            dataGridPesquisar.PerformLayout();
        }

        public new int ObterLinhaAtual()
        {
            return LinhaAtual;
        }

        public void ListarProduto()
        {
            ProdutoDALL dao = new();
            dataGridPesquisar.DataSource = dao.ListarTodos();

            PersonalizarDataGridView();
        }
        private void FrmLocalizarProduto_Load(object sender, EventArgs e)
        {
            ListarProduto();
            txtPesquisar.Focus();

            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }

        private void FrmLocalizarProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            isSelectingProduct = false;
        }

        // No FrmLocalizarProduto, após selecionar o produto e fechar o formulário
        private bool isSelectingProduct = false;
        private Form formChamador;
        private void PesquisarProduto()
        {
            ProdutoDALL dao = new ProdutoDALL();

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
                dataGridPesquisar.DataSource = dao.PesquisarProdutoPorNome(nome);
            }
        }
        private void SelecionarProduto()
        {
            decimal preco;
            // Verifica se o processo de seleção de produto já está em andamento
            if (isSelectingProduct) return;
            isSelectingProduct = true;

            try
            {
                // Obtém a linha atual selecionada na grid
                LinhaAtual = ObterLinhaAtual();
                if (LinhaAtual < 0 || LinhaAtual >= dataGridPesquisar.Rows.Count)
                {
                    // Verifica se a linha obtida é válida
                    MessageBox.Show("Linha inválida.");
                    return;
                }
                // Verifica e obtém os valores das células NomeProduto e PrecoDeVenda
                if (dataGridPesquisar["NomeProduto", LinhaAtual]?.Value == null ||
                    dataGridPesquisar["ProdutoID", LinhaAtual].Value == null ||
                    dataGridPesquisar["PrecoDeVenda", LinhaAtual]?.Value == null ||
                    !decimal.TryParse(dataGridPesquisar["PrecoDeVenda", LinhaAtual].Value.ToString(), out preco))
                {
                    // Caso os valores não sejam válidos, exibe uma mensagem de erro
                    MessageBox.Show("Dados do produto inválidos.");
                    return;
                }
                // Se chegou aqui, atribui à propriedade
                PrecoUnitario = preco;
                // Converte o valor da célula NomeProduto para string
                ProdutoID = int.Parse(dataGridPesquisar["ProdutoID", LinhaAtual].Value.ToString());
                NomeProduto = dataGridPesquisar["NomeProduto", LinhaAtual].Value.ToString();
                referencia = dataGridPesquisar["Referencia", LinhaAtual].Value.ToString();
                PrecoUnitario = decimal.Parse(dataGridPesquisar["PrecoDeVenda", LinhaAtual].Value.ToString());

                // Acrescenta zeros à esquerda do ProdutoID
                string numeroComZeros = Utilitario.ZerosEsquerda(ProdutoID, 4);

               
                if (this.Owner is FrmVendas frmVendas)
                {
                    // Preenche os campos no formulário FrmPedido com os dados do produto
                    frmVendas.ProdutoID = ProdutoID;
                    frmVendas.txtNomeProduto.Text = NomeProduto;
                    frmVendas.txtPrecoUnitario.Text = PrecoUnitario.ToString();
                    frmVendas.txtQuantidade.Text = "1";
                    Utilitario.FormatarMoeda(frmVendas.txtPrecoUnitario);
                }
                else if (this.Owner is FrmEntradaEstoque frmEntradaEstoque)
                {
                    // Preenche os campos no formulário FrmPedido com os dados do produto
                    frmEntradaEstoque.txtProdutoID.Text = ProdutoID.ToString();
                    frmEntradaEstoque.txtNomeProduto.Text = NomeProduto;
                }
                // Fecha o formulário FrmLocalizarProduto
                this.Close();
            }
            finally
            {
                // Certifica-se de que a variável isSelectingProduct seja false ao final do processo
                isSelectingProduct = false;
            }
        }
        // Alterado em 23/01/2025***************ACIMA
        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarProduto();
        }

        private void dataGridPesquisar_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // Enter no DataGridView: seleciona cliente
                    SelecionarProduto(); // Chama seu método existente
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

        private void dataGridPesquisar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
        }

        private void dataGridPesquisar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarProduto();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dataGridPesquisar.Focus();
            }
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            PesquisarProduto();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
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

        private void btnSai_Click(object sender, EventArgs e)
        {
            // SE TEM ALGUMA LINHA SELECIONADA → carrega os dados antes de sair
            if (dataGridPesquisar.CurrentRow != null && dataGridPesquisar.CurrentRow.Index >= 0)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
                SelecionarProduto(); // ← agora carrega mesmo clicando em Sair
                return; // sai com DialogResult.OK
            }

            // Se não tem nada selecionado → só fecha (sem carregar nada)
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmLocalizarProduto_Shown(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
            // Em vez disso, posicione o cursor no final
            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }
    }
}

