using System;
using System.ComponentModel.DataAnnotations;

namespace Loja.Web.Models
{
    public class Produto
    {
        // indica chave primária
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public Decimal Preco { get; set; }

        public DateTime UltimaCompra { get; set; }

        public float Estoque { get; set; }
    }
}