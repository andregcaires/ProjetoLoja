using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using LojaWeb.Mvc.Context;
using LojaWeb.Mvc.Models;
using System.Data.Entity;

namespace LojaWeb.Mvc.Repository
{
    public class TipoDocumentoRepository : IRepository<TipoDocumento>
    {
        private LojaContext _db;

        public TipoDocumentoRepository()
        {
            _db = new LojaContext();
        }

        public void Deletar(int id, TipoDocumento item)
        {
            //_db.Entry(item).State = EntityState.Deleted;
            item = _db.TipoDocumento.Find(id);
            _db.TipoDocumento.Remove(item);
            try
            {
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: "+e.Message);
                //throw;
            }
        }

        public TipoDocumento Detalhes(int? id)
        {
            return _db.TipoDocumento.Find(id);
        }

        public void Editar(TipoDocumento item)
        {
            _db.Entry(item).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Inserir(TipoDocumento item)
        {
            _db.TipoDocumento.Add(item);
            _db.SaveChanges();
        }

        public List<TipoDocumento> Listar()
        {
            return _db.TipoDocumento.ToList();
        }
    }
}
