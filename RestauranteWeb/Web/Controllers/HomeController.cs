using System.Web.Mvc;
using System.Web.Security;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TornarAdmin()
        {
            Roles.AddUserToRole(User.Identity.Name, "Dono");

            return RedirectToAction("Index");

        }
    }
}