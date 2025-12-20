using Dapper;
using GVC.BLL;
using GVC.MODEL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void ConfigurarGridParcelas()
        {
            dgvParcelas.AutoGenerateColumns = false;
            dgvParcelas.Columns.Clear();

            var chk = new DataGridViewCheckBoxColumn
            {
                Name = "Selecionar",
                HeaderText = "",
                Width = 30,
            };
            dgvParcelas.Columns.Add(chk);

            var colParcelaID = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ParcelaID",
                HeaderText = "ID",
                Width = 60,
                Visible = false
            };
            dgvParcelas.Columns.Add(colParcelaID); // Coluna ID (oculta)

            var colVendaID = new DataGridViewTextBoxColumn
            {
                Name = "VendaID",               // OBRIGATÓRIO
                DataPropertyName = "VendaID",
                HeaderText = "IDVenda",
                Width = 60,
                Visible = false
            };

            dgvParcelas.Columns.Add(colVendaID);

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
            dgvParcelas.Columns.Add(colParcela);

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeCliente",
                HeaderText = "Cliente",
                Width = 200,
                ValueType = typeof(string)
            });

            // Datas: assegure o tipo DateTime e o formato
            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVenda",
                HeaderText = "Data Venda",
                Width = 100,
                ValueType = typeof(DateTime),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVencimento",
                HeaderText = "Vencimento",
                Width = 100,
                ValueType = typeof(DateTime),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            // Valores: tipo decimal e formato moeda
            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorParcela",
                HeaderText = "Valor Parcela",
                Width = 100,
                ValueType = typeof(long),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorRecebido",
                HeaderText = "Recebido",
                Width = 100,
                ValueType = typeof(long),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Saldo",
                HeaderText = "Saldo",
                Width = 100,
                ValueType = typeof(long),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusParcela",
                HeaderText = "Status",
                Width = 90,
                ValueType = typeof(string)
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FormaPgto",
                HeaderText = "Forma Pgto",
                Width = 120,
                ValueType = typeof(string)
            });
            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Observacao",
                HeaderText = "Observações",
                Width = 200,
                ValueType = typeof(string)
            });

            // Opcional: estilo geral
            dgvParcelas.AllowUserToAddRows = false;
            dgvParcelas.AllowUserToDeleteRows = false;
            dgvParcelas.ReadOnly = true;
            dgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcelas.MultiSelect = false;
            dgvParcelas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgvParcelas.ReadOnly = false; // libera edição no grid inteiro

            foreach (DataGridViewColumn col in dgvParcelas.Columns)
            {
                if (col.Name != "Selecionar")
                    col.ReadOnly = true; // bloqueia todas as outras colunas
            }
        }

        private List<dynamic> ObterParcelasSelecionadas()
        {
            var lista = new List<dynamic>();

            foreach (DataGridViewRow row in dgvParcelas.Rows)
            {
                if (row.Cells["Selecionar"].Value is bool marcado && marcado)
                {
                    lista.Add(row.DataBoundItem);
                }
            }

            return lista;
        }
        private void CarregarParcelas()
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
            dgvParcelas.DataSource = lista;
            ConfigurarGridParcelas();

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
                CarregarParcelas();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarParcelas();
        }

        private void FrmContasAReceber_Load(object sender, EventArgs e)
        {
            cmbTipoPesquisa.SelectedIndex = 0;
            ConfigurarGridParcelas();
            AtualizarParcelasAtrasadasNoBanco(); // ← Atualiza ao abrir
            txtNomeCliente.Visible = false;
            lblNomeCliente.Visible = false;
            txtNomeCliente.Enabled = false;
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
            CarregarParcelas(); // vai chamar AtualizarResumoGeral automaticamente
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

        private void dgvParcelas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Proteger índices inválidos
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var coluna = dgvParcelas.Columns[e.ColumnIndex].DataPropertyName;

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
                    e.CellStyle.Font = new Font(dgvParcelas.Font, FontStyle.Regular); // padrão
                    e.FormattingApplied = true;

                    // Cores específicas apenas para a coluna Saldo
                    if (coluna == "Saldo")
                    {
                        if (valor < 0m)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.Font = new Font(dgvParcelas.Font, FontStyle.Bold);
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
                        e.CellStyle.Font = new Font(dgvParcelas.Font, FontStyle.Bold);
                        break;

                    case "ATRASADA":
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        e.CellStyle.Font = new Font(dgvParcelas.Font, FontStyle.Bold);
                        break;

                    case "PARCIALMENTE PAGA":
                        e.CellStyle.ForeColor = Color.Blue;
                        e.CellStyle.Font = new Font(dgvParcelas.Font, FontStyle.Italic);
                        break;

                    case "PENDENTE":
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    case "CANCELADA":
                        e.CellStyle.ForeColor = Color.DarkRed;
                        e.CellStyle.Font = new Font(dgvParcelas.Font, FontStyle.Strikeout);
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
                        CarregarParcelas(); // atualiza o grid
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

        private void dgvParcelas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvParcelas.IsCurrentCellDirty) { dgvParcelas.CommitEdit(DataGridViewDataErrorContexts.Commit); }
        }

        private void dgvParcelas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvParcelas.Columns[e.ColumnIndex].Name == "Selecionar") { AtualizarTotalSelecionado(); }
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
                const string sql = @"
            UPDATE Parcela
            SET Status = 'Atrasada'
            WHERE date(DataVencimento) < date('now')
              AND Status NOT IN ('Paga', 'Parcialmente Paga', 'Cancelada', 'Atrasada')";

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
                return;
            }

            lblNumeroVenda.Text = venda.VendaID.ToString();
            lblCliente.Text = venda.NomeCliente;
            lblDataVenda.Text = venda.DataVenda.ToShortDateString();
            lblTotalVenda.Text = venda.ValorTotal.ToString("C2");
        }
      
        private void CarregarItensVenda(int vendaId)
        {
            var itens = _itensVendaBll.ListarItensPorVenda(vendaId);
            dgvItensVenda.DataSource = itens;
        }

        private void dgvParcelas_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvParcelas.CurrentRow == null)
                return;

            var data = dgvParcelas.CurrentRow.DataBoundItem;
            if (data == null)
                return;

            // DapperRow implementa IDictionary
            var row = (IDictionary<string, object>)data;

            if (!row.ContainsKey("VendaID") || row["VendaID"] == null)
            {
                LimparAreaVenda();
                return;
            }

            long vendaId = Convert.ToInt64(row["VendaID"]);

            if (vendaId <= 0)
            {
                LimparAreaVenda();
                return;
            }

            CarregarVenda((int)vendaId);
            CarregarItensVenda((int)vendaId);



        }
        private void LimparAreaVenda()
        {
            lblNumeroVenda.Text = "-";
            lblDataVenda.Text = "-";
            lblCliente.Text = "-";
            lblTotalVenda.Text = "R$ 0,00";

            dgvItensVenda.DataSource = null;
        }

    }
}
