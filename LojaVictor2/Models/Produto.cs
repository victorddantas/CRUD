﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVictor2.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int CategoriaId { get; set; }
    }
}