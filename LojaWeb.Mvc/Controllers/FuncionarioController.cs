using System;
using System.Collections.Generic;
using LojaWeb.Mvc.Repository;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaWeb.Mvc.Models;
using System.Net;

namespace LojaWeb.Mvc.Controllers
{
    public class FuncionarioController : Controller
    {

        private FuncionarioRepository repo;

        public FuncionarioController()
        {
            repo = new FuncionarioRepository();
        }

        // GET: Funcionario
        public ActionResult Index()
        {

            return View(repo.Listar());
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Funcionario item = repo.Detalhes(id);
                if (item != null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(item);
                }

            }

        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionario item)
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

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Funcionario item = repo.Detalhes(id);
                if (item != null)
                {
                    return new HttpNotFoundResult();
                }
                else
                {
                    return View(item);
                }
            }
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Funcionario item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Editar(item);
                    return RedirectToAction("Index");
                }


                return View(item);
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Funcionario item = repo.Detalhes(id);
                if (item != null)
                {
                    return new HttpNotFoundResult();
                }
                else
                {
                    return View(item);
                }
            }
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Funcionario item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Deletar(id, item);
                    return RedirectToAction("Index");
                }
                else
                {
                    //
                    return View(item);
                }

            }
            catch
            {
                //
                return View(item);
            }
        }
    }
}
