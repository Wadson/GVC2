using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    internal class ParcelaExtrato
    {
        public long ParcelaID { get; set; }
        public long VendaID { get; set; }
        public int NumeroParcela { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Juros { get; set; }
        public decimal Multa { get; set; }
        public decimal Saldo { get; set; }
        public string Status { get; set; }
        public string FormaPagamento { get; set; }
    }
}
