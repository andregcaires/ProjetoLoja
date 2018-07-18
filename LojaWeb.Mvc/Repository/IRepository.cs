using LojaWeb.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaWeb.Mvc.Repository
{
    interface IRepository<T>
    {
        List<T> Listar();

        void Inserir(T item);

        Produto Detalhes(int? id);

        void Editar(T item);

        void Deletar(T item);
    }
}
