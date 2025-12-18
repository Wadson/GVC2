using GVC.DALL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    internal class PagamentoParcialModel
    {
        public long PagamentoID { get; set; } // ID do pagamento parcial, chave primária
        public long ParcelaID { get; set; } // ID da parcela associada
        public decimal ValorPago { get; set; } // Valor pago na parcela
        public DateTime DataPagamento { get; set; } = DateTime.Now;

        // Propriedade de navegação opcional para a Parcela
       

        public static implicit operator PagamentoParcialModel(PagamentoParcialDal v)
        {
            throw new NotImplementedException();
        }
    }
}
