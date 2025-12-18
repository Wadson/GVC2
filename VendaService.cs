using GVC.DALL;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC
{
    internal class VendaService
    {
        private readonly VendaDal _vendaDal;
        private readonly ItemVendaDal _itemDal;
        private readonly ParcelaDal _parcelaDal;

        public VendaService()
        {
        }

        public VendaService(VendaDal vendaDal, ItemVendaDal itemDal, ParcelaDal parcelaDal)
        {
            _vendaDal = vendaDal;
            _itemDal = itemDal;
            _parcelaDal = parcelaDal;
        }

        //public int CriarVenda(VendaModel venda, List<ItemVendaModel> itens, List<ParcelaModel> parcelas)
        //{
        //    // 1 – Cria venda
        //    // 2 – Salva itens
        //    // 3 – Salva parcelas
        //    // 4 – Atualiza estoque
        //    // Tudo dentro de uma transação!
        //}
    }
}
