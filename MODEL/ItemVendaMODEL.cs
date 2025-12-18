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
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        //public decimal Subtotal { get; set; }
        public decimal DescontoItem { get; set; } = 0;
        public string NomeProduto { get; set; }
        public decimal Subtotal { get; set; }// Coluna computada (PERSISTED)
        public VendaModel Venda { get; set; }
        
    }
}
