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
    public partial class CadMarcas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvwInativos.DataSource = MarcaController.ListarInativo();
            gvwInativos.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Marca Marca = new Marca();

            Marca.Nome = txtNome.Text;
            Marca.Descricao = txtDescricao.Text;
            Marca.Ativo = true;
            MarcaController.Adicionar(Marca);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtBuscar.Text = "";
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Marca Mar = new Marca();
            Mar = MarcaController.BuscarPorNome(txtBuscar.Text);
            if (Mar != null)
            {
                if (txtNome.Text != Mar.Nome && txtDescricao.Text != Mar.Descricao && Mar.Ativo == true)
                {
                    Mar.Nome = txtNome.Text;
                    Mar.Descricao = txtDescricao.Text;
                    Mar.Ativo =bool.Parse(ddlAtivo.Text); 
                    MarcaController.Editar(Mar);
                }
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Marca Ma = new Marca();
            Ma = MarcaController.BuscarPorNome(txtBuscar.Text);
            if (Ma != null)
            {
                if (Ma.Ativo == true)
                {
                    Ma.Ativo = false;
                    MarcaController.Excluir(Ma);
                }                
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Marca Marc = new Marca();
            // Marca.Nome = txtBuscar.Text;
            Marc = MarcaController.BuscarPorNome(txtBuscar.Text);
            if (Marc != null)
            {
                txtNome.Text = Marc.Nome;
               txtDescricao.Text = Marc.Descricao;
                ddlAtivo.Text = Marc.Ativo.ToString();
            }
           
        }
    }
}