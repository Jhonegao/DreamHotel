using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customers
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public char CPF { get; set; }
        public string RG { get; set; }
        public List<string> Telefones { get; set; }
        public string Email { get; set; }
        public int EnderecoID { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
