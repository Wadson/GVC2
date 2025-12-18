using GVC.BLL;
using GVC.DALL;
using GVC.MODEL;
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
    public partial class FrmExclusaoOrfaos : KryptonForm
    {
        public FrmExclusaoOrfaos()
        {
            InitializeComponent();
        }
        private void AtualizarDataGridView()
        {
            AtualizarDataGrid(dgvVendas, () => new VendaDal().ListarVendas());
            AtualizarDataGrid(dgvPagamentosParciais, () => new PagamentoParcialDal().ListarPagamentosParciais());
            AtualizarDataGrid(dgvParcelas, () => new ParcelaDal().ListarParcelas());
            AtualizarDataGrid(dgvItensVenda, () => new ItemVendaDal().ListarItensVenda());
        }

        /// <summary>
        /// Atualiza o DataGridView com os dados fornecidos pelo método de listagem.
        /// </summary>
        private void AtualizarDataGrid(DataGridView dgv, Func<object> listarDados) =>
            dgv.DataSource = listarDados();
       

        // Handlers dos botões de exclusão
        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            int quantidadeSelecionada = dgvVendas.SelectedRows.Count;
            int excluidosComSucesso = 0;
            int falhas = 0;

            // Supondo que você tenha um DataGridView chamado 'dgvVendas'
            foreach (DataGridViewRow row in dgvVendas.SelectedRows)
            {
                var vendaID = Convert.ToInt32(row.Cells["VendaID"].Value);

                VendaModel vendaModel = new VendaModel();
                vendaModel.VendaID = vendaID;

                VendaDal vendaDAL = new VendaDal();
                vendaDAL.DeleteVenda(vendaModel);
            }
            // Exibe a mensagem de sucesso
            string mensagem = $"Total selecionados: {quantidadeSelecionada}\nExcluídos com sucesso: {excluidosComSucesso}\nFalhas: {falhas}";
            MessageBox.Show(mensagem, $"Resultado da exclusão de vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Atualize o DataGridView após a exclusão
            AtualizarDataGridView();
        }

        private void btnExcluirPagamentoParcial_Click(object sender, EventArgs e)
        {
            int quantidadeSelecionada = dgvPagamentosParciais.SelectedRows.Count;
            int excluidosComSucesso = 0;
            int falhas = 0;

            // Supondo que você tenha um DataGridView chamado 'dgvVendas'
            foreach (DataGridViewRow row in dgvPagamentosParciais.SelectedRows)
            {
                var pagamentoParcialID = Convert.ToInt32(row.Cells["PagamentoParcialID"].Value);

                PagamentoParcialModel pagamentoParcialModel = new PagamentoParcialModel();
                pagamentoParcialModel.PagamentoID = pagamentoParcialID;

                PagamentoParcialDal pagamentoParcialDal = new PagamentoParcialDal();
                pagamentoParcialDal.Excluir(pagamentoParcialModel);
            }
            // Exibe a mensagem de sucesso
            string mensagem = $"Total selecionados: {quantidadeSelecionada}\nExcluídos com sucesso: {excluidosComSucesso}\nFalhas: {falhas}";
            MessageBox.Show(mensagem, $"Resultado da exclusão de pagamentos parciais", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Atualize o DataGridView após a exclusão
            AtualizarDataGridView();
        }

        private void btnExcluirParcelas_Click(object sender, EventArgs e)
        {
            int quantidadeSelecionada = dgvParcelas.SelectedRows.Count;
            int excluidosComSucesso = 0;
            int falhas = 0;

            // Supondo que você tenha um DataGridView chamado 'dgvVendas'
            foreach (DataGridViewRow row in dgvParcelas.SelectedRows)
            {
                var parcelaID = Convert.ToInt32(row.Cells["ParcelaID"].Value);

                ParcelaModel parcelaModel = new ParcelaModel();
                parcelaModel.ParcelaID = parcelaID;

                ParcelaDal parcelaDAL = new ParcelaDal();
                parcelaDAL.Excluir(parcelaModel);
            }
            // Exibe a mensagem de sucesso
            string mensagem = $"Total selecionados: {quantidadeSelecionada}\nExcluídos com sucesso: {excluidosComSucesso}\nFalhas: {falhas}";
            MessageBox.Show(mensagem, $"Resultado da exclusão das parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Atualize o DataGridView após a exclusão
            AtualizarDataGridView();

        }

        private void btnExcluirItensVenda_Click(object sender, EventArgs e)
        {
            int quantidadeSelecionada = dgvItensVenda.SelectedRows.Count;
            int excluidosComSucesso = 0;
            int falhas = 0;

            // Supondo que você tenha um DataGridView chamado 'dgvVendas'
            foreach (DataGridViewRow row in dgvItensVenda.SelectedRows)
            {
                var itemVendaID = Convert.ToInt32(row.Cells["ItemVendaID"].Value);

                ItemVendaModel itemVendaModel = new ItemVendaModel();
                itemVendaModel.ItemVendaID = itemVendaID;

                ItemVendaDal itemvendaDAL = new ItemVendaDal();
                itemvendaDAL.Excluir(itemVendaModel);
            }
            // Exibe a mensagem de sucesso
            string mensagem = $"Total selecionados: {quantidadeSelecionada}\nExcluídos com sucesso: {excluidosComSucesso}\nFalhas: {falhas}";
            MessageBox.Show(mensagem, $"Resultado da exclusão de Itens de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Atualize o DataGridView após a exclusão
            AtualizarDataGridView();
        }

        // Botão de sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Carrega os dados ao abrir o formulário
        private void FrmExclusaoOrfao_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

    }
}
