using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Provider
    {
        public int ID { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string NomeContato { get; set; }
        public string Email { get; set; }
        public List<string> Telefones { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public int EenderecoID { get; set; }
        public bool Ativo { get; set; }
    }
}
