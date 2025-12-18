using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    internal class UsuarioMODEL
    {
        public int UsuarioID { get; set; }
        public string NomeCompleto { get; set; }   // novo campo: nome real da pessoa
        public string NomeUsuario { get; set; }    // login/username
        public string Email { get; set; }
        public string Senha { get; set; }          // lembre-se: armazenar hash, não senha pura
        public string TipoUsuario { get; set; }    // Normal, Admin, etc.
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCriacao { get; set; }  // novo campo: data de cadastro no sistema
    }

}
