using Aula1406.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula1406.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias (GET = Carregamento da pagina)
        public ActionResult Index()
        {
            //retornar a lista de objetos cadastrados
            List<Categoria> categorias = new List<Categoria>();
            return View();
        }
        public ActionResult Create()
        {
            
            return View();
        }
        //POST (vem do formulario para ca)
        [HttpPost]
        public ActionResult Create(Categoria Categoria)/*, FormCollection campos) recuperar campo a campo sem ter model*/
        {
            //FormCollection campos nao precisa de uma class e pega todos os campos
            /*(ex:string nome)se o nome do campo e o tipo dele for igual tbm salva */

            if (ModelState.IsValid)//(valida as informaçoes que vao para o bancoalu)atende todas as requisiçoes padrao mvc é tipado
            {
                //insert


            }
            return View(Categoria);
        }
        //GET
        public ActionResult Edit(int? id) // o interrogação é nulo ou um numero
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);// retornar um erro esse é o caminho
            }
            //pesquisa na fonte de dados o objetio a editar
           // Categoria cat = null; simuletion
           Categoria cat = new Categoria(){ Nome="CARROS",Descricao="Super carros",CategoriaID = id.Value , Ativo=true};
            //se o objeto nao foi encontrado na fonte de dados
            if(cat == null)
            {
                //Error - 404
                return HttpNotFound();
            }
            return View();
        }
        //POSt
        public ActionResult Edit(Categoria cat)
        {
            try
            {
                //fazer um update na fonte dee dados
                //Redirecionar
            }
            catch (Exception e)
            {
                throw e;
            }
            if (ModelState.IsValid)
            {
              
            }
            return View(cat);
        }
        //GET
        public ActionResult Delete(int?id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Categoria cat = null;
            Categoria cat = new Categoria() { Nome = "CARROS", Descricao = "Super carros", CategoriaID = id.Value, Ativo = true };
            if (cat == null)
            {
                return HttpNotFound();
            }
            return View();
        }
        //POST
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            // pesquisar objeto por id

            //alterar status do objeto para deleted ou ativo para false

            TempData["Messagem"] = ("Categoria excluida com sucesso");
            return RedirectToAction("Index");
        }
    }
}