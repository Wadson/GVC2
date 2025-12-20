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
        private readonly VendaDal vendaDAL;
        // ✅ CONSTRUTOR OBRIGATÓRIO
        public VendaBLL()
        {
            vendaDAL = new VendaDal();
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

        public int SalvarVendaCompleta(
           VendaModel venda,
           List<ItemVendaModel> itens,
           List<ParcelaModel>? parcelas = null)
        {
            return vendaDAL.AddVendaCompleta(venda, itens, parcelas);
        }

        public void Excluir(VendaModel venda)
        {
            vendaDAL.DeleteVenda(venda);
        }

        public void Alterar(VendaModel venda)
        {
            vendaDAL.UpdateVenda(venda);
        }

       
        // ⚠️ SE PRECISAR MANTER int
        public VendaModel ObterVendaPorId(int vendaId)
        {
            return vendaDAL.ObterVendaPorId(vendaId);
        }

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
