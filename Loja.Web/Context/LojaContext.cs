using Loja.Web.Models;
using System.Data.Entity;

namespace Loja.Web.Context
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; } 

    }
}