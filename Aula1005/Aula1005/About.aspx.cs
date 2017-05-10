using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1005
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verifica se a pagina irá recarregar novamente
            //Estou na página e disparo um evento
            if (!IsPostBack)
            {

            }
        }
    }
}