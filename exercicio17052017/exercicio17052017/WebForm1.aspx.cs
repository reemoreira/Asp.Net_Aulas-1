using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercicio17052017
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public double Valor {
            get
            {
                return Convert.ToDouble(ViewState["Valor"]);
            }
            set
            {
                ViewState["Valor"] = value;
            }

        }
        public double Valortwo {
            get
            {
                return Convert.ToDouble(ViewState["Valortwo"]);
            }
            set
            {
                ViewState["Valortwo"] = value;
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Valor = 0;
                Valortwo = 0;
     
            }
        }

        protected void btnSoma_Click(object sender, EventArgs e)
        {
            Valor =double.Parse( txtValor.Text);
            Valortwo = double.Parse(txtValortwo.Text);
            double Result = Valor + Valortwo;
            txtSomaresult.Text = Result.ToString();
            
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            Session.Add("Valor", Valor);
            Session.Add("Valortwo", Valortwo);

            Response.Redirect("~/WebForm2");
        }
    }
}