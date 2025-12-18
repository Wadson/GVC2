using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class ParcelaModel
    {
        public long ParcelaID { get; set; }
        public long VendaID { get; set; }
        public long NumeroParcela { get; set; }

        public DateTime DataVencimento { get; set; }

        // valores em CENTAVOS
        public decimal ValorParcela { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Juros { get; set; }
        public decimal Multa { get; set; }

        public string Status { get; set; } = "Pendente";
        public DateTime? DataPagamento { get; set; }
        public string? Observacao { get; set; }

        // 🔹 propriedades auxiliares (NÃO MAPEADAS)
        public decimal ValorParcelaDec => ValorParcela;
        public decimal ValorRecebidoDec => ValorRecebido;
        public decimal JurosDec => Juros;
        public decimal MultaDec => Multa;

        public decimal TotalDec => ValorParcelaDec + JurosDec + MultaDec;
        public decimal SaldoDec => TotalDec - ValorRecebidoDec;
    }

}
