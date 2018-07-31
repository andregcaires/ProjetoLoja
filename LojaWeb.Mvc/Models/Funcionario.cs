using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Mvc.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }

        [StringLength(70, MinimumLength = 10, ErrorMessage = "O {0} deve ter entre 10 e 70 caracteres")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "O {0} deve ser válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString = "{0:c2}", ApplyFormatInEditMode = false)]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Tipo de Documento")]
        public int TipoDocumentoId { get; set; }

        public int Idade { get {
                return DateTime.Now.Year - DataNascimento.Year;
            } }

        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}