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

        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Data de Última Compra")]
        [DataType(DataType.Date)]
        public DateTime UltimaCompra { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        public int Estoque { get; set; }

        public virtual ICollection<FornecedorProduto> FornecedorProdutos { get; set; }
    }
}