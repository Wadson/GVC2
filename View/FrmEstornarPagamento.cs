using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace GVC.View
{
    public partial class FrmEstornarPagamento : KryptonForm
    {

        public decimal ValorEstorno { get; private set; }
        public string Motivo { get; private set; }

        public FrmEstornarPagamento()
        {
            InitializeComponent();
        }

        public void CarregarDados(List<long> parcelasIds, string nomeCliente)
        {
            txtNomeCliente.Text = nomeCliente;
            // Opcional: calcular saldo total das parcelas selecionadas para sugerir valor máximo
        }

        private void btnConfirmarEstorno_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValorEstornado.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Informe um valor válido para estorno.");
                return;
            }

            ValorEstorno = valor;
            Motivo = txtMotivo.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEstornarPagamento_Load(object sender, EventArgs e)
        {
            txtValorEstornado.Focus();
        }

        private void FrmEstornarPagamento_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmEstornarPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
