﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Categories
    {
        public int ID { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
