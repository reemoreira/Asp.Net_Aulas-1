using Aula1206.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1206.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(new Categoria() { Nome = "Carros",Descricao="Super carros de coleção" });
            categorias.Add(new Categoria() { Nome = "Barcos", Descricao = "Flutuantes" });
            categorias.Add(new Categoria() { Nome = "Avioes", Descricao = "Mais Velozes do mundo" });
            categorias.Add(new Categoria() { Nome = "Motos", Descricao = "Moto de duas rodas" });
            categorias.Add(new Categoria() { Nome = "Caminhões", Descricao = "" });

            ViewBag.ListaCategorias = categorias;
            return View(categorias);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Categoria cat)
        {
            return View(cat);
        }
    }
}