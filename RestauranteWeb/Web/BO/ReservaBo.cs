using BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Controllers;

namespace Web.BO
{
    public class ReservaBo
    {
        public static string VerificarLugarPessoa(Mesa mesa, int QtdPessoas)
        {
            if(mesa.QtdCadeiras == QtdPessoas)
            {
                return "reserva atendida com sucesso";
            }         
            else
            {
                return "Infelizmente há reserva não pode ser efetuada pois o numero de pessoas está a cima do que o estabelecimento tem disponivel";
            }
        }
      /*  public static string VerificarSlotsVagos(Mesa mesa)
        {
            List<Mesa> mesas =  MesasController.Index();
            if (mesas != null)
            {
                foreach (Mesa x in mesas)
                {
                    return x.Numero.ToString();
                }
            }
            else
            {
                    return "não há mais mesas disponiveis.";
            }
            return null;
        }*/

        //como fazer para passar um cliente para buscar e atribuir os pontos e salvar no banco
        public static string AdicionarPontos(Cliente cli)
        {
            if (cli.Pontos == 0)
            {
                cli.Pontos = 1;

            }else
            {
             // cli = ClientesController.Buscar(nome do cliente que esta logado);
               int acum = cli.Pontos+50;

                cli.Pontos = acum;
             // ClientesController.Edit(cli);
                return "mais 50 pontos foram atribuidos";
            }
            return null;
        }
    }
}