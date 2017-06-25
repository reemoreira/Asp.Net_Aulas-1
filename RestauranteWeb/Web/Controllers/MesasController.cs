using BaseModels;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class MesasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();//dei um copiar na page de cliente para pegar o contexto
        // GET: Mesas
        public ActionResult Index()//carreguamento da pagina primeira vez
        {
            return View(db.Mesas.ToList());
        }


        // GET
        public ActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult Create(Mesa mesa)
        {
            if (ModelState.IsValid)
            {
                mesa.Ativo = true;
                db.Mesas.Add(mesa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mesa);
        }


        // GET
        public ActionResult Edit(int? id)
        {
            // verificar se nao veio id => BadRequest
            if (id == null)
            {
                // Erro - 400
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mesa mesa = db.Mesas.Find(id);   // Pesquisa na fonte de dados o objeto a editar           

            if (mesa == null) // se objeto nao foi encontrado na fonte de dados
            {
                // Erro - 404
                return HttpNotFound();
            }


            return View(mesa);
        }

        // POST
        [HttpPost]
        public ActionResult Edit(Mesa mesa)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // fazer update na fonte de dados
                    db.Entry(mesa).State = EntityState.Modified;
                    db.SaveChanges();
                    // Redirecionar
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return View(mesa);
        }


        // GET
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mesa mesa = db.Mesas.Find(id);
            if (mesa == null)
            {
                return HttpNotFound();
            }

            return View(mesa);
        }

        [HttpPost, ActionName("Delete")] //alterando o nome que ira aparecer ao usuario
        public ActionResult DeleteConfirmed(int id)
        {
            // pesquisar objeto por id
            Mesa mesa = db.Mesas.Find(id);
            mesa.Ativo = false;
            db.Entry(mesa).State = EntityState.Modified;
            db.SaveChanges();
            // alterar status do objeto para deleted ou ativo para false
            TempData["Mensagem"] = "Mesa excluida com sucesso";
            return RedirectToAction("Index");
        }
    }
}