using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class ItemVendaModel
    {
        public long ItemVendaID { get; set; }
        public long VendaID { get; set; }
        public long ProdutoID { get; set; }

        public string NomeProduto { get; set; }

        // 🔴 bigint → long
        public long Quantidade { get; set; }

        // 🔴 dinheiro → decimal
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public decimal DescontoItem { get; set; }

        public VendaModel Venda { get; set; }
    }

}
