
using GVC.DALL;
using Krypton.Toolkit;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmLocalizarEstado : KryptonForm
    {
        private Form _formChamador;
        protected int LinhaAtual = -1;
        public FrmLocalizarEstado(Form formChamador)
        {
            InitializeComponent();
            _formChamador = formChamador;
            // Configurar o DataGridView (apenas exemplo, configure conforme necessário)
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void Listar()
        {
            EstadoDal dao = new EstadoDal();
            dataGridPesquisar.DataSource = dao.ListarTodos();

            InicializaDataGridView();
        }
        private void InicializaDataGridView()
        {
            //Redimensiona o tamanho das colunas do DataGridView 
            dataGridPesquisar.Columns[0].Width = 100;
            dataGridPesquisar.Columns[1].Width = 170;
            dataGridPesquisar.Columns[2].Width = 110;

            //Renomeia as colunas do DataGridView 
            dataGridPesquisar.Columns[0].HeaderText = "Estado ID";
            dataGridPesquisar.Columns[1].HeaderText = "Nome Estado";
            dataGridPesquisar.Columns[2].HeaderText = "UF";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridPesquisar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dataGridPesquisar.Focus();
            }
        }

        private void dataGridPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && dataGridPesquisar.CurrentCell.RowIndex == 0)
            {
                txtLocalizar.Focus();
            }
            // Adicione a navegação com as setas para cima e para baixo, se ainda não tiver

            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void FrmLocalizarEstado_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void FrmLocalizarEstado_FormClosing(object sender, FormClosingEventArgs e)
        {            
        }

        private void FrmLocalizarEstado_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtCodig_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLocalizar.Text = "";
            txtLocalizar.Focus();
        }

        private void rbtDescrica_KeyDown(object sender, KeyEventArgs e)
        {
            txtLocalizar.Text = "";
            txtLocalizar.Focus();
        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {
            
            EstadoDal dao = new EstadoDal();
            if (rbtCodig.Checked)
            {
                // pesquisa numérica pura
                if (int.TryParse(txtLocalizar.Text, out int id))
                    dataGridPesquisar.DataSource = dao.PesquisarPorCodigo(id);
                else
                    dataGridPesquisar.DataSource = null;
            }
            else
            {
                // pesquisa textual normal
                string nome = "%" + txtLocalizar.Text + "%";
                dataGridPesquisar.DataSource = dao.PesquisarPorNome(nome);
            }
        }
    }
}
