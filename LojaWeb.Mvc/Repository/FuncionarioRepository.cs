using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using LojaWeb.Mvc.Context;
using LojaWeb.Mvc.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace LojaWeb.Mvc.Repository
{
    public class FuncionarioRepository : IRepository<Funcionario>
    {
        private LojaContext _db;

        public FuncionarioRepository()
        {
            _db = new LojaContext();
        }

        public void Deletar(int id, Funcionario item)
        {
            //_db.Entry(item).State = EntityState.Deleted;
            item = _db.Funcionario.Find(id);
            _db.Funcionario.Remove(item);
            _db.SaveChanges();
        }

        public Funcionario Detalhes(int? id)
        {
            return _db.Funcionario.Find(id);
        }

        public void Editar(Funcionario item)
        {
            _db.Entry(item).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Inserir(Funcionario item)
        {
            _db.Funcionario.Add(item);
            _db.SaveChanges();
        }

        public List<Funcionario> Listar()
        {
            // preenche o campo TipoDocumento
            return _db.Funcionario.Include(f => f.TipoDocumento).ToList();
        }

        public SelectList PreencheTipoDocumento()
        {
            return new SelectList(_db.TipoDocumento, "TipoDocumentoId", "Descricao");
        }
    }
}
