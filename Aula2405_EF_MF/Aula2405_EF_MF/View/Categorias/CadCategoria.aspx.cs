using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aula2405_EF_MF.Model;
using Aula2405_EF_MF.Dao;

namespace Aula2405_EF_MF.View.Categorias
{
    public partial class CadCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Nome = txtNome.Text;
            cat.Descricao = txtDescricao.Text;
            CatDao.Incluir(cat);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDescricao.Text = "";

        }
    }
}