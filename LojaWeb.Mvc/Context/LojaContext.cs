using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaWeb.Mvc.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LojaWeb.Mvc.Context
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }

        public DbSet<TipoDocumento> TipoDocumento { get; set; }

        public DbSet<Funcionario> Funcionario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // remove a conveção Cascade da deleção One To Many
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<LojaWeb.Mvc.Models.Fornecedor> Fornecedors { get; set; }
    }
}