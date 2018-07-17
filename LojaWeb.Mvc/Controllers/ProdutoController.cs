using System;
using System.Collections.Generic;
using LojaWeb.Mvc.Repository;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaWeb.Mvc.Models;

namespace LojaWeb.Mvc.Controllers
{
    public class ProdutoController : Controller
    {

        private ProdutoRepository repo;

        public ProdutoController()
        {
            repo = new ProdutoRepository();
        }

        // GET: Produto
        public ActionResult Index()
        {

            return View(repo.Listar());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            Produto item = repo.Detalhes(id);
            if (item != null)
            {
                return View(item);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(Produto item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Inserir(item);
                    return RedirectToAction("Index");
                }
                else
                {
                    @ViewBag.Mensagem = "Erro ao tentar inserir";
                    return View(item);
                }
                
            }
            catch
            {
                @ViewBag.Mensagem = "Erro ao tentar inserir";
                return View(item);
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
