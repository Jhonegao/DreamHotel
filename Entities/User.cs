using Commmon.Auxiliar;
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
        [Length(70)]
        [@MinLength(2)]
        public string Nome { get; set; }
        [Length(11)]
        [@MinLength(11)]
        public string Cpf { get; set; }
        [Length(15)]
        [@MinLength(5)]
        public string Rg { get; set; }
        [Length(60)]
        [@MinLength(7)]
        public string Email { get; set; }
        [Length(15)]
        [@MinLength(7)]
        public string Telefone { get; set; }
        [Length(15)]
        [@MinLength(0)]
        public string Telefone_Aux { get; set; } = "Nao informado";
        [@MinLength(1)]
        public int EnderecoId { get; set; }
        public Address Endereco { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public bool IsAdmin { get; set; }
        [Length(50)]
        [@MinLength(5)]
        public string Senha { get; set; }
        public bool Ativo{ get; set; }
    }
}
