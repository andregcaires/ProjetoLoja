using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaWeb.Mvc.Models;

namespace LojaWeb.Mvc.Context
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }

        public DbSet<TipoDocumento> TipoDocumento { get; set; }

        public DbSet<Funcionario> Funcionario { get; set; }

    }
}