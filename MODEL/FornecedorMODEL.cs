using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class FornecedorModel
    {
        public long FornecedorID { get; set; }          // INTEGER AUTOINCREMENT → long
        public string Nome { get; set; }                // nvarchar(100) NOT NULL
        public string? Cnpj { get; set; }               // nvarchar(14) NULL
        public string? IE { get; set; }                 // nvarchar(20) NULL
        public string? Telefone { get; set; }           // nvarchar(20) NULL
        public string? Email { get; set; }              // nvarchar(100) NULL
        public long CidadeID { get; set; }              // bigint NOT NULL (FK para Cidade)
        public string? Logradouro { get; set; }         // nvarchar(150) NULL
        public string? Numero { get; set; }             // nvarchar(10) NULL
        public string? Bairro { get; set; }             // nvarchar(100) NULL
        public string? Cep { get; set; }                // nvarchar(10) NULL
        public DateTime? DataCriacao { get; set; }      // datetime NULL
        public string? Observacoes { get; set; }
    }

}