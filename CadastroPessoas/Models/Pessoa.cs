using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoas.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
    }
}
