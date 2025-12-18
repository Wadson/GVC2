using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class ProdutosModel
    {
        public long ProdutoID { get; set; }
        public string NomeProduto { get; set; } = string.Empty;
        public string? Referencia { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal Lucro { get; set; }
        public decimal PrecoDeVenda { get; set; }
        public long Estoque { get; set; }
        public DateTime DataDeEntrada { get; set; }
        public string Status { get; set; } = string.Empty;
        public string? Situacao { get; set; }
        public string? Unidade { get; set; }
        public string? Marca { get; set; }
        public DateTime? DataValidade { get; set; }
        public string? GtinEan { get; set; }
        public string? Imagem { get; set; }
        public long FornecedorID { get; set; }
        public string? Fornecedor { get; set; }

        // 🔎 Propriedades calculadas
        public decimal MargemLucro =>
            PrecoCusto > 0 ? (PrecoDeVenda - PrecoCusto) / PrecoCusto * 100 : 0;

        public bool EstoqueBaixo => Estoque <= 10;
    }

}
