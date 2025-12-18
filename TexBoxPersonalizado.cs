using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVC
{
    public partial class TexBoxPersonalizado : UserControl
    {
        public TexBoxPersonalizado()
        {
            InitializeComponent();
        }
        public new string Text
        {
            get => textBox1.Text; // textBox1 é o controle interno do tipo TextBox
            set => textBox1.Text = value;
        }
        public new event EventHandler TextChanged
        {
            add => textBox1.TextChanged += value;
            remove => textBox1.TextChanged -= value;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.PowderBlue;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
    }
}
