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
    public partial class CadSuplementos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            
            gvwInativos.DataSource= SuplementoController.ListarInativo();
            gvwInativos.DataBind();

            gvwMarcas.DataSource = MarcaController.Listar();
            gvwMarcas.DataBind();           
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Suplemento Suple = new Suplemento();
            
            Suple.Nome = txtNome.Text;
            Suple.Descricao = txtDescricao.Text;
            Suple.Marca = MarcaController.BuscarPorNome(txtMarca.Text);
            Suple.Forma = txtForma.Text;
            Suple.Origem = ddlOrigem.Text;
            Suple.Ativo = true;
            SuplementoController.Adicionar(Suple);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtMarca.Text = "";
            txtForma.Text = "";
            txtBuscar.Text = "";
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Suplemento Sup = new Suplemento();           
            Sup = SuplementoController.BuscarPorNome(txtBuscar.Text);
            if (Sup != null)
            {
                txtNome.Text = Sup.Nome;
                txtDescricao.Text = Sup.Descricao;
                txtMarca.Text = Sup.Marca.ToString();
                ddlOrigem.Text = Sup.Origem.ToString();
                txtForma.Text = Sup.Forma;
            }
        }

        protected void btnExucluir_Click(object sender, EventArgs e)
        {
            Suplemento Sup = new Suplemento();
            Sup = SuplementoController.BuscarPorNome(txtBuscar.Text);
            if (Sup != null)
            {
                if (Sup.Ativo == true)
                {
                    Sup.Ativo = false;
                    SuplementoController.Excluir(Sup);
                }
            }
        }
    }
}