using GVC.DALL;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GVC.View.FrmVendas;

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
        //🔹 Passo B — Criar método de cálculo na VendaBLL
        public string CalcularStatusVendaPorParcelas(List<ParcelaModel> parcelas)
        {
            if (parcelas == null || parcelas.Count == 0)
                return EnumStatusVenda.Aberta.ToDb();

            decimal total = parcelas.Sum(p => p.ValorParcela + p.Juros + p.Multa);
            decimal recebido = parcelas.Sum(p => p.ValorRecebido);

            if (recebido <= 0)
                return EnumStatusVenda.Aberta.ToDb();

            if (recebido >= total)
                return EnumStatusVenda.Concluida.ToDb();

            return EnumStatusVenda.ParcialmentePago.ToDb();
        }
        //        🔹 Passo C — Ajustar ParcelaBLL.BaixarParcelaParcial

        //👉 É AQUI que tudo se fecha

      
        public string CalcularStatusVenda(List<ParcelaModel> parcelas)
        {
            if (parcelas == null || parcelas.Count == 0)
                return EnumStatusVenda.Aberta.ToDb();

            decimal total = parcelas.Sum(p => p.ValorParcela + p.Juros + p.Multa);
            decimal recebido = parcelas.Sum(p => p.ValorRecebido);

            if (recebido <= 0)
                return EnumStatusVenda.Aberta.ToDb();

            if (recebido >= total)
                return EnumStatusVenda.Concluida.ToDb();

            return EnumStatusVenda.ParcialmentePago.ToDb();
        }

    }
}
