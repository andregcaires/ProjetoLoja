using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaWeb.Mvc.Models
{
    public class Fornecedor
    {
        [Key]
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(14, MinimumLength = 11, ErrorMessage = "Informe um {0} válido")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string Telefone { get; set; }

        public virtual ICollection<FornecedorProduto> FornecedorProdutos { get; set; }

    }
}