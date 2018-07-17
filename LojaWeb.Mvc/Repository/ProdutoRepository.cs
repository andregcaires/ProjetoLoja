using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using LojaWeb.Mvc.Context;
using LojaWeb.Mvc.Models;

namespace LojaWeb.Mvc.Repository
{
    public class ProdutoRepository : IRepository<Produto>
    {
        private LojaContext _db;

        public ProdutoRepository()
        {
            _db = new LojaContext();
        }

        public Produto Detalhes(int id)
        {
            return _db.Produto.Find(id);
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
