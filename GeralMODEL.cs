using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{     
      

    internal class UsuarioMODELf
    {
        public int UsuarioID { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public byte[] SenhaHash { get; set; }     // varbinary(64)
        public byte[] SenhaSalt { get; set; }     // varbinary(32)
        public string TipoUsuario { get; set; }   // ADMINISTRADOR, GERENTE, OPERADOR, CONSULTA
        public string Cpf { get; set; }           // apenas números (11 dígitos)
        public DateTime? DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}