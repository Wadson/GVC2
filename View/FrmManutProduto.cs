using GVC.BLL;
using GVC.DAL;
using GVC.DALL;
using GVC.MODEL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace GVC.View
{
    public partial class FrmManutProduto : KryptonForm
    {
        private new string StatusOperacao;
        private readonly ProdutosBLL _produtosBll = new ProdutosBLL();

        public FrmManutProduto(string statusOperacao)
        {
            InitializeComponent();
            // Personalização do título
            this.Text = "Manutenção de Produtos";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254); 
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
        }

        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        public void ListarProduto()
        {
            ProdutosBLL objetoBll = new ProdutosBLL();
            dgvProdutos.DataSource = objetoBll.ListarTodos();
            PersonalizarDataGridView();
            Utilitario.AtualizarTotalKrypton(toolStripStatusLabelTotalRegistros, dgvProdutos);
        }
        public void PersonalizarDataGridView()
        {
            // 1. Desliga o auto‑resize global
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 🔹 1.1 REORDENAR COLUNAS antes de fazer qualquer configuração
            ReordenarColunas();

            // 🔹 1.2 OCULTAR COLUNAS
            string[] colunasParaOcultar = { "ProdutoID", "FornecedorID", "DataDeEntrada" };
            foreach (var nome in colunasParaOcultar)
            {
                if (dgvProdutos.Columns[nome] != null)
                {
                    dgvProdutos.Columns[nome].Visible = false;
                }
            }

            // 2. Cabeçalhos bonitos (mantendo apenas as colunas visíveis)
            if (dgvProdutos.Columns["NomeProduto"] != null)
                dgvProdutos.Columns["NomeProduto"].HeaderText = "Nome Produto";
            if (dgvProdutos.Columns["Referencia"] != null)
                dgvProdutos.Columns["Referencia"].HeaderText = "Referência";
            if (dgvProdutos.Columns["PrecoCusto"] != null)
                dgvProdutos.Columns["PrecoCusto"].HeaderText = "Preço Custo";
            if (dgvProdutos.Columns["Lucro"] != null)
                dgvProdutos.Columns["Lucro"].HeaderText = "Lucro";
            if (dgvProdutos.Columns["PrecoDeVenda"] != null)
                dgvProdutos.Columns["PrecoDeVenda"].HeaderText = "Preço Venda";
            if (dgvProdutos.Columns["Estoque"] != null)
                dgvProdutos.Columns["Estoque"].HeaderText = "Estoque";
            if (dgvProdutos.Columns["DataValidade"] != null)
                dgvProdutos.Columns["DataValidade"].HeaderText = "Validade";
            if (dgvProdutos.Columns["NomeFornecedor"] != null)
                dgvProdutos.Columns["NomeFornecedor"].HeaderText = "Fornecedor";
            if (dgvProdutos.Columns["Marca"] != null)
                dgvProdutos.Columns["Marca"].HeaderText = "Marca";

            // 3. Colunas fixas (largura definida e não mudam)
            var colunasFixas = new (string nome, int largura)[]
            {
        ("NomeProduto", 400),
        ("PrecoCusto", 80),
        ("Lucro", 80),
        ("PrecoDeVenda", 80),
        ("Estoque", 80),
        ("DataValidade", 100)
            };

            foreach (var (nome, largura) in colunasFixas)
            {
                if (dgvProdutos.Columns[nome] != null)
                {
                    var col = dgvProdutos.Columns[nome];
                    col.Width = largura;
                    col.Resizable = DataGridViewTriState.False;
                    col.ReadOnly = true;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
            }

            // 🔹 3.1 CONFIGURAÇÃO ESPECIAL PARA COLUNA "FORNECEDOR" (mais larga)
            if (dgvProdutos.Columns["NomeFornecedor"] != null)
            {
                var colFornecedor = dgvProdutos.Columns["NomeFornecedor"];
                colFornecedor.Width = 200;
                colFornecedor.MinimumWidth = 150;
                colFornecedor.Resizable = DataGridViewTriState.True;
                colFornecedor.ReadOnly = true;
                colFornecedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            // 4. Colunas dinâmicas (ajustam conforme conteúdo)
            var colunasAuto = new string[]
            {
        "Referencia",
        "Marca"
            };

            foreach (var nome in colunasAuto)
            {
                if (dgvProdutos.Columns[nome] != null)
                {
                    var col = dgvProdutos.Columns[nome];
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    col.ReadOnly = true;
                }
            }

            // 🔹 5. Congela algumas colunas (APÓS garantir a ordem)
            // Primeiro defina DisplayIndex para garantir a ordem
            if (dgvProdutos.Columns["NomeProduto"] != null)
            {
                dgvProdutos.Columns["NomeProduto"].DisplayIndex = 0; // Primeira coluna visível
                dgvProdutos.Columns["NomeProduto"].Frozen = true;    // Agora pode congelar
            }

            // 6. Estilo do cabeçalho
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProdutos.ColumnHeadersHeight = 35;
            dgvProdutos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Regular);
            dgvProdutos.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvProdutos.RowHeadersWidth = 30;

            // 7. Formatações especiais (igual ao anterior)
            if (dgvProdutos.Columns["PrecoCusto"] != null)
            {
                dgvProdutos.Columns["PrecoCusto"].DefaultCellStyle.Format = "N2";
                dgvProdutos.Columns["PrecoCusto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvProdutos.Columns["Lucro"] != null)
            {
                dgvProdutos.Columns["Lucro"].DefaultCellStyle.Format = "N2";
                dgvProdutos.Columns["Lucro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvProdutos.Columns["PrecoDeVenda"] != null)
            {
                dgvProdutos.Columns["PrecoDeVenda"].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10F, FontStyle.Bold);
                dgvProdutos.Columns["PrecoDeVenda"].DefaultCellStyle.ForeColor = Color.DarkGreen;
                dgvProdutos.Columns["PrecoDeVenda"].DefaultCellStyle.BackColor = Color.LightYellow;
            }
            if (dgvProdutos.Columns["Estoque"] != null)
            {
                dgvProdutos.Columns["Estoque"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvProdutos.Columns["DataValidade"] != null)
            {
                dgvProdutos.Columns["DataValidade"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvProdutos.Columns["DataValidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvProdutos.Columns["NomeFornecedor"] != null)
            {
                dgvProdutos.Columns["NomeFornecedor"].DefaultCellStyle.Font =
                    new System.Drawing.Font("Segoe UI", 9F, FontStyle.Regular);
                dgvProdutos.Columns["NomeFornecedor"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
            }

            // 8. Força o grid a respeitar tudo
            dgvProdutos.PerformLayout();
        }

        // 🔹 Método para reordenar as colunas
        private void ReordenarColunas()
        {
            // Ordem desejada das colunas (da esquerda para direita)
            string[] ordemColunas =
            {
        "ProdutoID",           // Oculto, mas fica à esquerda
        "NomeProduto",         // Primeira coluna visível (congelada)
        "Referencia",
        "PrecoCusto",
        "Lucro",
        "PrecoDeVenda",
        "Estoque",
        "DataDeEntrada",       // Oculto
        "DataValidade",
        "NomeFornecedor",
        "Marca",
        "FornecedorID"         // Oculto
    };

            // Aplica a ordem
            for (int i = 0; i < ordemColunas.Length; i++)
            {
                if (dgvProdutos.Columns.Contains(ordemColunas[i]))
                {
                    dgvProdutos.Columns[ordemColunas[i]].DisplayIndex = i;
                }
            }
        }


        private void CarregaDados()
        {
            FrmCadProdutos frm = new FrmCadProdutos(StatusOperacao);

            // Se for NOVO, não precisa de linha selecionada
            if (StatusOperacao == "NOVO")
            {
                frm.btnSalva.Text = "&Salvar";
                StatusOperacao = "NOVO";

                // Personalização do título
                frm.Text = "Novo Produto";
                frm.StateCommon.Header.Content.ShortText.Color1 = Color.Green;
                frm.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frm.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);

                HabilitarTimer(true);
                frm.ShowDialog();
                return;
            }

            // Para ALTERAR ou EXCLUSÃO, precisa ter linha selecionada
            if (dgvProdutos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro primeiro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Carregar dados do produto selecionado
            var produto = (ProdutosModel)dgvProdutos.CurrentRow.DataBoundItem;

            frm.txtProdutoID.Text = produto.ProdutoID.ToString();
            frm.txtReferencia.Text = produto.Referencia ?? "";
            frm.txtNomeProduto.Text = produto.NomeProduto;
            frm.txtPrecoCusto.Text = produto.PrecoCusto.ToString("N2");
            frm.txtLucro.Text = produto.Lucro.ToString("N2");
            frm.txtPrecoDeVenda.Text = produto.PrecoDeVenda.ToString("N2");
            frm.txtEstoque.Text = produto.Estoque.ToString();
            frm.txtUnidade.Text = produto.Unidade ?? "";
            frm.txtMarca.Text = produto.Marca ?? "";
            frm.txtDataValidade.Text = produto.DataValidade.HasValue ? produto.DataValidade.Value.ToString("dd/MM/yyyy") : "";
            frm.txtGtinEan.Text = produto.GtinEan ?? "";
            frm.txtFornecedor.Text = produto.Fornecedor ?? "";
            frm.txtFornecedorID.Text = produto.FornecedorID.ToString();
            frm.cmbSituacao.Text = produto.Situacao ?? "";
            frm.cmbStatus.Text = produto.Status;

            // Carregar imagem
            if (!string.IsNullOrWhiteSpace(produto.Imagem) && File.Exists(produto.Imagem))
            {
                try
                {
                    frm.pbImagem.Image?.Dispose();
                    using (var fs = new FileStream(produto.Imagem, FileMode.Open, FileAccess.Read))
                        frm.pbImagem.Image = Image.FromStream(fs);
                    frm.txtEnderecoImagem.Text = produto.Imagem;
                    frm.pbImagem.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch { }
            }

            if (StatusOperacao == "ALTERAR")
            {               
                frm.btnSalva.Text = "&Alterar";
                frm.btnNovo.Enabled = false;
                // Personalização do título
                frm.Text = "Alterar Produto";
                frm.StateCommon.Header.Content.ShortText.Color1 = Color.Orange;
                frm.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frm.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
            }
            else if (StatusOperacao == "EXCLUSÃO")
            {                
                frm.btnSalva.Text = "&Excluir";

                // Personalização do título
                frm.Text = "Excluir Produto";
                frm.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
                frm.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frm.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
                // Desabilitar campos
                frm.btnNovo.Enabled = false;
                frm.txtNomeProduto.Enabled = false;
                frm.txtReferencia.Enabled = false;
                frm.txtPrecoCusto.Enabled = false;
                frm.txtLucro.Enabled = false;
                frm.txtPrecoDeVenda.Enabled = false;
                frm.txtEstoque.Enabled = false;
                frm.txtUnidade.Enabled = false;
                frm.txtMarca.Enabled = false;
                frm.txtDataValidade.Enabled = false;
                frm.txtGtinEan.Enabled = false;
                frm.txtFornecedor.Enabled = false;
                frm.cmbSituacao.Enabled = false;
                frm.cmbStatus.Enabled = false;
                frm.btnLocalizarImagem.Enabled = false;
            }

            frm.ShowDialog();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarProduto();
            timer1.Enabled = false;
        }

        private void FrmManutProduto_Load(object sender, EventArgs e)
        {
            ListarProduto();
        }

        private void dataGridPesquisar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvProdutos.Columns[e.ColumnIndex].Name == "PrecoCusto" || dgvProdutos.Columns[e.ColumnIndex].Name == "PrecoVenda") && e.Value != null)
            {
                decimal valor = (decimal)e.Value;
                e.Value = valor.ToString("C", CultureInfo.CurrentCulture);
                e.FormattingApplied = true;
            }
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
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutoDALL dao = new ProdutoDALL();

            if (rbtCodigo.Checked)
            {
                dgvProdutos.DataSource = dao.PesquisarProdutoPorCodigo(nome);
                Utilitario.AtualizarTotalKrypton(toolStripStatusLabelTotalRegistros, dgvProdutos);
            }
            else
            {
                dgvProdutos.DataSource = dao.PesquisarProdutoPorNome(nome);
                Utilitario.AtualizarTotalKrypton(toolStripStatusLabelTotalRegistros, dgvProdutos);
            }
            PersonalizarDataGridView();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para alterar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "ALTERAR";
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "EXCLUSÃO";
            CarregaDados();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FrmEntradaEstoque frm = new FrmEntradaEstoque();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
