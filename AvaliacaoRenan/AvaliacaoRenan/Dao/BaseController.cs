using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AvaliacaoRenan.Model;

namespace AvaliacaoRenan.Dao
{
    public class BaseController
    {
        static protected BaseDadosContainer contexto = new BaseDadosContainer();
    }
}