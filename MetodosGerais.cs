using GVC.DALL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GVC
{
    internal class MetodosGerais
    {
        /*
        private void btnBaixarParcela_Click(object sender, EventArgs e)
        {
            if (dgvParcelas.CurrentRow == null)
                return;

            int parcelaId = Convert.ToInt32(dgvParcelas.CurrentRow.Cells["ParcelaID"].Value);
            int vendaId = _vendaIdSelecionada;

            var parcelaDal = new ParcelaDal();
            var vendaDal = new VendaDal();

            parcelaDal.BaixarParcela(
                parcelaId,
                DateTime.Now,
                Convert.ToDecimal(txtValorRecebido.Text)
            );

            // 🔴 AQUI ESTÁ O PONTO-CHAVE
            vendaDal.AtualizarStatusVendaPorParcelas(vendaId);

            CarregarParcelas(vendaId);
        }

        */


        //4. CHAMAR AUTOMATICAMENTE AO PAGAR UMA PARCELA

        
         //5. MÉTODO BAIXAR PARCELA (DAL)
         /*
         * public void BaixarParcela(int parcelaId, DateTime dataPagamento, decimal valorPago)
        {
            using (var conn = Conexao())
            {
                conn.Open();

                string sql = @"
                UPDATE Parcela
                SET 
                    Status = 1,
                    DataPagamento = @DataPagamento,
                    ValorRecebido = @ValorRecebido
                WHERE ParcelaID = @ParcelaID";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DataPagamento", dataPagamento);
                    cmd.Parameters.AddWithValue("@ValorRecebido", valorPago);
                    cmd.Parameters.AddWithValue("@ParcelaID", parcelaId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
         * */


                //6. RESULTADO FINAL(COMPORTAMENTO)

                //✔ Pagou 1ª parcela → Venda vira Parcialmente Paga
                //✔ Pagou última parcela → Venda vira Paga
                //✔ Estornou parcela → Venda volta para Parcialmente Paga ou Aberta
                //✔ Venda à vista → já nasce Paga

                //Tudo automático, confiável e auditável.
    }
}
