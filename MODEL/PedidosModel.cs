using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.MODEL
{
    internal class PedidosMODEL
    {
        public int PedidoID { get; set; }
        public int FornecedorID { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotalPedido { get; set; }
    }
}
