using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BaseModels;
using Web.Models;
using Web.BO;

namespace Web.Controllers
{
    public class ReservasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //chamar as rn's nas controller
        // GET: Reservas
        public ActionResult Index()
        {
            var reservas = db.Reservas.Include(r => r.Cliente).Include(r => r.Restaurante);
            return View(reservas.ToList());
        }

        // GET: Reservas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        // GET: Reservas/Create
        public ActionResult Create()
        {         
                ViewBag.CLienteID = new SelectList(db.Clientes, "ClienteID", "Nome");
                ViewBag.EstabelecimentoID = new SelectList(db.Estabelecimentos, "EstabelecimentoID", "NameOnwer");
                return View();
        }

        // POST: Reservas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReservaID,QtdPessoas,EstabelecimentoID,CLienteID,MesaID,DataHorario")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                Mesa mesa = db.Mesas.Find(reserva.MesaID);              
                    if (ReservaBo.VerificarLugarPessoa(mesa, reserva.QtdPessoas).Equals("reserva atendida com sucesso"))
                    {
                        ReservaBo.AdicionarPontos(reserva.Cliente);                        
                        db.Reservas.Add(reserva);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View("Não foi possivel realizar reserva!");
                    }                
            }

            ViewBag.CLienteID = new SelectList(db.Clientes, "ClienteID", "Nome", reserva.CLienteID);
            ViewBag.EstabelecimentoID = new SelectList(db.Estabelecimentos, "EstabelecimentoID", "NameOnwer", reserva.EstabelecimentoID);
            return View(reserva);
        }

        // GET: Reservas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            ViewBag.CLienteID = new SelectList(db.Clientes, "ClienteID", "Nome", reserva.CLienteID);
            ViewBag.EstabelecimentoID = new SelectList(db.Estabelecimentos, "EstabelecimentoID", "NameOnwer", reserva.EstabelecimentoID);
            return View(reserva);
        }

        // POST: Reservas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReservaID,QtdPessoas,EstabelecimentoID,CLienteID,MesaID,DataHorario")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reserva).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CLienteID = new SelectList(db.Clientes, "ClienteID", "Nome", reserva.CLienteID);
            ViewBag.EstabelecimentoID = new SelectList(db.Estabelecimentos, "EstabelecimentoID", "NameOnwer", reserva.EstabelecimentoID);
            return View(reserva);
        }

        // GET: Reservas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reserva reserva = db.Reservas.Find(id);
            db.Reservas.Remove(reserva);
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
