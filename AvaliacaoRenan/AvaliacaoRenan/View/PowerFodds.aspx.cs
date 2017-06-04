using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AvaliacaoRenan.Model;
using AvaliacaoRenan.Dao;

namespace AvaliacaoRenan.View
{
    public partial class PowerFodds : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvwSuplemento.DataSource = SuplementoController.Listar();
            gvwSuplemento.DataBind();

            gvwMarcas.DataSource = MarcaController.Listar();
            gvwMarcas.DataBind();
        }

        protected void ddlTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListarPor()
        {
            Suplemento Sup = new Suplemento();
            Sup = SuplementoController.BuscarPorId(ddlTipo.Items.Count);

              if(Sup != null && ddlTipo.Items.Count.Equals("Nome"))
            {
                gvwTipo.DataSource = SuplementoController.Listar().OrderBy(x => x.Nome);
            }
            else
            {
                if(Sup != null && ddlTipo.Items.Count.Equals("Origem"))
                {
                    gvwTipo.DataSource = SuplementoController.Listar().OrderBy(x => x.Origem);
                }
                else
                {
                    gvwTipo.DataSource = SuplementoController.Listar().OrderBy(x => x.Forma);
                }
            }
        }
    }
}