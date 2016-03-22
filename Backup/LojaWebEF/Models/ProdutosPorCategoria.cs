using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWebEF.Models
{
    public class ProdutosPorCategoria
    {
        public Categoria Categoria { get; set; }

        public int NumeroDeProdutos { get; set; }
    }
}