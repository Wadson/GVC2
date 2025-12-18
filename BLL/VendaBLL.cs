using GVC.DALL;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    internal class VendaBLL
    {
        VendaDal vendaDALL = null;
        // Salva venda completa (venda + itens + parcelas)
        public int SalvarVendaCompleta(VendaModel venda, List<ItemVendaModel> itens, List<ParcelaModel>? parcelas = null)
        {
            try
            {
                return vendaDALL.AddVendaCompleta(venda, itens, parcelas);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar venda completa.", ex);
            }
        }

        public void Excluir(VendaModel vendas)
        {
            try
            {
                vendaDALL = new VendaDal();
                vendaDALL.DeleteVenda(vendas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void Alterar(VendaModel vendas)
        {
            try
            {
                vendaDALL = new VendaDal();
                vendaDALL.UpdateVenda(vendas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
