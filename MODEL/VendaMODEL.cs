using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class VendaModel
    {
        public long VendaID { get; set; }
        public long ClienteID { get; set; }
        public long? FormaPgtoID { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Desconto { get; set; } = 0;
        public string Observacoes { get; set; }
        public string StatusVenda { get; set; } = "Finalizada";


        public List<ItemVendaModel> ItensVendidos { get; set; }
        public List<ParcelaModel> Parcelas { get; set; }

        public VendaModel()
        {
            ItensVendidos = new List<ItemVendaModel>();
            Parcelas = new List<ParcelaModel>();
        }

        public string NomeCliente { get; set; }
    }
}
