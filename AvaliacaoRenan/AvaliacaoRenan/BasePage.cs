using AvaliacaoRenan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoRenan
{
    public class BasePage : System.Web.UI.Page
    {
         protected BaseDadosContainer contexto = new BaseDadosContainer();   
    }
}