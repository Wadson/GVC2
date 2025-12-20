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

namespace GVC.UTIL
{
    public partial class FrmOpcoesExtrato : KryptonForm
    {
        public DialogResult OpcaoSelecionada { get; private set; }

            
        public FrmOpcoesExtrato(bool podeExtrato = true, bool podeRecibo = true)
        {
            InitializeComponent();
            // Configura os botões conforme as possibilidades
            if (!podeExtrato)
            {
                btnExtrato.Enabled = false;
                btnExtrato.Text = "Extrato (não disponível)";
            }

            if (!podeRecibo)
            {
                btnRecibo.Enabled = false;
                btnRecibo.Text = "Recibo (não disponível)";
            }
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            if (btnExtrato.Enabled)
            {
                this.OpcaoSelecionada = DialogResult.Yes;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione uma linha no grid para gerar extrato.", "Aviso",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            if (btnRecibo.Enabled)
            {
                this.OpcaoSelecionada = DialogResult.No;
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            else
            {
                MessageBox.Show("Marque o checkbox das parcelas para gerar recibo.", "Aviso",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.OpcaoSelecionada = DialogResult.Cancel;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
