﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteMVC.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal Desconto { get; set; }
    }
}