
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmFerramentas : KryptonForm
    {
        public FrmFerramentas()
        {
            InitializeComponent();
        }

        private void btnExcluirRegistrosOrfao_Click(object sender, EventArgs e)
        {            
        }

        private void txtBackup_Click(object sender, EventArgs e)
        {
            FrmBackup frmBackup = new FrmBackup();
            frmBackup.ShowDialog();
        }

        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {            
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelProdutos_Click(object sender, EventArgs e)
        {            
        }

        private void InsertBanco_Click(object sender, EventArgs e)
        {           
        }

        private void FrmModeloUI_Click(object sender, EventArgs e)
        {
            FrmModeloUI frm = new FrmModeloUI();
            frm.ShowDialog();
        }
    }
}
