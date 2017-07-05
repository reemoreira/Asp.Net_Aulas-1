using PlanoB.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlanoB.Controllers
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
        private Relatorio getRelatorio()
        {
            var rpt = new Relatorio();
            rpt.BasePath = Server.MapPath("/");

            rpt.PageTitle = "Relatório de Duplicatas";
            rpt.PageTitle = "Relatório de Duplicatas";
            rpt.ImprimirCabecalhoPadrao = true;
            rpt.ImprimirRodapePadrao = true;

            return rpt;
        }

        public ActionResult Preview()
        {
            var rpt = getRelatorio();

            return File(rpt.GetOutput().GetBuffer(), "application/pdf");
        }

        public FileResult BaixarPDF()
        {
            var rpt = getRelatorio();

            return File(rpt.GetOutput().GetBuffer(), "application/pdf", "Documento.pdf");
        }
    }
}