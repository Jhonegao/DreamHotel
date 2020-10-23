﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Preco{ get; set; }
        public int QtdEstoque { get; set; }
        public int UnidadeMedida { get; set; }
        public int DataValidade { get; set; }
        public int Data_Cadastro { get; set; }
        public int CategoriaID { get; set; }
        public bool Ativo { get; set; }
    }
}
