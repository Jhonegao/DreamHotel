using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public List<string> Telefones  { get; set; }
        public int EnderecoId { get; set; }
        public Address Endereco { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public bool IsAdmin { get; set; }
        public string Senha { get; set; }
        public bool Ativo{ get; set; }
    }
}
