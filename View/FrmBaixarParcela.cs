using Dapper;
using GVC.BLL;
using GVC.DALL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; // Adicione no topo do arquivo

namespace GVC.View
{
    public partial class FrmBaixarParcela : KryptonForm
    {
        // Cultura brasileira fixa
        private readonly CultureInfo _culturaBR = new CultureInfo("pt-BR");
        private List<int> _parcelasIds = new();
        private decimal _saldoTotal;
        private IFormatProvider? _br;
        private readonly ParcelaBLL parcelaBLL = new ParcelaBLL();
        public FrmBaixarParcela()
        {
            InitializeComponent();
        }

        public FrmBaixarParcela(int parcelaId, string nomeCliente, decimal valorParcela, decimal valorRecebido, decimal saldo)
        {
            InitializeComponent();

            _parcelasIds.Clear();
            _parcelasIds.Add(parcelaId);
            _saldoTotal = saldo;
            txtClienteNome.Text = nomeCliente;

            txtValorParcela.Text = valorParcela.ToString("C2");
            txtValorRecebido.Text = valorRecebido.ToString("C2");
            txtSaldo.Text = saldo.ToString("C2");

            lblValorParcela.Text = "Valor da Parcela";
            txtValorRecebido.Focus();
        }
        private void ConfigurarGridBaixa()
        {
            dgvParcelasBaixa.AutoGenerateColumns = false;
            dgvParcelasBaixa.Columns.Clear();

            // Coluna ID (oculta)
            var colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ParcelaID",
                HeaderText = "ID",
                Width = 60,
                Visible = false
            };
            dgvParcelasBaixa.Columns.Add(colId);

            // Coluna ID (oculta)
            var colIdVenda = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VendaID",
                HeaderText = "VendaID",
                Width = 60,
                Visible = false
            };
            dgvParcelasBaixa.Columns.Add(colIdVenda);

            // Coluna Número da Parcela (centralizada)
            var colParcela = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroParcela",
                HeaderText = "Nº Parc.",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvParcelasBaixa.Columns.Add(colParcela);

