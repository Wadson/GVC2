using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class ClienteMODEL
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string RG { get; set; }
        public string Cnpj { get; set; }
        public string IE { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int? CidadeID { get; set; }   // bigint no banco → int? na classe
        public string OrgaoExpedidorRG { get; set; }
        // Endereço detalhado
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }

        // Dados adicionais do cliente
        public DateTime? DataNascimento { get; set; }   // datetime NULL
        public string TipoCliente { get; set; }         // nvarchar(20)

        // Status (no banco é bigint DEFAULT 1)
        public long Status { get; set; } = 1;           // refletindo fielmente o banco

        public string Observacoes { get; set; }

        // Controle financeiro
        public DateTime? DataUltimaCompra { get; set; }
        public decimal? LimiteCredito { get; set; }     // real → decimal?

        // Auditoria
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; }
        public string UsuarioCriacao { get; set; }
        public string UsuarioAtualizacao { get; set; }
               
    }

}