using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BaseModels;
using PlanoB.Models;

namespace PlanoB.Controllers
{
    public class FolhasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Folhas
        public ActionResult Index()
        {
            var folhas = db.Folhas.Include(f => f.Funcionario);
            return View(folhas.ToList());
        }

        // GET: Folhas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Folha folha = db.Folhas.Find(id);
            if (folha == null)
            {
                return HttpNotFound();
            }
            return View(folha);
        }

        // GET: Folhas/Create
        public ActionResult Create()
        {
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome");
            return View();
        }

        // POST: Folhas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FolhaID,FuncionarioID,MesAno,QtdHorasTrabalhadas,ValorHora")] Folha folha)
        {
            if (ModelState.IsValid)
            {
                db.Folhas.Add(folha);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome", folha.FuncionarioID);
            return View(folha);
        }

        // GET: Folhas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Folha folha = db.Folhas.Find(id);
            if (folha == null)
            {
                return HttpNotFound();
            }
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome", folha.FuncionarioID);
            return View(folha);
        }

        // POST: Folhas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FolhaID,FuncionarioID,MesAno,QtdHorasTrabalhadas,ValorHora")] Folha folha)
        {
            if (ModelState.IsValid)
            {
                db.Entry(folha).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome", folha.FuncionarioID);
            return View(folha);
        }

        // GET: Folhas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Folha folha = db.Folhas.Find(id);
            if (folha == null)
            {
                return HttpNotFound();
            }
            return View(folha);
        }

        // POST: Folhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Folha folha = db.Folhas.Find(id);
            db.Folhas.Remove(folha);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
