using Dapper;
using GVC.BLL;
using GVC.MODEL;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmContasAReceber : KryptonForm
    {
        private bool bloqueiaPesquisa = false;
        public int ClienteID { get; set; }

        private readonly VendaBLL _vendaBll = new VendaBLL();
        private readonly ItensVendaBLL _itensVendaBll = new ItensVendaBLL();

        public FrmContasAReceber()
        {
            InitializeComponent();
        }

        private void ConfigurarGridContasAReceber()
        {
            dgvContasAReceber.AutoGenerateColumns = false;
            dgvContasAReceber.Columns.Clear();

            var chk = new DataGridViewCheckBoxColumn
            {
                Name = "Selecionar",
                HeaderText = "",
                Width = 30,
            };
            dgvContasAReceber.Columns.Add(chk);

            var colParcelaID = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ParcelaID",
                HeaderText = "ID",
                Width = 60,
                Visible = false
            };
            dgvContasAReceber.Columns.Add(colParcelaID); // Coluna ID (oculta)

            var colVendaID = new DataGridViewTextBoxColumn
            {
                Name = "VendaID",               // OBRIGATÓRIO
                DataPropertyName = "VendaID",
                HeaderText = "IDVenda",
                Width = 60,
                Visible = false
            };

            dgvContasAReceber.Columns.Add(colVendaID);

            var colParcela = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroParcela",
                HeaderText = "Nº Parc.",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvContasAReceber.Columns.Add(colParcela);

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeCliente",
                HeaderText = "Cliente",
                Width = 200,
                ValueType = typeof(string)
            });

            // Datas: assegure o tipo DateTime e o formato
            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVenda",
                HeaderText = "Data Venda",
                Width = 100,
                ValueType = typeof(DateTime),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVencimento",
                HeaderText = "Vencimento",
                Width = 100,
                ValueType = typeof(DateTime),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            // Valores: tipo decimal e formato moeda
            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorParcela",
                HeaderText = "Valor Parcela",
                Width = 100,
                ValueType = typeof(long),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorRecebido",
                HeaderText = "Recebido",
                Width = 100,
                ValueType = typeof(long),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Saldo",
                HeaderText = "Saldo",
                Width = 100,
                ValueType = typeof(long),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusParcela",
                HeaderText = "Status",
                Width = 90,
                ValueType = typeof(string)
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FormaPgto",
                HeaderText = "Forma Pgto",
                Width = 120,
                ValueType = typeof(string)
            });
            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Observacao",
                HeaderText = "Observações",
                Width = 200,
                ValueType = typeof(string)
            });

            // Opcional: estilo geral
            dgvContasAReceber.AllowUserToAddRows = false;
            dgvContasAReceber.AllowUserToDeleteRows = false;
            dgvContasAReceber.ReadOnly = true;
            dgvContasAReceber.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContasAReceber.MultiSelect = false;
            dgvContasAReceber.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgvContasAReceber.ReadOnly = false; // libera edição no grid inteiro

            foreach (DataGridViewColumn col in dgvContasAReceber.Columns)
            {
                if (col.Name != "Selecionar")
                    col.ReadOnly = true; // bloqueia todas as outras colunas
            }
        }
        private void ConfigurarGridItensVenda()
        {
            dgvItensVenda.AutoGenerateColumns = false;
            dgvItensVenda.Columns.Clear();

            // 🔹 Coluna ProdutoID (Cód. Prod.) - Centralizada
            var colProdutoID = new DataGridViewTextBoxColumn
            {
                Name = "ProdutoID",
                DataPropertyName = "ProdutoID",
                HeaderText = "Cód. Prod.",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvItensVenda.Columns.Add(colProdutoID);

            // 🔹 Coluna NomeProduto
            var colNomeProduto = new DataGridViewTextBoxColumn
            {
                Name = "NomeProduto",
                DataPropertyName = "NomeProduto",
                HeaderText = "Produto",
                Width = 250,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvItensVenda.Columns.Add(colNomeProduto);

            // 🔹 Coluna Quantidade - Centralizada
            var colQuantidade = new DataGridViewTextBoxColumn
            {
                Name = "Quantidade",
                DataPropertyName = "Quantidade",
                HeaderText = "Qtd",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvItensVenda.Columns.Add(colQuantidade);

            // 🔹 Coluna PrecoUnitario (Preço Unitário) - Formato moeda
            var colPrecoUnitario = new DataGridViewTextBoxColumn
            {
                Name = "PrecoUnitario",
                DataPropertyName = "PrecoUnitario",
                HeaderText = "Preço Unitário",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            };
            dgvItensVenda.Columns.Add(colPrecoUnitario);

            // 🔹 Coluna DescontoItem (Desconto) - Formato moeda
            var colDescontoItem = new DataGridViewTextBoxColumn
            {
                Name = "DescontoItem",
                DataPropertyName = "DescontoItem",
                HeaderText = "Desconto",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            };
            dgvItensVenda.Columns.Add(colDescontoItem);

            // 🔹 Coluna Subtotal - Formato moeda
            var colSubtotal = new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            };
            dgvItensVenda.Columns.Add(colSubtotal);

            // 🔹 Configurações gerais do grid
            dgvItensVenda.AllowUserToAddRows = false;
            dgvItensVenda.AllowUserToDeleteRows = false;
            dgvItensVenda.ReadOnly = true;
            dgvItensVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensVenda.MultiSelect = false;
            dgvItensVenda.RowHeadersVisible = false;
        }
        private List<dynamic> ObterParcelasSelecionadas()
        {
            var lista = new List<dynamic>();

            foreach (DataGridViewRow row in dgvContasAReceber.Rows)
            {
                if (row.Cells["Selecionar"].Value is bool marcado && marcado)
                {
                    lista.Add(row.DataBoundItem);
                }
            }

            return lista;
        }
        private void CarregarContasAReceber()
        {
            var sql = new StringBuilder();
            sql.Append(@"
                   SELECT 
                    p.ParcelaID       AS ParcelaID,
                    p.VendaID         AS VendaID,
                    p.NumeroParcela   AS NumeroParcela,
                    c.Nome            AS NomeCliente,
                    v.DataVenda       AS DataVenda,
                    p.DataVencimento  AS DataVencimento,
                    p.ValorParcela    AS ValorParcela,
                    p.ValorRecebido   AS ValorRecebido,
                    (p.ValorParcela + p.Juros + p.Multa - p.ValorRecebido) AS Saldo,
                    p.Status          AS StatusParcela,
                    fp.FormaPgto      AS FormaPgto
                FROM Parcela p
                JOIN Venda v   ON v.VendaID   = p.VendaID
                JOIN Cliente c ON c.ClienteID = v.ClienteID
                LEFT JOIN FormaPgto fp ON fp.FormaPgtoID = v.FormaPgtoID
                WHERE 1 = 1
                 ");

            var param = new DynamicParameters();

            switch (cmbTipoPesquisa.Text)
            {
                case "Nome do Cliente":
                    if (!string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                    {
                        sql.Append(" AND c.Nome LIKE @Nome ");
                        param.Add("@Nome", $"%{txtNomeCliente.Text}%");
                    }
                    else
                    {
                        MessageBox.Show("Informe o nome do cliente.");
                        return;
                    }
                    break;

                case "Número da Venda":
                    if (!string.IsNullOrWhiteSpace(txtNumeroVenda.Text) && int.TryParse(txtNumeroVenda.Text, out int vendaId))
                    {
                        sql.Append(" AND v.VendaID = @VendaID ");
                        param.Add("@VendaID", vendaId);
                    }
                    else
                    {
                        MessageBox.Show("Informe um número de venda válido.");
                        return;
                    }
                    break;

                case "Data da Venda":
                    sql.Append(" AND date(v.DataVenda) = date(@DataVenda) ");
                    param.Add("@DataVenda", dtpVencInicial.Value.Date);
                    break;

                case "Período da Venda":
                    sql.Append(" AND v.DataVenda BETWEEN @Ini AND @Fim ");
                    param.Add("@Ini", dtpVencInicial.Value.Date);
                    param.Add("@Fim", dtpVencFinal.Value.Date.AddDays(1));
                    break;

                case "Vencimento":
                    sql.Append(" AND date(p.DataVencimento) = date(@Venc) ");
                    param.Add("@Venc", dtpVencInicial.Value.Date);
                    break;

                case "Período de Vencimento":
                    sql.Append(" AND p.DataVencimento BETWEEN @VencIni AND @VencFim ");
                    param.Add("@VencIni", dtpVencInicial.Value.Date);
                    param.Add("@VencFim", dtpVencFinal.Value.Date.AddDays(1));
                    break;

                case "Status da Parcela":
                    if (!string.IsNullOrWhiteSpace(cmbStatusParcela.Text))
                    {
                        sql.Append(" AND p.Status = @Status ");
                        param.Add("@Status", cmbStatusParcela.Text);
                    }
                    else
                    {
                        MessageBox.Show("Selecione um status da parcela.");
                        return;
                    }
                    break;
            }

            using var conn = Helpers.Conexao.Conex();

            var lista = conn.Query(sql.ToString(), param).ToList();
            dgvContasAReceber.DataSource = lista;
            ConfigurarGridContasAReceber();

            AtualizarTotalSelecionado();

            AtualizarResumo(lista);         // seu resumo antigo (em aberto, vencido, recebido)
            AtualizarTotalSelecionado();    // total das selecionadas
            AtualizarResumoGeral(lista);    // ← NOVO: resumo geral de pagas e a receber                                            
            AtualizarParcelasAtrasadasNoBanco();// Atualiza no banco as parcelas que ficaram atrasadas desde a última abertura
        }

        private void AtualizarResumo(IEnumerable<dynamic> dados)
        {
            decimal totalAberto = 0m;
            decimal totalVencido = 0m;
            decimal totalRecebido = 0m;

            foreach (var p in dados)
            {
                decimal valorRecebido = Convert.ToDecimal(p.ValorRecebido);
                decimal saldo = Convert.ToDecimal(p.Saldo);

                totalRecebido += valorRecebido;

                if (p.StatusParcela == "Pendente" || p.StatusParcela == "Parcialmente Paga")
                    totalAberto += saldo;

                if (p.StatusParcela == "Atrasada")
                    totalVencido += saldo;
            }

            txtTotalVencido.Text = totalVencido.ToString("C2");
        }
        private void AtualizarCamposPorTipoPesquisa()
        {
            // Esconde todos os controles
            lblNomeCliente.Visible = false;
            txtNomeCliente.Visible = false;
            lblNumeroVenda.Visible = false;
            txtNumeroVenda.Visible = false;
            lblVenctoInicial.Visible = false;
            dtpVencInicial.Visible = false;
            lblVenctoFinal.Visible = false;
            dtpVencFinal.Visible = false;
            lblStatusParcela.Visible = false;
            cmbStatusParcela.Visible = false;

            // Limpa valores opcionais
            txtNomeCliente.Clear();
            txtNumeroVenda.Clear();

            switch (cmbTipoPesquisa.Text)
            {
                case "Todos":
                    // Nenhum filtro adicional
                    break;

                case "Nome do Cliente":
                    txtNomeCliente.Visible = true;
                    lblNomeCliente.Visible = true;
                    txtNomeCliente.Enabled = true;
                    txtNomeCliente.Focus();
                    btnPesquisar.Location = new Point(498, 21);
                    btnLimparFiltro.Location = new Point(595, 21);
                    break;

                case "Número da Venda":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    txtNumeroVenda.Visible = true;
                    lblNumeroVenda.Visible = true;
                    txtNumeroVenda.Focus();
                    btnPesquisar.Location = new Point(248, 21);
                    btnLimparFiltro.Location = new Point(345, 21);
                    break;

                case "Data da Venda":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    dtpVencInicial.Visible = true;
                    lblVenctoInicial.Visible = true;

                    btnPesquisar.Location = new Point(302, 21);
                    btnLimparFiltro.Location = new Point(399, 21);

                    break;

                case "Período da Venda":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    lblVenctoInicial.Visible = true;
                    dtpVencInicial.Visible = true;
                    lblVenctoFinal.Visible = true;
                    dtpVencFinal.Visible = true;
                    btnPesquisar.Location = new Point(399, 21);
                    btnLimparFiltro.Location = new Point(496, 21);
                    break;

                case "Vencimento":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    lblVenctoInicial.Visible = true;
                    dtpVencInicial.Visible = true;
                    btnPesquisar.Location = new Point(302, 21);
                    btnLimparFiltro.Location = new Point(399, 21);
                    break;

                case "Período de Vencimento":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    lblVenctoInicial.Visible = true;
                    dtpVencInicial.Visible = true;
                    lblVenctoFinal.Visible = true;
                    dtpVencFinal.Visible = true;
                    btnPesquisar.Location = new Point(399, 21);
                    btnLimparFiltro.Location = new Point(496, 21);
                    break;

                case "Status da Parcela":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    lblStatusParcela.Visible = true;
                    cmbStatusParcela.Visible = true;
                    btnPesquisar.Location = new Point(302, 21);
                    btnLimparFiltro.Location = new Point(399, 21);
                    break;
            }
        }

        private void btnBaixarParcela_Click(object sender, EventArgs e)
        {
            using var frm = new FrmBaixarParcela();
            var selecionadas = ObterParcelasSelecionadas();

            if (selecionadas.Count == 0)
            {
                MessageBox.Show("Selecione ao menos uma parcela.");
                return;
            }

            // 🔹 Soma geral
            decimal totalParcelas = selecionadas.Select(p => (decimal)p.ValorParcela).Sum();
            decimal totalRecebido = selecionadas.Select(p => (decimal)p.ValorRecebido).Sum();
            decimal saldoTotal = selecionadas.Select(p => (decimal)p.Saldo).Sum();

            // Nome do cliente (sempre único no seu fluxo)
            var nomeCliente = Convert.ToString(selecionadas[0].NomeCliente) ?? string.Empty;

            // 🔹 Lista de IDs
            var parcelasIds = selecionadas.Select(p => (long)Convert.ToInt64(p.ParcelaID)).ToList();
            // 🔹 Nome cliente (se for 1)
            // TextBox sempre mostra o nome do cliente
            frm.txtClienteNome.Text = Convert.ToString(selecionadas[0].NomeCliente);

            // StatusStrip varia conforme a quantidade de parcelas
            frm.lblInfo.Text = selecionadas.Count == 1 ? Convert.ToString(selecionadas[0].NomeCliente) : "Múltiplas parcelas selecionadas";

            // Chamada corrigida (ordem igual à assinatura):
            frm.CarregarDados(
                selecionadas,   // List<dynamic> primeiro
                nomeCliente,    // string depois
                totalParcelas,
                totalRecebido,
                saldoTotal
            );
            if (frm.ShowDialog() == DialogResult.OK)
                CarregarContasAReceber();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarContasAReceber();
        }

        private void FrmContasAReceber_Load(object sender, EventArgs e)
        {
            cmbTipoPesquisa.SelectedIndex = 0;
            ConfigurarGridContasAReceber();

            // 🔹 CONFIGURA O GRID DE ITENS TAMBÉM
            ConfigurarGridItensVenda();

            AtualizarParcelasAtrasadasNoBanco();
            txtNomeCliente.Visible = false;
            lblNomeCliente.Visible = false;
            txtNomeCliente.Enabled = false;
            AtualizarParcelasAtrasadasNoBanco(); // ← Atualiza ao abrir          
        }

        private void cmbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarCamposPorTipoPesquisa();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            cmbTipoPesquisa.SelectedIndex = 0;
            cmbStatusParcela.SelectedIndex = 0;
            AtualizarCamposPorTipoPesquisa();
            CarregarContasAReceber(); // vai chamar AtualizarResumoGeral automaticamente
            AtualizarCamposPorTipoPesquisa();
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
                        }
                    }
                }
                finally
                {
                    bloqueiaPesquisa = false;
                }
            }));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvContasAReceber_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Proteger índices inválidos
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var coluna = dgvContasAReceber.Columns[e.ColumnIndex].DataPropertyName;

            // 1) Datas: formatar dd/MM/yyyy
            if ((coluna == "DataVenda" || coluna == "DataVencimento") && e.Value != null)
            {
                if (e.Value is DateTime dt)
                {
                    e.Value = dt.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
                else if (DateTime.TryParse(e.Value.ToString(), out var parsed))
                {
                    e.Value = parsed.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }

            // 2) Colunas monetárias: formatar como moeda e alinhar à direita
            else if (coluna == "ValorParcela" ||
                     coluna == "ValorRecebido" ||
                     coluna == "Saldo" ||
                     coluna == "Juros" ||
                     coluna == "Multa")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valor))
                {
                    e.Value = valor.ToString("C2"); // Ex: R$ 1.000,00
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Regular); // padrão
                    e.FormattingApplied = true;

                    // Cores específicas apenas para a coluna Saldo
                    if (coluna == "Saldo")
                    {
                        if (valor < 0m)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Bold);
                        }
                        else if (valor == 0m)
                        {
                            e.CellStyle.ForeColor = Color.Gray;
                        }
                        else
                        {
                            e.CellStyle.ForeColor = Color.Black; // ou ForestGreen se preferir positivo destacado
                        }
                    }
                }
            }

            // 3) Status da Parcela: cores
            else if (coluna == "StatusParcela" && e.Value != null)
            {
                var status = e.Value.ToString().Trim();

                switch (status.ToUpperInvariant())
                {
                    case "PAGA":
                        e.CellStyle.ForeColor = Color.ForestGreen;
                        e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Bold);
                        break;

                    case "ATRASADA":
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Bold);
                        break;

                    case "PARCIALMENTE PAGA":
                        e.CellStyle.ForeColor = Color.Blue;
                        e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Italic);
                        break;

                    case "PENDENTE":
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    case "CANCELADA":
                        e.CellStyle.ForeColor = Color.DarkRed;
                        e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Strikeout);
                        break;

                    // Adicione outros status se necessário (Renegociada, Em Cobrança, etc.)
                    default:
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
            else if (coluna == "Observacao" && e.Value != null)
            {
                e.Value = e.Value.ToString().Replace("\r\n", " | ");
                e.CellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void btnEstornarPagamento_Click(object sender, EventArgs e)
        {
            var selecionadas = ObterParcelasSelecionadas();

            // 🔴 CORREÇÃO: Verifica se há exatamente UMA parcela selecionada
            if (selecionadas.Count == 0)
            {
                MessageBox.Show("Selecione uma parcela para estornar.", "Atenção",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔴 NOVA VERIFICAÇÃO: Bloqueia se mais de uma parcela estiver selecionada
            if (selecionadas.Count > 1)
            {
                MessageBox.Show("Selecione apenas UMA parcela para estornar.", "Atenção",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agora temos certeza que é apenas uma parcela
            var parcela = selecionadas.First();

            // Verifica se a parcela tem valor recebido > 0
            if ((decimal)parcela.ValorRecebido <= 0)
            {
                MessageBox.Show("Esta parcela não possui pagamentos para estornar.", "Atenção",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Form para informar o valor e motivo
            using (var frm = new FrmEstornarPagamento())
            {
                // 🔴 AJUSTE: Passa apenas o ID da única parcela
                frm.CarregarDados(
                    new List<long> { (long)parcela.ParcelaID },
                    parcela.NomeCliente ?? "Cliente"
                );

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var bll = new ParcelaBLL();

                        // 🔴 AGORA ESTORNA APENAS A PARCELA ÚNICA
                        bll.EstornarPagamento(
                            (long)parcela.ParcelaID,
                            frm.ValorEstorno,
                            frm.Motivo
                        );

                        MessageBox.Show("Estorno realizado com sucesso!", "Sucesso",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarContasAReceber(); // atualiza o grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao estornar: " + ex.Message, "Erro",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AtualizarTotalSelecionado()
        {
            var selecionadas = ObterParcelasSelecionadas();

            decimal totalSelecionado = 0m;

            foreach (var p in selecionadas)
            {
                // aqui você decide o que somar: ValorParcela, Saldo ou outro campo
                totalSelecionado += Convert.ToDecimal(p.Saldo);
            }

            lblTotalSelecionado.Text = totalSelecionado.ToString("C2");
        }

        private void dgvContasAReceber_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvContasAReceber.IsCurrentCellDirty) { dgvContasAReceber.CommitEdit(DataGridViewDataErrorContexts.Commit); }
        }

        private void dgvContasAReceber_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvContasAReceber.Columns[e.ColumnIndex].Name == "Selecionar") { AtualizarTotalSelecionado(); }
        }
        private void AtualizarResumoGeral(IEnumerable<dynamic> dados)
        {
            // Contas a receber: pendentes, parciais, atrasadas, etc.
            var aReceber = dados.Where(p =>
                p.StatusParcela == "Pendente" ||
                p.StatusParcela == "Parcialmente Paga" ||
                p.StatusParcela == "Atrasada" ||
                p.StatusParcela == "Em Cobrança" ||
                p.StatusParcela == "Renegociada");

            int qtdAReceber = aReceber.Count();
            decimal totalAReceber = aReceber.Sum(p =>
            {
                if (p.Saldo == null) return 0m;
                return p.Saldo is decimal d ? d : Convert.ToDecimal(p.Saldo);
            });

            // Contas pagas: pagas ou parcialmente pagas
            var pagas = dados.Where(p =>
                p.StatusParcela == "Paga" ||
                p.StatusParcela == "Parcialmente Paga");

            int qtdPagas = pagas.Count();
            decimal totalPagas = pagas.Sum(p =>
            {
                if (p.ValorRecebido == null) return 0m;
                return p.ValorRecebido is decimal d ? d : Convert.ToDecimal(p.ValorRecebido);
            });

            //// Atualiza os labels

            lblQtdContasPagas.Text = qtdPagas.ToString();
            lblTotalContasPagas.Text = totalPagas.ToString("C2");

            lblQtdeContasReceber.Text = qtdAReceber.ToString();
            lblTotalContasReceber.Text = totalAReceber.ToString("C2");

            // Cores
            lblTotalContasReceber.ForeColor = totalAReceber > 0m ? Color.Red : Color.Gray;
            lblTotalContasPagas.ForeColor = Color.ForestGreen;

        }

        private void AtualizarParcelasAtrasadasNoBanco()
        {
            try
            {
                const string sql = @"  UPDATE Parcela SET Status = 'Atrasada'
            WHERE date(DataVencimento) < date('now') AND Status NOT IN ('Paga', 'Parcialmente Paga', 'Cancelada', 'Atrasada')";

                using var conn = Helpers.Conexao.Conex();
                conn.Execute(sql);
            }
            catch (Exception ex)
            {
                // Log silencioso ou opcional
                System.Diagnostics.Debug.WriteLine("Erro ao atualizar parcelas atrasadas: " + ex.Message);
            }
        }
        private void CarregarVenda(long vendaId)
        {
            var venda = _vendaBll.ObterVendaPorId((int)vendaId);

            if (venda == null)
            {
                LimparAreaVenda();
                lblCliente.Text = "Venda não encontrada";
                return;
            }

            // 🔴 CORREÇÃO: Sempre usa o vendaId que veio do grid
            lblVendaID.Text = vendaId.ToString();

            // Busca nome do cliente se necessário
            if (string.IsNullOrEmpty(venda.NomeCliente) && venda.ClienteID > 0)
            {
                string query = "SELECT Nome FROM Cliente WHERE ClienteID = @id";
                venda.NomeCliente = Utilitario.PesquisarPorCodigoRetornarNome(query, "id", venda.ClienteID);
            }

            lblCliente.Text = venda.NomeCliente ?? "Cliente não encontrado";
            lblDataVenda.Text = venda.DataVenda.ToShortDateString();
            lblTotalVenda.Text = venda.ValorTotal.ToString("C2");
        }
        private void BuscarNomeCliente(long clienteId)
        {
            string query = "SELECT Nome FROM Cliente WHERE ClienteID = @parametro";
            lblCliente.Text = Utilitario.PesquisarPorCodigoRetornarNome(query, "parametro", clienteId);
        }

        //private void BuscarNomeCliente(long clienteId)
        //{
        //    string query = "SELECT Nome AS Estado FROM Cliente WHERE ClienteID = @parametro";
        //    //string query, string nomeParametro, object parametro
        //    lblCliente.Text = Utilitario.PesquisarPorCodigoRetornarNome(query, "parametro", clienteId);
        //}
        private void AplicarFormatacaoItensVenda()
        {
            // Garante que os valores monetários sejam formatados corretamente
            foreach (DataGridViewRow row in dgvItensVenda.Rows)
            {
                // Formata PrecoUnitario
                if (row.Cells["PrecoUnitario"].Value != null &&
                    decimal.TryParse(row.Cells["PrecoUnitario"].Value.ToString(), out decimal preco))
                {
                    row.Cells["PrecoUnitario"].Value = preco;
                }

                // Formata Subtotal
                if (row.Cells["Subtotal"].Value != null &&
                    decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out decimal subtotal))
                {
                    row.Cells["Subtotal"].Value = subtotal;
                }

                // Formata DescontoItem
                if (row.Cells["DescontoItem"].Value != null &&
                    decimal.TryParse(row.Cells["DescontoItem"].Value.ToString(), out decimal desconto))
                {
                    row.Cells["DescontoItem"].Value = desconto;
                }
            }
        }
        private void CarregarItensVenda(int vendaId)
        {
            var itens = _itensVendaBll.ListarItensPorVenda(vendaId);

            // Configura o grid antes de atribuir o DataSource
            ConfigurarGridItensVenda();

            dgvItensVenda.DataSource = itens;

            // 🔹 Aplica formatação personalizada
            AplicarFormatacaoItensVenda();
        }

        private void dgvContasAReceber_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContasAReceber.CurrentRow == null)
                return;

            var data = dgvContasAReceber.CurrentRow.DataBoundItem;
            if (data == null)
                return;

            var row = (IDictionary<string, object>)data;

            if (!row.ContainsKey("VendaID") || row["VendaID"] == null)
            {
                LimparAreaVenda();
                return;
            }

            // Convertendo para long corretamente
            long vendaId = Convert.ToInt64(row["VendaID"]);

            if (vendaId <= 0)
            {
                LimparAreaVenda();
                return;
            }

            CarregarVenda(vendaId); // Já é long
            CarregarItensVenda((int)vendaId); // Converte para int se necessário
        }
        private void LimparAreaVenda()
        {
            lblNumeroVenda.Text = "-";
            lblDataVenda.Text = "-";
            lblCliente.Text = "-";
            lblTotalVenda.Text = "R$ 0,00";

            dgvItensVenda.DataSource = null;

            // 🔹 Opcional: Reconfigura o grid quando limpo
            ConfigurarGridItensVenda();
        }

        private void dgvItensVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var coluna = dgvItensVenda.Columns[e.ColumnIndex].Name;

            // Formata colunas monetárias
            if (coluna == "PrecoUnitario" || coluna == "Subtotal" || coluna == "DescontoItem")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    e.Value = valor.ToString("C2");
                    e.FormattingApplied = true;

                    // Destaque para descontos (opcional)
                    if (coluna == "DescontoItem" && valor > 0)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font(dgvItensVenda.Font, FontStyle.Regular);
                    }
                }
            }
        }
        private bool VerificarCheckboxesMarcados()
        {
            foreach (DataGridViewRow row in dgvContasAReceber.Rows)
            {
                var cell = row.Cells["Selecionar"];
                if (cell != null && cell.Value != null)
                {
                    if (cell.Value is bool boolValue && boolValue)
                        return true;

                    if (cell.Value.ToString() == "True")
                        return true;
                }
            }
            return false;
        }
        private void btnExtratoRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se há checkbox marcado
                bool temCheckboxMarcado = false;

                foreach (DataGridViewRow row in dgvContasAReceber.Rows)
                {
                    if (row.Cells["Selecionar"].Value is bool marcado && marcado)
                    {
                        temCheckboxMarcado = true;
                        break;
                    }
                }

                // Verifica se há linha selecionada (CurrentRow)
                bool temLinhaSelecionada = (dgvContasAReceber.CurrentRow != null);

                // Se não tem nenhum dos dois, mostra mensagem
                if (!temCheckboxMarcado && !temLinhaSelecionada)
                {
                    MessageBox.Show("Para gerar extrato: selecione uma linha.\nPara gerar recibo: marque o checkbox das parcelas.",
                                   "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // SEMPRE abre o formulário de opções
                using (var frmOpcoes = new FrmOpcoesExtrato())
                {
                    // Desabilita os botões que não estão disponíveis
                    // Supondo que seus botões no FrmOpcoesExtrato são públicos ou você tem acesso a eles

                    // Se não tem linha selecionada, desabilita Extrato
                    if (!temLinhaSelecionada)
                    {
                        // Desabilita o botão de extrato
                        var controles = frmOpcoes.Controls.Find("btnExtrato", true);
                        if (controles.Length > 0 && controles[0] is Button btnExtrato)
                        {
                            btnExtrato.Enabled = false;
                            btnExtrato.Text = "Extrato (selecione uma linha primeiro)";
                        }
                    }

                    // Se não tem checkbox marcado, desabilita Recibo
                    if (!temCheckboxMarcado)
                    {
                        // Desabilita o botão de recibo
                        var controles = frmOpcoes.Controls.Find("btnRecibo", true);
                        if (controles.Length > 0 && controles[0] is Button btnRecibo)
                        {
                            btnRecibo.Enabled = false;
                            btnRecibo.Text = "Recibo (marque o checkbox primeiro)";
                        }
                    }

                    var resultado = frmOpcoes.ShowDialog();

                    if (resultado == DialogResult.Yes && temLinhaSelecionada)
                    {
                        GerarExtratoCompleto();
                    }
                    else if (resultado == DialogResult.No && temCheckboxMarcado)
                    {
                        GerarReciboParcelas();
                    }
                    else if ((resultado == DialogResult.Yes && !temLinhaSelecionada) ||
                             (resultado == DialogResult.No && !temCheckboxMarcado))
                    {
                        MessageBox.Show("Esta opção não está disponível no momento.", "Aviso",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    // Se for DialogResult.Cancel, não faz nada
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //// Opção 1: Se tem checkbox marcado, pergunta se quer recibo
            //bool temCheckboxMarcado = VerificarCheckboxesMarcados();

            //// Opção 2: Se tem linha selecionada, pergunta se quer extrato
            //bool temLinhaSelecionada = (dgvContasAReceber.CurrentRow != null);

            //if (temCheckboxMarcado && temLinhaSelecionada)
            //{
            //    // Ambos disponíveis - mostra formulário completo
            //    using (var frm = new FrmOpcoesExtrato())
            //    {
            //        if (frm.ShowDialog() == DialogResult.Yes)
            //            GerarExtratoCompleto();
            //        else if (frm.DialogResult == DialogResult.No)
            //            GerarReciboParcelas();
            //    }
            //}
            //else if (temCheckboxMarcado)
            //{
            //    // Só pode gerar recibo
            //    if (MessageBox.Show("Deseja gerar recibo das parcelas selecionadas?", "Recibo",
            //                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        GerarReciboParcelas();
            //    }
            //}
            //else if (temLinhaSelecionada)
            //{
            //    // Só pode gerar extrato
            //    if (MessageBox.Show("Deseja gerar extrato completo do cliente?", "Extrato",
            //                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        GerarExtratoCompleto();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Selecione uma linha para extrato ou marque parcelas para recibo.",
            //                   "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        private ExtratoCliente ObterExtratoCliente()
        {
            try
            {
                // Obter o cliente selecionado no grid (CurrentRow)
                if (dgvContasAReceber.CurrentRow == null)
                {
                    MessageBox.Show("Selecione uma linha para gerar o extrato.", "Atenção",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                var data = dgvContasAReceber.CurrentRow.DataBoundItem;
                if (data == null)
                {
                    MessageBox.Show("Não foi possível obter dados da linha selecionada.", "Erro",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                var row = (IDictionary<string, object>)data;

                if (!row.ContainsKey("VendaID") || row["VendaID"] == null)
                {
                    MessageBox.Show("A linha selecionada não possui ID de venda.", "Erro",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                long vendaId = Convert.ToInt64(row["VendaID"]);
                long clienteId = 0;

                // Método 1: Tenta pegar o ClienteID da linha
                if (row.ContainsKey("ClienteID") && row["ClienteID"] != null)
                {
                    clienteId = Convert.ToInt64(row["ClienteID"]);
                }
                // Método 2: Tenta pegar de coluna alternativa
                else if (row.ContainsKey("IDCliente") && row["IDCliente"] != null)
                {
                    clienteId = Convert.ToInt64(row["IDCliente"]);
                }
                else
                {
                    // Método 3: Busca no banco pela venda
                    using (var connTemp = Helpers.Conexao.Conex())
                    {
                        var result = connTemp.ExecuteScalar<long?>(
                            "SELECT ClienteID FROM Venda WHERE VendaID = @VendaID",
                            new { VendaID = vendaId });

                        if (result.HasValue)
                            clienteId = result.Value;
                        else
                        {
                            MessageBox.Show("Não foi possível identificar o cliente da venda.", "Erro",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                    }
                }

                // Buscar informações completas do cliente
                using (var conn = Helpers.Conexao.Conex())
                {
                    var extrato = new ExtratoCliente();

                    // Buscar dados do cliente
                    var cliente = conn.QueryFirstOrDefault(@"
                SELECT 
                    ClienteID, 
                    Nome, 
                    Cpf, 
                    Cnpj, 
                    Logradouro, 
                    Telefone,
                    Email
                FROM Cliente 
                WHERE ClienteID = @ClienteID",
                        new { ClienteID = clienteId });

                    if (cliente != null)
                    {
                        extrato.ClienteID = cliente.ClienteID;
                        extrato.NomeCliente = cliente.Nome;

                        // Cpf ou Cnpj (campos separados)
                        extrato.CPF_CNPJ = !string.IsNullOrEmpty(cliente.Cnpj) ? cliente.Cnpj : cliente.Cpf;

                        extrato.Endereco = cliente.Endereco;
                        extrato.Telefone = cliente.Telefone;
                    }
                    else
                    {
                        MessageBox.Show($"Cliente ID {clienteId} não encontrado no banco de dados.", "Erro",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    // Buscar todas as parcelas do cliente
                    var parcelas = conn.Query<ParcelaExtrato>(@"
                SELECT 
                    p.ParcelaID,
                    p.VendaID,
                    p.NumeroParcela,
                    v.DataVenda,
                    p.DataVencimento,
                    p.DataPagamento,
                    p.ValorParcela,
                    p.ValorRecebido,
                    p.Juros,
                    p.Multa,
                    (p.ValorParcela + p.Juros + p.Multa - p.ValorRecebido) as Saldo,
                    p.Status,
                    fp.FormaPgto as FormaPagamento
                FROM Parcela p
                JOIN Venda v ON v.VendaID = p.VendaID
                LEFT JOIN FormaPgto fp ON fp.FormaPgtoID = v.FormaPgtoID
                WHERE v.ClienteID = @ClienteID
                ORDER BY v.DataVenda DESC, p.NumeroParcela",
                        new { ClienteID = clienteId }).ToList();

                    foreach (var parcela in parcelas)
                    {
                        var item = new ItemExtrato
                        {
                            VendaID = parcela.VendaID,
                            NumeroParcela = parcela.NumeroParcela,
                            DataVenda = parcela.DataVenda,
                            DataVencimento = parcela.DataVencimento,
                            DataPagamento = parcela.DataPagamento,
                            ValorParcela = parcela.ValorParcela,
                            ValorRecebido = parcela.ValorRecebido,
                            Juros = parcela.Juros,
                            Desconto = 0,
                            Saldo = parcela.Saldo,
                            Status = parcela.Status ?? "",
                            FormaPagamento = parcela.FormaPagamento ?? "",
                            Descricao = $"Venda {parcela.VendaID} - Parcela {parcela.NumeroParcela}"
                        };

                        extrato.ItensExtrato.Add(item);

                        // Calcular totais
                        if (item.Status == "Paga")
                            extrato.TotalPago += item.ValorRecebido;
                        else if (item.Status != "Cancelada")
                            extrato.TotalDevendo += item.Saldo;
                    }

                    extrato.SaldoAtual = extrato.TotalDevendo;

                    return extrato;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter extrato: {ex.Message}", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void GerarExtratoCompleto()
        {
            try
            {
                if (dgvContasAReceber.CurrentRow == null)
                {
                    MessageBox.Show("Selecione uma linha para gerar o extrato do cliente.", "Atenção",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var extrato = ObterExtratoCliente();

                if (extrato == null)
                {
                    MessageBox.Show("Não foi possível obter dados do cliente.", "Erro",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (extrato.ItensExtrato.Count == 0)
                {
                    MessageBox.Show("Não há parcelas para este cliente.", "Informação",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF Files|*.pdf";
                    saveDialog.Title = "Salvar Extrato";

                    // Limpa caracteres inválidos do nome do arquivo
                    string nomeClienteLimpo = RemoveCaracteresInvalidos(extrato.NomeCliente);
                    saveDialog.FileName = $"Extrato_{nomeClienteLimpo}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Gerar o PDF
                        GVC.UTIL.PDFGenerator.GerarExtratoPDF(extrato, saveDialog.FileName);

                        // Mensagem de sucesso
                        DialogResult resultado = MessageBox.Show(
                            $"Extrato gerado com sucesso!\n\n" +
                            $"Arquivo: {Path.GetFileName(saveDialog.FileName)}\n" +
                            $"Pasta: {Path.GetDirectoryName(saveDialog.FileName)}\n\n" +
                            $"Deseja abrir o arquivo agora?",
                            "Sucesso",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                        if (resultado == DialogResult.Yes)
                        {
                            // Tenta abrir o PDF
                            if (AbrirPDF(saveDialog.FileName))
                            {
                                // Sucesso ao abrir
                            }
                            else
                            {
                                // Se não conseguiu abrir, mostra a pasta
                                AbrirPastaContendoArquivo(saveDialog.FileName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar extrato: {ex.Message}",
                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string RemoveCaracteresInvalidos(string nomeArquivo)
        {
            if (string.IsNullOrEmpty(nomeArquivo))
                return "Cliente";

            // Remove caracteres inválidos para nome de arquivo
            char[] caracteresInvalidos = Path.GetInvalidFileNameChars();
            foreach (char c in caracteresInvalidos)
            {
                nomeArquivo = nomeArquivo.Replace(c.ToString(), "_");
            }

            // Remove espaços extras e limita o tamanho
            nomeArquivo = nomeArquivo.Trim();
            if (nomeArquivo.Length > 50)
                nomeArquivo = nomeArquivo.Substring(0, 50);

            return nomeArquivo;
        }

        private bool AbrirPDF(string caminhoArquivo)
        {
            try
            {
                // Método 1: Usar Process.Start com UseShellExecute
                Process.Start(new ProcessStartInfo
                {
                    FileName = caminhoArquivo,
                    UseShellExecute = true
                });
                return true;
            }
            catch
            {
                try
                {
                    // Método 2: Tentar com o programa padrão do Windows
                    Process.Start("rundll32.exe", "shell32.dll,OpenAs_RunDLL " + caminhoArquivo);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        private void AbrirPastaContendoArquivo(string caminhoArquivo)
        {
            try
            {
                string pasta = Path.GetDirectoryName(caminhoArquivo);

                if (Directory.Exists(pasta))
                {
                    // Abre a pasta no explorador
                    Process.Start("explorer.exe", pasta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir a pasta: {ex.Message}",
                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GerarReciboParcelas()
        {
            try
            {
                var parcelasSelecionadas = ObterParcelasSelecionadas();

                if (parcelasSelecionadas.Count == 0)
                {
                    MessageBox.Show("Selecione pelo menos uma parcela marcando o checkbox para gerar o recibo.",
                                  "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Para recibo, obtém o extrato do cliente da primeira parcela selecionada
                if (parcelasSelecionadas.Count > 0)
                {
                    var primeiraParcela = parcelasSelecionadas[0];
                    var dict = (IDictionary<string, object>)primeiraParcela;

                    if (!dict.ContainsKey("VendaID") || dict["VendaID"] == null)
                    {
                        MessageBox.Show("Não foi possível identificar a venda.", "Erro",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    long vendaId = Convert.ToInt64(dict["VendaID"]);

                    // Busca o extrato do cliente
                    var extrato = ObterExtratoCliente();

                    if (extrato == null)
                    {
                        MessageBox.Show("Não foi possível obter dados do cliente.", "Erro",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SaveFileDialog saveDialog = new SaveFileDialog())
                    {
                        saveDialog.Filter = "PDF Files|*.pdf";
                        saveDialog.Title = "Salvar Recibo";

                        string nomeClienteLimpo = RemoveCaracteresInvalidos(extrato.NomeCliente);
                        saveDialog.FileName = $"Recibo_{nomeClienteLimpo}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            GVC.UTIL.PDFGenerator.GerarReciboPDF(extrato, parcelasSelecionadas, saveDialog.FileName);

                            // Mensagem de sucesso
                            DialogResult resultado = MessageBox.Show(
                                $"Recibo gerado com sucesso!\n\n" +
                                $"Arquivo: {Path.GetFileName(saveDialog.FileName)}\n" +
                                $"Pasta: {Path.GetDirectoryName(saveDialog.FileName)}\n\n" +
                                $"Deseja abrir o arquivo agora?",
                                "Sucesso",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);

                            if (resultado == DialogResult.Yes)
                            {
                                // Tenta abrir o PDF
                                if (AbrirPDF(saveDialog.FileName))
                                {
                                    // Sucesso ao abrir
                                }
                                else
                                {
                                    // Se não conseguiu abrir, mostra a pasta
                                    AbrirPastaContendoArquivo(saveDialog.FileName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar recibo: {ex.Message}",
                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}
