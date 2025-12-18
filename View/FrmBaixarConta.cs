using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using GVC.View;

namespace GVC
{
    public partial class FrmBaixarConta : KryptonForm
    {
       
        

        public FrmBaixarConta()
        {
            InitializeComponent();
       
            CarregarDadosParcela();
            txtValorPago.Leave += new EventHandler(txtValorPago_Leave);
        }
        private void CarregarDadosParcela()
        {
            //txtParcelaID.Text = _parcela.ParcelaID.ToString();
            //txtNumeroParcela.Text = _parcela.NumeroParcela.ToString();
            //txtValorParcela.Text = _parcela.ValorParcela.ToString("N2");
            //dtpDataVencimento.Value = _parcela.DataVencimento;
            //txtSaldoRestante.Text = _parcela.SaldoRestante.ToString("N2");
            //txtValorPago.Text = _parcela.ValorPago.ToString("N2");
        }

        private void FrmBaixarConta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                //this.Close();
                if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        private void BaixarConta()
        {
            // Capturar os valores dos TextBoxes
            int parcelaID = int.Parse(txtParcelaID.Text);
            decimal valorPagoParcial = decimal.Parse(txtValorPago.Text);
            DateTime dataPagamento = DateTime.Parse(dtpDataPagamento.Text);

            // Buscar os valores atuais da parcela
            decimal valorPagoAtual = 0;
            decimal saldoRestanteAtual = 0;

            using (var conn = GVC.Helpers.Conexao.Conex())
            {
                conn.Open();

                // Buscar os valores atuais da parcela
                string selectParcelaQuery = "SELECT ValorRecebido, SaldoRestante FROM Parcela WHERE ParcelaID = @ParcelaID";

                using (SqliteCommand cmdSelect = new SqliteCommand(selectParcelaQuery, conn))
                {
                    cmdSelect.Parameters.AddWithValue("@ParcelaID", parcelaID);
                    using (SqliteDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            valorPagoAtual = reader.GetDecimal(0);
                            saldoRestanteAtual = reader.GetDecimal(1);
                        }
                    }
                }
            }

            // Calcular o novo valor pago e o novo saldo restante
            decimal novoValorPago = valorPagoAtual + valorPagoParcial;
            decimal novoSaldoRestante = saldoRestanteAtual - valorPagoParcial;
            bool pago = novoSaldoRestante <= 0;

            // Inserir registro na tabela PagamentoParcial
            string insertPagamentoParcialQuery = "INSERT INTO PagamentosParciais (ParcelaID, ValorPago, DataPagamento) VALUES (@ParcelaID, @ValorPago, @DataPagamento)";

            // Atualizar a tabela Parcela
            string updateParcelaQuery = "UPDATE Parcela SET Pago = @Pago, ValorRecebido = @ValorRecebido, SaldoRestante = @SaldoRestante WHERE ParcelaID = @ParcelaID";

            using (var conn = GVC.Helpers.Conexao.Conex())
            {
                conn.Open();

                using (SqliteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Inserir na tabela PagamentoParcial
                        using (SqliteCommand cmdPagamentoParcial = new SqliteCommand(insertPagamentoParcialQuery, conn, transaction))
                        {
                            cmdPagamentoParcial.Parameters.AddWithValue("@ParcelaID", parcelaID);
                            cmdPagamentoParcial.Parameters.AddWithValue("@ValorPago", valorPagoParcial);
                            cmdPagamentoParcial.Parameters.AddWithValue("@DataPagamento", dataPagamento);
                            cmdPagamentoParcial.ExecuteNonQuery();
                        }

                        // Atualizar tabela Parcela
                        using (SqliteCommand cmdParcela = new SqliteCommand(updateParcelaQuery, conn, transaction))
                        {
                            cmdParcela.Parameters.AddWithValue("@Pago", pago);
                            cmdParcela.Parameters.AddWithValue("@ValorRecebido", novoValorPago);
                            cmdParcela.Parameters.AddWithValue("@SaldoRestante", novoSaldoRestante);
                            cmdParcela.Parameters.AddWithValue("@ParcelaID", parcelaID);
                            cmdParcela.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction in case of error
                        transaction.Rollback();
                        throw new Exception("Erro ao baixar conta: " + ex.Message);
                    }
                }
            }
            this.Close();
        }


        private void btnReceber_Click(object sender, EventArgs e)
        {
            BaixarConta();
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValorPago.Text, out decimal valorRecebido))
            {
                txtValorPago.Text = valorRecebido.ToString("N2");
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido.");
                txtValorPago.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
