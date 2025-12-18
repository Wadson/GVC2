
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Krypton.Toolkit;
using OfficeOpenXml;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Dapper;

namespace GVC.View
{
    public partial class FrmRelatorios : KryptonForm
    {
        public FrmRelatorios()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Ajuste se for comercial
        }

        public string clienteSelecionado { get; set; }

        private void CalcularTotalDataGrid()
        {
            try
            {
                decimal totalEmAberto = Utilitario.SomarColuna(dgvContasReceber, "SaldoRestante");
                decimal totalRecebido = Utilitario.SomarColuna(dgvContasReceber, "ValorRecebido");

                lblTotal.Text = $"R$ {totalEmAberto:N2}";
                lblTotalRecebido.Text = $"R$ {totalRecebido:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular total: " + ex.Message);
            }
        }

        private void PersonalizarDataGridView()
        {
            if (dgvContasReceber.Columns.Count == 0) return;

            var colunas = new (string nome, string titulo, bool visivel, string formato, DataGridViewContentAlignment alinhamento)[]
            {
                ("Nome", "Cliente", true, null, DataGridViewContentAlignment.MiddleLeft),
                ("NumeroParcela", "Parcela", true, null, DataGridViewContentAlignment.MiddleCenter),
                ("ValorParcela", "Valor Parcela", true, "N2", DataGridViewContentAlignment.MiddleRight),
                ("DataVencimento", "Data Vencimento", true, "d", DataGridViewContentAlignment.MiddleCenter),
                ("SaldoRestante", "Saldo Restante", true, "N2", DataGridViewContentAlignment.MiddleRight),
                ("ValorRecebido", "Valor Recebido", true, "N2", DataGridViewContentAlignment.MiddleRight),
                ("Pago", "Pago", true, null, DataGridViewContentAlignment.MiddleCenter),
                ("ParcelaID", null, false, null, DataGridViewContentAlignment.NotSet),
                ("VendaID", null, false, null, DataGridViewContentAlignment.NotSet),
                ("ClienteID", null, false, null, DataGridViewContentAlignment.NotSet)
            };

            foreach (var c in colunas)
            {
                if (dgvContasReceber.Columns.Contains(c.nome))
                {
                    var col = dgvContasReceber.Columns[c.nome];
                    if (c.titulo != null) col.HeaderText = c.titulo;
                    col.Visible = c.visivel;
                    if (c.formato != null) col.DefaultCellStyle.Format = c.formato;
                    if (c.alinhamento != DataGridViewContentAlignment.NotSet)
                        col.DefaultCellStyle.Alignment = c.alinhamento;

                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            // Cores
            if (dgvContasReceber.Columns.Contains("ValorParcela"))
                dgvContasReceber.Columns["ValorParcela"].DefaultCellStyle.BackColor = Color.LightGreen;
            if (dgvContasReceber.Columns.Contains("SaldoRestante"))
                dgvContasReceber.Columns["SaldoRestante"].DefaultCellStyle.BackColor = Color.LightGreen;
            if (dgvContasReceber.Columns.Contains("ValorRecebido"))
                dgvContasReceber.Columns["ValorRecebido"].DefaultCellStyle.BackColor = Color.LightBlue;

            dgvContasReceber.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvContasReceber.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // 1. Por Status (Pago / Não Pago)
        private void PesquisarPorStatusGeral(bool pago)
        {
            string sql = @"
                SELECT p.*, c.Nome, c.ClienteID
                FROM Parcela p
                INNER JOIN Venda v ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                WHERE p.Pago = @Pago
                ORDER BY p.DataVencimento";

            Utilitario.PesquisarGeralComParametro(sql, "@Pago", pago ? 1 : 0, dgvContasReceber);
            PersonalizarDataGridView();
            CalcularTotalDataGrid();
        }

        // 2. Por Nome + Status
        private void PesquisarPorNomeClienteEStatus(string nomeCliente, bool pago)
        {
            string sql = @"
                SELECT p.*, c.Nome, c.ClienteID
                FROM Parcela p
                INNER JOIN Venda v ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                WHERE c.Nome LIKE @Nome AND p.Pago = @Pago
                ORDER BY p.DataVencimento";

            Utilitario.PesquisarGeralComParametro(sql, "@Nome", $"%{nomeCliente}%", dgvContasReceber);
            Utilitario.PesquisarGeralComParametro(sql.Replace("LIKE @Nome", "LIKE @Nome").Replace("@Nome", "@Nome"), "@Pago", pago ? 1 : 0, dgvContasReceber);
            PersonalizarDataGridView();
            CalcularTotalDataGrid();
        }

        // 3. Por Período + Status
        private void PesquisarPorPeriodoEStatus(DateTime inicio, DateTime fim, bool pago)
        {
            string sql = @"
                SELECT p.*, c.Nome, c.ClienteID
                FROM Parcela p
                INNER JOIN Venda v ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                WHERE p.DataVencimento >= @Inicio 
                  AND p.DataVencimento <= @Fim 
                  AND p.Pago = @Pago
                ORDER BY p.DataVencimento";

            var parametros = new DynamicParameters();
            parametros.Add("@Inicio", inicio.Date);
            parametros.Add("@Fim", fim.Date.AddDays(1).AddSeconds(-1));
            parametros.Add("@Pago", pago ? 1 : 0);

            Utilitario.PesquisarGeralComParametros(sql, parametros, dgvContasReceber);
            PersonalizarDataGridView();
            CalcularTotalDataGrid();
        }

        // 4. Contas Vencidas (até hoje)
        private void PesquisarContasVencidas()
        {
            string sql = @"
                SELECT p.*, c.Nome, c.ClienteID
                FROM Parcela p
                INNER JOIN Venda v ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                WHERE p.DataVencimento <= @Hoje AND p.Pago = 0
                ORDER BY p.DataVencimento";

            Utilitario.PesquisarGeralComParametro(sql, "@Hoje", DateTime.Today, dgvContasReceber);
            PersonalizarDataGridView();
            CalcularTotalDataGrid();
        }

        // 5. Contas a Vencer (a partir de hoje)
        private void PesquisarContasNaoVencidas()
        {
            string sql = @"
                SELECT p.*, c.Nome, c.ClienteID
                FROM Parcela p
                INNER JOIN Venda v ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                WHERE p.DataVencimento > @Hoje AND p.Pago = 0
                ORDER BY p.DataVencimento";

            Utilitario.PesquisarGeralComParametro(sql, "@Hoje", DateTime.Today, dgvContasReceber);
            PersonalizarDataGridView();
            CalcularTotalDataGrid();
        }

        // Carregar itens da venda selecionada
        private void CarregarItensVenda(int vendaID)
        {
            string sql = @"
                SELECT pr.Referencia, pr.NomeProduto, iv.Quantidade, iv.PrecoUnitario,
                       (iv.Quantidade * iv.PrecoUnitario) AS Subtotal
                FROM ItemVenda iv
                INNER JOIN Produtos pr ON iv.ProdutoID = pr.ProdutoID
                WHERE iv.VendaID = @VendaID";

            Utilitario.PesquisarGeralComParametro(sql, "@VendaID", vendaID, dgvItensVenda);

            // Personalização rápida do grid de itens
            if (dgvItensVenda.Columns.Count > 0)
            {
                dgvItensVenda.Columns["PrecoUnitario"].DefaultCellStyle.Format = "C2";
                dgvItensVenda.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
                dgvItensVenda.AutoResizeColumns();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            dgvContasReceber.DataSource = null;
            dgvItensVenda.DataSource = null;

            string opcao = cmbFiltro.Text;

            switch (opcao)
            {
                case "PesquisarPorStatusGeral":
                    PesquisarPorStatusGeral(rbPago.Checked);
                    break;
                case "PesquisarPorNomeClienteEStatus":
                    if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                    {
                        MessageBox.Show("Digite o nome do cliente.");
                        return;
                    }
                    PesquisarPorNomeClienteEStatus(txtNomeCliente.Text, rbPago.Checked);
                    break;
                case "PesquisarPorPeriodoEStatus":
                    PesquisarPorPeriodoEStatus(dtpDataVencimentoInicio.Value, dtpDataVencimentoFim.Value, rbPago.Checked);
                    break;
                case "PesquisarContasVencidas":
                    PesquisarContasVencidas();
                    break;
                case "PesquisarContasNaoVencidas":
                    PesquisarContasNaoVencidas();
                    break;
            }
        }

        private void dgvContasReceber_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContasReceber.SelectedRows.Count > 0 &&
                dgvContasReceber.SelectedRows[0].Cells["VendaID"].Value != null)
            {
                int vendaID = Convert.ToInt32(dgvContasReceber.SelectedRows[0].Cells["VendaID"].Value);
                CarregarItensVenda(vendaID);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e) => Utilitario.ExportarParaPDF(dgvContasReceber, "Relatorio_Contas.pdf");
        private void btnExportarExcel_Click(object sender, EventArgs e) => Utilitario.ExportarParaExcel(dgvContasReceber);

        private void btnSair_Click(object sender, EventArgs e) => this.Close();
        private void btnLocalizarCliente_Click(object sender, EventArgs e) => new FrmLocalizarCliente(this, clienteSelecionado) { Owner = this }.ShowDialog();

        private void FrmRelatorios_Load(object sender, EventArgs e)
        {
            if (cmbFiltro.Items.Count > 0) cmbFiltro.SelectedIndex = 0;
        }
    }
}