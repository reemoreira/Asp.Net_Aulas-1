using Aula2405_EF_MF.Dao;
using Aula2405_EF_MF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2405_EF_MF.View.Categorias
{
    public partial class Lista :BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriasController crtl = new CategoriasController();
            List<Categoria> Lista = crtl.Listar();
            gvCategorias.DataSource = Lista;
         // gvCategorias.DataSource = Lista.OrderBy(x => x.Nome);
            gvCategorias.DataBind();

            gvCategoriasInativas.DataSource = crtl.ListarInativo();
            gvCategoriasInativas.DataBind();

        }
    }
}