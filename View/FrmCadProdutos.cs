using GVC.BLL;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
namespace GVC.View
{
    public partial class FrmCadProdutos : KryptonForm
    {
        private string QueryProdutos = "SELECT MAX(ProdutoID) FROM Produtos";
        private string StatusOperacao;
        private int produtoID;
        public int ClienteID { get; set; }
        private bool bloqueiaPesquisa = false;
        public string clienteSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        public FrmCadProdutos(string statusOperacao)
        {
            InitializeComponent();
            // Utiliza a classe Utilitario para adicionar os efeitos de foco a todos os TextBoxes no formulário
            //Utilitario.AdicionarEfeitoFocoEmTodos(this);
            Utilitario.ConfigurarEnterComoTab(this);
            this.txtPrecoCusto.Enter += new System.EventHandler(this.txtPrecoCusto_Enter);
            this.txtPrecoCusto.Leave += new System.EventHandler(this.txtPrecoCusto_Leave);
            this.txtLucro.Enter += new System.EventHandler(this.txtLucro_Enter);
            this.txtLucro.Leave += new System.EventHandler(this.txtLucro_Leave);
            this.StatusOperacao = statusOperacao;
        }
        private void FrmCadProdutos_Load(object sender, EventArgs e)
        {
            Utilitario.FormatarMoeda(txtPrecoCusto);
            Utilitario.FormatarMoeda(txtLucro);
            Utilitario.FormatarMoeda(txtPrecoDeVenda);
            if (StatusOperacao == "ALTERAR")
            {
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                int NovoCodigo = Utilitario.ProximoId(QueryProdutos);//RetornaCodigoContaMaisUm(QueryUsuario).ToString();
                string numeroComZeros = Utilitario.ZerosEsquerda(NovoCodigo, 4);
                txtProdutoID.Text = numeroComZeros;

                cmbStatus.SelectedIndex = 1;
                cmbSituacao.SelectedIndex = 0;
            }
        }
        private void CalcularPrecoVenda()
        {
            if (decimal.TryParse(txtPrecoCusto.Text, out decimal precoCusto) &&
            !string.IsNullOrWhiteSpace(txtLucro.Text))
            {
                decimal precoVenda = 0;
                if (txtLucro.Text.EndsWith("%"))
                {
                    string lucroPercentualStr = txtLucro.Text.TrimEnd('%');
                    if (decimal.TryParse(lucroPercentualStr, out decimal lucroPercentual))
                    {
                        precoVenda = precoCusto + (precoCusto * lucroPercentual / 100);
                    }
                }
                else if (decimal.TryParse(txtLucro.Text, out decimal lucro))
                {
                    precoVenda = precoCusto + lucro;
                }
                txtPrecoDeVenda.Text = precoVenda.ToString(CultureInfo.CurrentCulture);
            }
            else
            {
                txtPrecoDeVenda.Text = string.Empty;
            }
        }
        private void CalcularLucro()
        {
            if (decimal.TryParse(txtPrecoCusto.Text, out decimal precoCusto) &&
            decimal.TryParse(txtPrecoDeVenda.Text, out decimal precoVenda))
            {
                decimal lucroCalculado = precoVenda - precoCusto;
                txtLucro.Text = lucroCalculado.ToString(CultureInfo.CurrentCulture);
            }
            else
            {
                txtLucro.Text = string.Empty;
            }
        }
        private void Salvar()
        {
            // Validação segura dos campos numéricos
            int produtoId;
            int.TryParse(txtProdutoID.Text, out produtoId);

            decimal precoCusto;
            decimal.TryParse(txtPrecoCusto.Text, out precoCusto);

            decimal lucro;
            decimal.TryParse(txtLucro.Text, out lucro);

            decimal precoDeVenda;
            decimal.TryParse(txtPrecoDeVenda.Text, out precoDeVenda);

            int estoque;
            int.TryParse(txtEstoque.Text, out estoque);
            ProdutosModel produto = new ProdutosModel
            {
                ProdutoID = produtoId,
                NomeProduto = txtNomeProduto.Text,
                PrecoCusto = precoCusto,
                Lucro = lucro,
                PrecoDeVenda = precoDeVenda,
                Estoque = estoque,
                DataDeEntrada = dtpDataDeEntrada?.Value.Date ?? DateTime.Today,
                Status = cmbStatus.Text,
                Referencia = txtReferencia.Text,
                // 🔹 Novos campos
                Situacao = cmbSituacao.Text,
                Unidade = txtUnidade.Text,
                Marca = txtMarca.Text,
                DataValidade = DateTime.TryParseExact(txtDataValidade.Text, "dd/MM/yyyy",
               CultureInfo.GetCultureInfo("pt-BR"),
               DateTimeStyles.None, out DateTime dataValida)
               ? (DateTime?)dataValida
               : null,
                GtinEan = txtGtinEan.Text,
                Imagem = txtEnderecoImagem.Text,
                FornecedorID = txtFornecedorID.Text != "" ? long.Parse(txtFornecedorID.Text) : 0,
            };
            try
            {
                ProdutosBLL produtosbll = new ProdutosBLL();

                produtosbll.Inserir(produto);
                MessageBox.Show("Produto salvo com sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Utilitario.LimparCampos(this);
                int NovoCodigo = Utilitario.ProximoId(QueryProdutos);
                string numeroComZeros = Utilitario.ZerosEsquerda(NovoCodigo, 4);
                txtProdutoID.Text = numeroComZeros;
                txtNomeProduto.Focus();
                cmbStatus.SelectedIndex = 1;
                cmbSituacao.SelectedIndex = 0;
                var frmManutProduto = Application.OpenForms["FrmManutProduto"] as FrmManutProduto;
                if (frmManutProduto != null)
                {
                    frmManutProduto.HabilitarTimer(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Excluir()
        {
            try
            {
                if (MessageBox.Show($"Deseja realmente excluir o produto:\n\n{txtNomeProduto.Text}?",
                    "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    long produtoId = long.Parse(txtProdutoID.Text);
                    ProdutosBLL produtoBll = new ProdutosBLL();

                    bool sucesso = produtoBll.Excluir(produtoId); // ← Agora passa só o ID (long)

                    if (sucesso)
                    {
                        MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var frmManutProduto = Application.OpenForms["FrmManutProduto"] as FrmManutProduto;
                        frmManutProduto?.HabilitarTimer(true);

                        Utilitario.LimparCampos(this);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Alterar()
        {
            try
            {
                // Criar uma nova instância de ProdutoMODEL e preencher com os dados do formulário
                ProdutosModel produto = new ProdutosModel
                {
                    ProdutoID = int.Parse(txtProdutoID.Text),
                    NomeProduto = txtNomeProduto.Text,
                    PrecoCusto = decimal.Parse(txtPrecoCusto.Text),
                    Lucro = decimal.Parse(txtLucro.Text),
                    PrecoDeVenda = decimal.Parse(txtPrecoDeVenda.Text),
                    Estoque = int.Parse(txtEstoque.Text),
                    Status = cmbStatus.Text,
                    Referencia = txtReferencia.Text,
                    // 🔹 Novos campos
                    Situacao = cmbSituacao.Text, // se for ComboBox
                    Unidade = txtUnidade.Text, // TextBox ou ComboBox
                    Marca = txtMarca.Text, // TextBox
                    DataValidade = DateTime.TryParseExact(txtDataValidade.Text, "dd/MM/yyyy", CultureInfo.GetCultureInfo("pt-BR"), DateTimeStyles.None, out DateTime dataValida) ? (DateTime?)dataValida: null,
                    GtinEan = txtGtinEan.Text, // TextBox
                    Imagem = txtEnderecoImagem.Text, // TextBox com caminho da imagem
                    Fornecedor = txtFornecedor.Text, // ComboBox ou TextBox
                    FornecedorID = txtFornecedorID.Text != "" ? long.Parse(txtFornecedorID.Text) : 0,
                };
                // Chamar o método AlterarProduto da BLL
                ProdutosBLL produtosbll = new ProdutosBLL();
                produtosbll.Alterar(produto);
                MessageBox.Show("Produto alterado com sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Utilitario.LimparCampos(this);
                this.Close();
                var frmManutProduto = Application.OpenForms["FrmManutProduto"] as FrmManutProduto;
                if (frmManutProduto != null)
                {
                    frmManutProduto.HabilitarTimer(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar o registro: " + ex.Message);
            }
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                Alterar();
            }
            if (StatusOperacao == "NOVO")
            {
                Salvar();
                Utilitario.LimparCampos(this);
                txtNomeProduto.Focus();
                produtoID = Utilitario.ProximoId(QueryProdutos);
                txtProdutoID.Text = Utilitario.ZerosEsquerda(produtoID, 4);
                var frmManutProduto = Application.OpenForms["FrmManutProduto"] as FrmManutProduto;
                if (frmManutProduto != null)
                {
                    frmManutProduto.HabilitarTimer(true);
                }
            }
            if (StatusOperacao == "EXCLUSÃO")
            {
                if (MessageBox.Show("Deseja Excluir? \n\n O Usuário: " + txtNomeProduto.Text + " ??? ", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Excluir();
                }
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Utilitario.LimparCampos(this);
            produtoID = Utilitario.ProximoId("SELECT MAX(ProdutoID) FROM Produto");
            cmbStatus.SelectedIndex = 1;
            cmbSituacao.SelectedIndex = 0;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPrecoCusto_Leave(object sender, EventArgs e)
        {
            txtPrecoCusto.BackColor = Color.White;
            // Formata apenas se não estiver vazio
            if (!string.IsNullOrWhiteSpace(txtPrecoCusto.Text))
            {
                CalcularPrecoVenda();
            }
            if (!string.IsNullOrWhiteSpace(txtPrecoDeVenda.Text))
            {
                Utilitario.FormatarMoeda(txtPrecoDeVenda);
            }
            Utilitario.FormatarMoeda(txtPrecoCusto);
        }
        private void txtLucro_Leave(object sender, EventArgs e)
        {
            /*Utilitario.FormatTextBoxToCurrency(txtLucro)*/
            ;
            txtLucro.BackColor = Color.White;
            // Formata apenas se não estiver vazio
            if (!string.IsNullOrWhiteSpace(txtLucro.Text))
            {
                CalcularPrecoVenda();
            }
            if (!string.IsNullOrWhiteSpace(txtPrecoDeVenda.Text))
            {
                Utilitario.FormatarMoeda(txtPrecoDeVenda);
            }
            Utilitario.FormatarMoeda(txtLucro);
        }
        private void txtPrecoCusto_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox = sender as KryptonTextBox;
            if (textBox != null && textBox.Text == "0,00")
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    textBox.Text = string.Empty;
                });
            }
        }
        private void txtLucro_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox = sender as KryptonTextBox;
            if (textBox != null && textBox.Text == "0,00")
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    textBox.Text = string.Empty;
                });
            }
        }
        private void txtPrecoDeVenda_Leave(object sender, EventArgs e)
        {
            CalcularLucro();
        }
        private void FrmCadProdutos_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }
        private void btnLocalizarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione uma imagem";
                ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 🔹 Base do sistema (onde o EXE está rodando)
                        string baseDir = AppDomain.CurrentDomain.BaseDirectory; // ou Application.StartupPath
                                                                                // Ex.: C:\GVC\bin\Debug\net8.0-windows7.0\
                                                                                //      D:\GVC\ (se estiver publicado)

                        // 🔹 Pasta "Imagem" dentro do sistema
                        string pastaDestino = Path.Combine(baseDir, "Imagem");

                        // Cria a pasta se não existir
                        if (!Directory.Exists(pastaDestino))
                            Directory.CreateDirectory(pastaDestino);

                        // 🔹 Gera nome único para evitar sobrescrever
                        string nomeOriginal = Path.GetFileName(ofd.FileName);
                        string extensao = Path.GetExtension(nomeOriginal);
                        string nomeBase = Path.GetFileNameWithoutExtension(nomeOriginal);
                        string nomeUnico = $"{nomeBase}_{DateTime.Now:yyyyMMdd_HHmmss}{extensao}";

                        // 🔹 Caminho completo de destino
                        string caminhoDestino = Path.Combine(pastaDestino, nomeUnico);

                        // Copia o arquivo para a pasta de destino
                        File.Copy(ofd.FileName, caminhoDestino, true);

                        // Atualiza o TextBox com o caminho de destino
                        txtEnderecoImagem.Text = caminhoDestino;

                        // Limpa imagem anterior
                        if (pbImagem.Image != null)
                        {
                            pbImagem.Image.Dispose();
                            pbImagem.Image = null;
                        }

                        // Carrega a imagem do destino
                        using (var fs = new FileStream(caminhoDestino, FileMode.Open, FileAccess.Read))
                        {
                            pbImagem.Image = Image.FromStream(fs);
                        }

                        pbImagem.SizeMode = PictureBoxSizeMode.Zoom;
                        pbImagem.Visible = true;
                        pbImagem.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Não foi possível carregar/copiar a imagem.\n\nDetalhes: {ex.Message}",
                                        "Erro ao carregar imagem",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void AbrirFrmLocalizarCidadeDinamico()
        {
            // Desliga temporariamente o evento para evitar loop
            txtFornecedor.TextChanged -= txtFornecedor_TextChanged;

            using (FrmLocalizarCliente frmLocalizarCliente = new FrmLocalizarCliente(this, clienteSelecionado))
            {
                frmLocalizarCliente.Owner = this;
                frmLocalizarCliente.ShowDialog();
                txtFornecedor.Text = frmLocalizarCliente.ClienteSelecionado; // Define o nome do cliente retornado
                ClienteID = frmLocalizarCliente.ClienteID; // Define o ID do cliente retornado
                txtFornecedorID.Text = frmLocalizarCliente.ClienteID.ToString(); // Define o ID no TextBox correspondente
            }

            // Religa o evento após modificar o texto
            txtFornecedor.TextChanged += txtFornecedor_TextChanged;
        }
        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFrmLocalizarCidadeDinamico();
        }

        private void txtDataValidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDataValidade.Text) && txtDataValidade.Text.Length == 10)
            {
                if (!DateTime.TryParseExact(txtDataValidade.Text, "dd/MM/yyyy",
                    CultureInfo.GetCultureInfo("pt-BR"), DateTimeStyles.None, out _))
                {
                    MessageBox.Show("Data de validade inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDataValidade.Focus();
                    txtDataValidade.SelectAll();
                }
            }
        }

        private void txtDataValidade_TextChanged(object sender, EventArgs e)
        {
            string apenasNums = Utilitario.ApenasNumeros(txtDataValidade.Text);

            if (apenasNums.Length > 8)
                apenasNums = apenasNums.Substring(0, 8);

            string formatado = apenasNums;

            if (apenasNums.Length >= 3)
                formatado = apenasNums.Insert(2, "/");

            if (apenasNums.Length >= 5)
                formatado = formatado.Insert(5, "/");

            int pos = txtDataValidade.SelectionStart;
            txtDataValidade.Text = formatado;
            txtDataValidade.SelectionStart = Math.Min(pos + 1, txtDataValidade.Text.Length);
        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (bloqueiaPesquisa || string.IsNullOrWhiteSpace(txtFornecedor.Text))
                return;
            
            string textoDigitado = txtFornecedor.Text;

            // VERIFICA SE O CONTROLE JÁ TEM UM HANDLE VÁLIDO
            if (!this.IsHandleCreated || txtFornecedor.IsDisposed)
                return;

            // Usa BeginInvoke para "adiar" a abertura da pesquisa até o Windows terminar de processar a digitação
            this.BeginInvoke(new Action(() =>
            {
                if (bloqueiaPesquisa || txtFornecedor.IsDisposed)
                    return;

                // pode ter sido bloqueado enquanto esperava
                bloqueiaPesquisa = true;
                try
                {
                    using (var pesquisarFornecedor = new FrmLocalizarFornecedor(this, textoDigitado))
                    {
                        pesquisarFornecedor.Owner = this;
                        if (pesquisarFornecedor.ShowDialog() == DialogResult.OK)
                        {
                            bloqueiaPesquisa = true;
                            txtFornecedor.Text = pesquisarFornecedor.FornecedorSelecionado;
                            txtFornecedorID.Text = pesquisarFornecedor.FornecedorID.ToString();
                            ClienteID = pesquisarFornecedor.FornecedorID;
                            txtFornecedor.SelectionStart = txtFornecedor.Text.Length;
                        }
                    }
                }
                finally
                {
                    bloqueiaPesquisa = false;
                }
            }));
        }
    }
}