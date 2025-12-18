using GVC.DALL;
using GVC.MODEL;
using Krypton.Toolkit;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GVC.View
{
    public partial class FrmVendas : KryptonForm
    {
        #region ===== CAMPOS / ESTADO ======================================
        private bool bloqueiaPesquisa = false;
        private bool _clienteFoiSelecionado = false;
        private readonly string QueryVenda = "SELECT MAX(VendaID) FROM Venda";
        public int ClienteID { get; set; }
        public int ProdutoID { get; set; }        
        private decimal _subtotal = 0m;
        private decimal _desconto = 0m;
        private decimal _valorTotal = 0m;
        public string StatusVenda { get; set; }


        private BindingList<ItemVendaModel> _itensBinding = new BindingList<ItemVendaModel>();
        private BindingSource _itensBindingSource = new BindingSource();

        private List<ParcelaModel> parcelasDaVenda = new List<ParcelaModel>();
        private VendaModel venda = new VendaModel();

        #endregion

        //ANTIGO ABAIXO
        public bool BloqueiaPesquisa
        {
            get { return bloqueiaPesquisa; }
            set { bloqueiaPesquisa = value; }
        }

        private readonly VendaService _vendaService = new VendaService();
        public string clienteSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        public string produtoSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        // guarda as parcelas geradas pelo FrmGeraParcelas (mantém separadas até salvar)
        private List<ParcelaModel> _parcelasGeradas = new List<ParcelaModel>();
        private FrmLocalizarCliente frmPesquisaCliente;
        private bool formularioPesquisaAberto = false;
        // Fim ANTIGO

        #region ===== CONSTRUTOR ===========================================
        public FrmVendas()
        {
            InitializeComponent();
            InicializarFormulario(); // <<< OBRIGATÓRIO
              
            dgvitens.CellEndEdit += dgvitens_CellEndEdit;
            this.Text = "Frente de Caixa";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 18);
        }
        #endregion

        #region ===== INICIALIZAÇÃO =========================================

       
        private void InicializarFormulario()
        {
            this.Text = "Frente de Caixa";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 18);

            ConfigurarGridItensVenda();

            _itensBindingSource.DataSource = _itensBinding;
            dgvitens.DataSource = _itensBindingSource;

            txtQuantidade.Text = "1";
            txtPrecoUnitario.Text = "0,00";
            txtDesconto.Text = "0,00";
            txtTotalGeral.Text = "0,00";
            
            AtualizarTotais();
        }
        private void FrmVendas_Load(object sender, EventArgs e)
        {            
            Utilitario.CarregarFormasPagamento(cmbFormaPagamento);
            int vendaID = Utilitario.ProximoId(QueryVenda);
            lblVendaID.Text = Utilitario.ZerosEsquerda(vendaID, 4).ToString();
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");

            dgvParcelas.Columns.Clear();
            dgvParcelas.Columns.Add("Parcela", "Parcela");
            dgvParcelas.Columns.Add("Vencimento", "Vencimento");
            dgvParcelas.Columns.Add("Valor", "Valor");
            dgvParcelas.Columns.Add("Status", "Status");
            dgvParcelas.Columns["Parcela"].Width = 60;
            dgvParcelas.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            txtNomeCliente.Focus();
        }
        #endregion

        #region ===== GRID =========================================
        private void ConfigurarGridItensVenda()
        {
            dgvitens.AutoGenerateColumns = false;
            dgvitens.Columns.Clear();

            dgvitens.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Código",
                DataPropertyName = nameof(ItemVendaModel.ProdutoID),
                Width = 100,
                ReadOnly = true
            });
            dgvitens.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Descrição",
                DataPropertyName = nameof(ItemVendaModel.NomeProduto),
                Width = 350,
                ReadOnly = true
            });

            dgvitens.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Qtde",
                DataPropertyName = nameof(ItemVendaModel.Quantidade),
                Width = 80
            });

            dgvitens.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Preço",
                DataPropertyName = nameof(ItemVendaModel.PrecoUnitario),
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvitens.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Subtotal",
                DataPropertyName = nameof(ItemVendaModel.Subtotal),
                Width = 120,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvitens.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "X",
                UseColumnTextForButtonValue = true,
                Width = 40
            });

            dgvitens.AllowUserToAddRows = false;
            dgvitens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvitens.EnableHeadersVisualStyles = false;
            dgvitens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvitens.ColumnHeadersHeight = 35;
            dgvitens.RowHeadersVisible = false;
            dgvitens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        #endregion

        #region ===== ITENS =======================================

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (ProdutoID <= 0)
            {
                MessageBox.Show("Produto inválido.");
                return;
            }

            if (!decimal.TryParse(txtPrecoUnitario.Text, out decimal preco))
                return;

            int qtd = Convert.ToInt32(txtQuantidade.Text);

            // Busca o item na lista de itens
            var item = _itensBinding.FirstOrDefault(i => i.ProdutoID == ProdutoID);

            // Se o item já existir, atualiza a quantidade
            if (item != null)
            {
                item.Quantidade += qtd;
            }
            else
            {
                // Adiciona um novo item com o nome do produto
                _itensBinding.Add(new ItemVendaModel
                {
                    VendaID = venda.VendaID,
                    ProdutoID = ProdutoID,
                    Quantidade = qtd,
                    PrecoUnitario = preco,
                    Subtotal = qtd * preco,
                    DescontoItem = 0m,
                    NomeProduto = txtNomeProduto.Text // Aqui preenchemos o nome do produto
                });
            }

            // Atualiza o binding da lista de itens
            _itensBindingSource.ResetBindings(false);

            // Força a atualização da grid
            dgvitens.Refresh();

            // Atualiza os totais da venda
            AtualizarTotais();

            // Limpa os campos do produto
            LimparCamposProduto();

            // Foca no campo Nome do Produto
            txtNomeProduto.Focus();
        }

        private void dgvItensVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvitens.Columns.Count - 1 && e.RowIndex >= 0)
            {
                var item = dgvitens.Rows[e.RowIndex].DataBoundItem as ItemVendaModel;
                if (item != null)
                {
                    _itensBinding.Remove(item);
                    AtualizarTotais();
                }
            }
        }

        #endregion

        #region ===== CÁLCULOS =========================

        private void AtualizarSubtotalItem()
        {
            decimal.TryParse(txtQuantidade.Text, out decimal qtd);
            decimal.TryParse(txtPrecoUnitario.Text, out decimal preco);
        }

        private void AtualizarTotais()
        {
            _subtotal = _itensBinding.Sum(i => i.Subtotal);

            //decimal.TryParse(txtDesconto.Text, out _desconto);
            //if (_desconto > _subtotal) _desconto = _subtotal;
            decimal.TryParse(txtDesconto.Text, out _desconto);

            // Blindagem definitiva
            if (_desconto < 0)
                _desconto = 0;

            if (_desconto > _subtotal)
                _desconto = _subtotal;


            _valorTotal = _subtotal - _desconto;

            decimal.TryParse(txtValorRecebido.Text, out decimal recebido);
            decimal troco = Math.Max(0, recebido - _valorTotal);

            txtSubTotal.Text = _subtotal.ToString("N2");
            txtTotalGeral.Text = _valorTotal.ToString("N2");
            txtTroco.Text = troco.ToString("N2");
        }

        #endregion

        #region ===== EVENTOS DE TEXTO ====================

        private void txtQuantidade_TextChanged(object sender, EventArgs e) => AtualizarSubtotalItem();
        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e) => AtualizarSubtotalItem();
        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #endregion

        #region ===== SALVAR =================================


        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClienteID <= 0)
                    throw new Exception("Selecione um cliente.");

                if (_itensBinding.Count == 0)
                    throw new Exception("Adicione itens à venda.");

                if (cmbFormaPagamento.SelectedItem is not FormaPagamentoItem forma)
                    throw new Exception("Selecione uma forma de pagamento válida.");

                // ===============================
                // MONTAR VENDA
                // ===============================
                var venda = new VendaModel
                {
                    ClienteID = ClienteID,
                    FormaPgtoID = forma.Id,
                    DataVenda = DateTime.Now,
                    ValorTotal = Convert.ToDecimal(txtTotalGeral.Text),
                    Desconto = Convert.ToDecimal(txtDesconto.Text),
                    Observacoes = txtObservacao.Text,
                    StatusVenda = CalcularStatusVendaPorFormaPgto(forma.Descricao)
                };

                // ===============================
                // MONTAR PARCELAS
                // ===============================
                var parcelas = MontarParcelasDaVenda();

                // ===============================
                // SALVAR TUDO
                // ===============================
                var vendaDal = new VendaDal();

                int vendaId = vendaDal.AddVendaCompleta(
                    venda,
                    _itensBinding.ToList(),
                    parcelas
                );

                // implementação adicional: validação de crediário
                if (parcelas.Count == 0 && cmbFormaPagamento.Text.Contains("Crediário"))
                {
                    MessageBox.Show("Venda em crediário sem parcelas geradas.", "Atenção");
                    return;
                }
                if (cmbFormaPagamento.Text.Contains("Crediário") && dgvParcelas.Rows.Count == 0)
                {
                    MessageBox.Show("Gere as parcelas antes de salvar uma venda no crediário.");
                    tabControlPagamento.SelectedTab = tabParcelas;
                    return;
                }
                // fim da implementação adicional

                MessageBox.Show(
                    $"Venda salva com sucesso!\nVenda Nº {vendaId}",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao salvar venda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }           
        }

        #endregion

        #region ===== AUXILIARES =====

        private void LimparCamposProduto()
        {
            ProdutoID = 0;
            txtNomeProduto.Clear();
            txtQuantidade.Text = "1";
            txtPrecoUnitario.Text = "0,00";
        }
        private void LimparFormulario()
        {
            ClienteID = 0;
            _itensBinding.Clear();
            txtDesconto.Text = "0,00";
            txtSubTotal.Text = "0,00";
            txtTotalGeral.Text = "0,00";
            txtValorRecebido.Text = "0,00";
            txtTroco.Text = "0,00";
        }
              

        #endregion
        #region Eventos

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            AtualizarTotais();
        }

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtTotalGeral.Text) <= 0)
            {
                MessageBox.Show("Total da venda inválido.");
                return;
            }
            tabParcelas.Enabled = true;
            tabControlPagamento.SelectedTab = tabParcelas;
            txtValorTotalParcelado.Text = txtTotalGeral.Text;
        }

        private void cmbFormaPgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPagamento.SelectedItem == null)
            {
                btnGerarParcelas.Enabled = false;
                return;
            }

            string formaPgto = cmbFormaPagamento.SelectedItem.ToString();

            btnGerarParcelas.Enabled =
                formaPgto == "Boleto Bancário" ||
                formaPgto == "Cheque" ||
                formaPgto == "Crediário" ||
                formaPgto == "Financiamento";
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            if (bloqueiaPesquisa || string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                return;

            // SALVA O TEXTO ATUAL ANTES DE PERDER O FOCO
            string textoDigitado = txtNomeCliente.Text;

            // Usa BeginInvoke para "adiar" a abertura da pesquisa até o Windows terminar de processar a digitação
            this.BeginInvoke(new Action(() =>
            {
                if (bloqueiaPesquisa) return; // pode ter sido bloqueado enquanto esperava

                bloqueiaPesquisa = true;
                try
                {
                    using (var pesquisaCliente = new FrmLocalizarCliente(this, textoDigitado))
                    {
                        pesquisaCliente.Owner = this;

                        if (pesquisaCliente.ShowDialog() == DialogResult.OK)
                        {
                            bloqueiaPesquisa = true;
                            txtNomeCliente.Text = pesquisaCliente.ClienteSelecionado;
                            ClienteID = pesquisaCliente.ClienteID;
                            txtNomeCliente.SelectionStart = txtNomeCliente.Text.Length;
                            txtCpf.Text = pesquisaCliente.Cpf;
                        }
                    }
                }
                finally
                {
                    bloqueiaPesquisa = false;
                }
            }));
        }
        #endregion


        #region Helpers
        private void AtualizarSubtotalItem2()
        {
            decimal quantidade = 0m;
            decimal preco = 0m;

            if (!string.IsNullOrWhiteSpace(txtQuantidade.Text))
                decimal.TryParse(txtQuantidade.Text, out quantidade);

            if (!string.IsNullOrWhiteSpace(txtPrecoUnitario.Text))
                decimal.TryParse(txtPrecoUnitario.Text, out preco);
        }

        #endregion

        private void FrmVendas_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            if (bloqueiaPesquisa || string.IsNullOrWhiteSpace(txtNomeProduto.Text))
                return;

            // SALVA O TEXTO ATUAL ANTES DE PERDER O FOCO
            string textoDigitado = txtNomeProduto.Text;

            // Usa BeginInvoke para "adiar" a abertura da pesquisa até o Windows terminar de processar a digitação
            this.BeginInvoke(new Action(() =>
            {
                if (bloqueiaPesquisa) return; // pode ter sido bloqueado enquanto esperava

                bloqueiaPesquisa = true;
                try
                {
                    using (var pesquisaProduto = new FrmLocalizarProduto(this, textoDigitado))
                    {
                        pesquisaProduto.Owner = this;

                        if (pesquisaProduto.ShowDialog() == DialogResult.OK)
                        {
                            bloqueiaPesquisa = true;
                            txtNomeProduto.Text = pesquisaProduto.ProdutoSelecionado;
                            txtPrecoUnitario.Text = pesquisaProduto.PrecoUnitario.ToString("N2");
                            ProdutoID = pesquisaProduto.ProdutoID;
                            txtNomeProduto.SelectionStart = txtNomeProduto.Text.Length;
                        }
                    }
                }
                finally
                {
                    bloqueiaPesquisa = false;
                }
            }));
        }

        private void FrmVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
                }
            }

        private void txtPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizarSubtotalItem2();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizarSubtotalItem2();
        }

        private void dgvitens_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dgvitens.CommitEdit(DataGridViewDataErrorContexts.Commit);

            var item = dgvitens.Rows[e.RowIndex].DataBoundItem as ItemVendaModel;
            if (item == null) return;

            // Blindagem + recálculo imediato
            if (item.Quantidade < 0)
                item.Quantidade = 0;

            if (item.PrecoUnitario < 0)
                item.PrecoUnitario = 0;

            if (item.DescontoItem < 0)
                item.DescontoItem = 0;

            decimal subtotalBruto = item.Quantidade * item.PrecoUnitario;

            if (item.DescontoItem > subtotalBruto)
                item.DescontoItem = subtotalBruto;

            item.Subtotal = subtotalBruto - item.DescontoItem;

            _itensBindingSource.ResetBindings(false);
            AtualizarTotais();
        }

        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            AtualizarTotais();
        }

        private void btnCancelarParcelas_Click(object sender, EventArgs e)
        {
            //5.AJUSTE IMPORTANTE NO CANCELAR PARCELAS

            dgvParcelas.Rows.Clear();
            parcelasDaVenda.Clear();

            numParcelas.Value = 1;
            numIntervalo.Value = 30;
            dtPrimeira.Value = DateTime.Today;
            txtValorParcela.Clear();

            tabParcelas.Enabled = false;
            tabControlPagamento.SelectedTab = tabPagamento;
        }
        private void GerarParcelas()
        {
            dgvParcelas.Rows.Clear();

            if (!decimal.TryParse(txtTotalGeral.Text, out decimal total) || total <= 0)
            {
                MessageBox.Show("Total da venda inválido.");
                return;
            }

            int qtdParcelas = (int)numParcelas.Value;
            int intervaloDias = (int)numIntervalo.Value;
            DateTime dataInicial = dtPrimeira.Value.Date;

            if (qtdParcelas <= 0)
            {
                MessageBox.Show("Quantidade de parcelas inválida.");
                return;
            }

            // Valor base da parcela
            decimal valorBase = Math.Round(total / qtdParcelas, 2);

            // Ajuste de centavos
            decimal totalCalculado = valorBase * qtdParcelas;
            decimal diferenca = total - totalCalculado;

            for (int i = 1; i <= qtdParcelas; i++)
            {
                DateTime vencimento = dataInicial.AddDays(intervaloDias * (i - 1));

                decimal valorParcela = valorBase;

                // Última parcela absorve a diferença
                if (i == qtdParcelas)
                    valorParcela += diferenca;

                dgvParcelas.Rows.Add(
                    i,
                    vencimento.ToString("dd/MM/yyyy"),
                    valorParcela.ToString("N2"),
                    1 // Status Aberta
                );
            }

            txtValorParcela.Text = valorBase.ToString("N2");
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void numParcelas_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }
        private void numIntervalo_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }



        #region ==========INICIO DOS MÉTODOS DE VENDA==========
        //3. MÉTODO CENTRAL: MONTAR AS PARCELAS DA VENDA
        private List<ParcelaModel> MontarParcelasDaVenda()
        {
            var parcelas = new List<ParcelaModel>();

            int qtd = (int)numParcelas.Value; // ← MUDE AQUI: use .Value, não .Text

            if (qtd <= 0)
                return parcelas;

            decimal valorTotalReais = Convert.ToDecimal(txtTotalGeral.Text);
            decimal valorParcelaReais = valorTotalReais / qtd;
            decimal somaParcelas = 0m;

            DateTime dataInicial = dtPrimeira.Value.Date; // use a data do DateTimePicker
            int intervaloDias = (int)numIntervalo.Value;

            for (int i = 1; i <= qtd; i++)
            {
                DateTime vencimento = dataInicial.AddDays(intervaloDias * (i - 1));

                decimal valorParcela;
                if (i == qtd)
                {
                    valorParcela = valorTotalReais - somaParcelas;
                }
                else
                {
                    valorParcela = Math.Round(valorParcelaReais, 2);
                    somaParcelas += valorParcela;
                }

                parcelas.Add(new ParcelaModel
                {
                    NumeroParcela = i,
                    DataVencimento = vencimento,
                    ValorParcela = valorParcela,
                    ValorRecebido = 0m,
                    Status = "Pendente",
                    Juros = 0m,
                    Multa = 0m,
                    Observacao = null
                });
            }

            return parcelas;
        }

        //4. IMPLEMENTAÇÃO FINAL DO BOTÃO SALVAR VENDA
        private string CalcularStatusVendaPorFormaPgto(string formaPgto)
        {
            if (string.IsNullOrWhiteSpace(formaPgto))
                return "Aguardando Pagamento";


            // Aberta
            // Em Análise
            // Aguardando Pagamento
            // Concluída
            // Cancelada
            // Devolvida
            // Expirada
            // Parcialmente Pago
            // Suspensa
            string forma = formaPgto.ToUpperInvariant();

            if (forma.Contains("DINHEIRO") ||
                forma.Contains("PIX") ||
                forma.Contains("DÉBITO") ||
                forma.Contains("DEBITO") ||
                forma.Contains("CRÉDITO") ||
                forma.Contains("CREDITO") ||
                forma.Contains("TRANSFERÊNCIA") ||
                forma.Contains("TRANSFERENCIA"))
            {
                return "Concluída";
            }

            return "Aberta";
        }


        #endregion
    }
}
/*
                   
//========================STATUS PARA VENDA ABAIXO=============================

            Aberta               → Venda registrada, mas ainda não concluída (em andamento).
            Em Análise           → Aguardando aprovação de crédito ou validação interna.
            Aguardando Pagamento → Venda confirmada, mas o cliente ainda não pagou.
            Concluída            → Venda finalizada com sucesso, pagamento confirmado.
            Cancelada            → Venda anulada por desistência, erro ou acordo.
            Devolvida            → Venda concluída, mas houve devolução do produto/serviço.
            Expirada             → Quando o prazo de pagamento ou validade da proposta passou sem conclusão.
            Parcialmente Pago    → Cliente pagou parte do valor, mas ainda há saldo pendente.
            Suspensa             → Venda temporariamente interrompida (ex.: problemas logísticos ou decisão 


// ========================STATUS PARA PARCELA ABAIXO=============================

            Aberta               → não faz sentido para parcela (é mais para venda)
            Atrasada             → Parcela cujo vencimento já passou e não foi paga.
            Aguardando Pagamento → melhor usar "Pendente"
            Pago                 → melhor usar "Paga"
            Cancelada            → Parcela anulada, não precisa mais ser paga (ex.: erro de lançamento, acordo).
            Devolvida            → raro em parcela, mas pode ter
            Parcialmente Pago    → melhor "Parcialmente Paga"

          //===========TABELA PARCELA STATUS==============================================

                   * */