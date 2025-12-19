using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GVC.View.FrmVendas;

namespace GVC
{
    public static class StatusHelper
    {
        // VENDA
        public static string ToDb(this EnumStatusVenda status)
            => status switch
            {
                EnumStatusVenda.EmAnalise => "Em Análise",
                EnumStatusVenda.AguardandoPagamento => "Aguardando Pagamento",
                EnumStatusVenda.ParcialmentePago => "Parcialmente Pago",
                EnumStatusVenda.Concluida => "Concluída",
                _ => status.ToString()
            };

        // PARCELA
        public static string ToDb(this EnumStatusParcela status)
            => status switch
            {
                EnumStatusParcela.ParcialmentePaga => "Parcialmente Paga",
                _ => status.ToString()
            };
    }
}
