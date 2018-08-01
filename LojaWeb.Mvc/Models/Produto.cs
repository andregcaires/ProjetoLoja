using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaWeb.Mvc.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public DateTime UltimaCompra { get; set; }

        public int Estoque { get; set; }

        public virtual ICollection<FornecedorProduto> FornecedorProdutos { get; set; }
    }
}