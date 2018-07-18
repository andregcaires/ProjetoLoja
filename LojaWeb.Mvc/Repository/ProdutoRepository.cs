using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using LojaWeb.Mvc.Context;
using LojaWeb.Mvc.Models;
using System.Data.Entity;

namespace LojaWeb.Mvc.Repository
{
    public class ProdutoRepository : IRepository<Produto>
    {
        private LojaContext _db;

        public ProdutoRepository()
        {
            _db = new LojaContext();
        }

        public void Deletar(Produto item)
        {
            _db.Entry(item).State = EntityState.Deleted;
            _db.SaveChanges();
        }

        public Produto Detalhes(int? id)
        {
            return _db.Produto.Find(id);
        }

        public void Editar(Produto item)
        {
            _db.Entry(item).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Inserir(Produto item)
        {
            _db.Produto.Add(item);
            _db.SaveChanges();
        }

        public List<Produto> Listar()
        {
            return _db.Produto.ToList();
        }
    }
}
