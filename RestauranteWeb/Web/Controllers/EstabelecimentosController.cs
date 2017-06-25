using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Web.Models;
using BaseModels;
namespace Web.Controllers
{
    public class EstabelecimentosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Estabelecimentos
        public ActionResult Index()
        {
            return View(db.Estabelecimentos.ToList());
        }

        // GET: Estabelecimentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimentos = db.Estabelecimentos.Find(id);
            if (estabelecimentos == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimentos);
        }

        // GET: Estabelecimentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estabelecimentos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstabelecimentoID,NameOnwer,EmailAddress,PhoneNumber,RestaurantName,RestaurantDescription,RestaurantCity,RestaurantState,RestaurantCountry,RestaurantPostalCode,Ativo")] Estabelecimento estabelecimentos)
        {
            if (ModelState.IsValid)
            {
                db.Estabelecimentos.Add(estabelecimentos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estabelecimentos);
        }

        // GET: Estabelecimentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimentos = db.Estabelecimentos.Find(id);
            if (estabelecimentos == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimentos);
        }

        // POST: Estabelecimentos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstabelecimentoID,NameOnwer,EmailAddress,PhoneNumber,RestaurantName,RestaurantDescription,RestaurantCity,RestaurantState,RestaurantCountry,RestaurantPostalCode,Ativo")] Estabelecimento estabelecimentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estabelecimentos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estabelecimentos);
        }

        // GET: Estabelecimentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimentos = db.Estabelecimentos.Find(id);
            if (estabelecimentos == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimentos);
        }

        // POST: Estabelecimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estabelecimento estabelecimentos = db.Estabelecimentos.Find(id);
            db.Estabelecimentos.Remove(estabelecimentos);
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