            // Demais colunas
            dgvParcelasBaixa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVencimento",
                HeaderText = "Vencimento",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });
            dgvParcelasBaixa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorParcela",
                HeaderText = "Valor",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
            dgvParcelasBaixa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorRecebido",
                HeaderText = "Recebido",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
            dgvParcelasBaixa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Saldo",
                HeaderText = "Saldo",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvParcelasBaixa.ReadOnly = true;
            dgvParcelasBaixa.AllowUserToAddRows = false;
            dgvParcelasBaixa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Assinatura atual:
        public void CarregarDados(
            List<dynamic> parcelasSelecionadas,
            string nomeCliente,
            decimal totalParcelas,
            decimal totalRecebido,
            decimal saldoTotal)
        {
            _parcelasIds = parcelasSelecionadas.Select(p => (int)p.ParcelaID).ToList();
            _saldoTotal = saldoTotal;

            txtClienteNome.Text = nomeCliente;
            lblValorParcela.Text = _parcelasIds.Count > 1 ? "Valor Total das Parcelas" : "Valor da Parcela";
            txtValorParcela.Text = totalParcelas.ToString("C2");
            txtValorRecebido.Text = totalRecebido.ToString("C2");
            txtSaldo.Text = saldoTotal.ToString("C2");

            ConfigurarGridBaixa();
            dgvParcelasBaixa.DataSource = parcelasSelecionadas.ToList();

            if (_parcelasIds.Count == 1)
                txtValorRecebido.Focus();
        }


        private void btnConfirmarBaixa_Click(object sender, EventArgs e)
        {
            string texto = txtValorRecebido.Text.Replace("R$", "") .Replace(" ", "").Trim();

            if (!decimal.TryParse(texto, NumberStyles.Any, _br, out decimal valorBaixa) || valorBaixa <= 0)
            {
                MessageBox.Show("Informe um valor válido maior que zero.");
                return;
            }

            if (valorBaixa > _saldoTotal)
            {
                MessageBox.Show("O valor pago não pode ser maior que o saldo devido.");
                return;
            }

            if (_parcelasIds.Count == 1)
            {
                parcelaBLL.BaixarParcelaParcial(_parcelasIds[0], valorBaixa);
            }
            else
            {
                parcelaBLL.BaixarParcelasEmLote(_parcelasIds);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public static void SalvarNomesControles(Form form, string caminhoArquivo)
        {
            var nomes = new List<string>();
            PercorrerControles(form.Controls, nomes);

            // Salva todos os nomes no arquivo .txt
            File.WriteAllLines(caminhoArquivo, nomes);
        }

        private static void PercorrerControles(Control.ControlCollection controls, List<string> nomes)
        {
            foreach (Control ctrl in controls)
            {
                nomes.Add(ctrl.Name);

                if (ctrl.HasChildren)
                {
                    PercorrerControles(ctrl.Controls, nomes);
                }
            }
        }


        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            string texto = txtValorRecebido.Text
         .Replace("R$", "")
         .Replace(" ", "")
         .Trim();

            if (string.IsNullOrEmpty(texto))
            {
                txtSaldo.Text = _saldoTotal.ToString("C2");
                btnConfirmarBaixa.Enabled = false;
                return;
            }

            if (decimal.TryParse(texto, NumberStyles.Any, _br, out decimal valorBaixa))
            {
                if (valorBaixa <= 0 || valorBaixa > _saldoTotal)
                {
                    txtSaldo.Text = _saldoTotal.ToString("C2");
                    btnConfirmarBaixa.Enabled = false;
                }
                else
                {
                    txtSaldo.Text = (_saldoTotal - valorBaixa).ToString("C2");
                    btnConfirmarBaixa.Enabled = true;
                }
            }
            else
            {
                btnConfirmarBaixa.Enabled = false;
            }
        }

        private void btnListarControlesDoForm_Click(object sender, EventArgs e)
        {
            // Caminho onde o arquivo será salvo
            string caminho = @"D:\ControlesForm.txt";

            FrmBaixarParcela.SalvarNomesControles(this, caminho);

            MessageBox.Show("Lista de controles salva em: " + caminho);
        }

        private void FrmBaixarParcela_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmBaixarParcela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValorRecebido.Text))
            {
                txtValorRecebido.Text = "0,00";
                return;
            }

            // Limpa possíveis caracteres indesejados
            string textoLimpo = txtValorRecebido.Text
                .Replace("R$", "")
                .Replace(" ", "")
                .Trim();

            if (decimal.TryParse(textoLimpo, NumberStyles.Any, _br, out decimal valor))
            {
                // Formata como 1.000,00 (sem R$ para evitar problema no parse)
                txtValorRecebido.Text = valor.ToString("C2");
            }
            else
            {
                txtValorRecebido.Text = "0,00";
            }
        }

        public void BaixarParcelaParcial(int parcelaId, decimal valorPago)
        {
            ParcelaDal _dal = new ParcelaDal();
            if (valorPago <= 0)
                throw new Exception("O valor pago deve ser maior que zero.");

            var parcela = _dal.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            // Converter tudo para decimal primeiro para evitar problemas de precisão
            decimal valorParcelaDecimal = parcela.ValorParcela;
            decimal jurosDecimal = parcela.Juros;
            decimal multaDecimal = parcela.Multa;
            decimal valorRecebidoDecimal = parcela.ValorRecebido;

            // Calcular saldo em decimal
            decimal valorTotalParcela = valorParcelaDecimal + jurosDecimal + multaDecimal;
            decimal saldoAtual = valorTotalParcela - valorRecebidoDecimal;

            // Arredondar para 2 casas decimais para evitar problemas de precisão
            valorPago = Math.Round(valorPago, 2, MidpointRounding.AwayFromZero);

            if (valorPago > saldoAtual)
                throw new Exception($"Valor pago ({valorPago:C2}) maior que o saldo devido ({saldoAtual:C2}).");

            _dal.BaixarParcela(parcelaId, valorPago, DateTime.Now);
        }

        private void FrmBaixarParcela_Load(object sender, EventArgs e)
        {

        }

        private void dgvParcelasBaixa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Proteger índices inválidos
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var coluna = dgvParcelasBaixa.Columns[e.ColumnIndex].DataPropertyName;

            // 1) Datas: formatar dd/MM/yyyy
            if ((coluna == "DataVencimento") && e.Value != null)
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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
