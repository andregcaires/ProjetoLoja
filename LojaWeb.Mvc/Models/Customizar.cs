using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaWeb.Mvc.Models
{
    public class Customizar
    {
        [Key]
        public int CustomizarId { get; set; }

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

        [Display(Name = "Documento")]
        public string Documento { get; set; }

        public int TipoDocumentoId { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }

    }
}