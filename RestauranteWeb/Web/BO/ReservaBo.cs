﻿using BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Controllers;

namespace Web.BO
{
    public class ReservaBo
    {
        public static void VerificarLugarPessoa(Mesa mesa, Reserva reserva)
        {
            if(mesa.QtdCadeiras == reserva.QtdPessoas)
            {
               // ReservasController.Creat(Mesa);
                //return "reserva atendida com sucesso";
            }         
            else
            {
                //return "Infelizmente há reserva não pode ser efetuada pois o numero de pessoas está a cima do que o estabelecimento tem disponivel";
            }
        }
        public static void VerificarSlotsVagos(Mesa mesa)
        {
           /*List<Mesa> mesas = MesasController.Index();
            if (!mesas.DefaultIfEmpty)
            {
                foreach (Mesa x in mesas)
                {
                    return "mesas diposniveis:" x.Numero.ToString();
                }
            }
            else
            {
                    return "não há mais mesas disponiveis .";
            }*/
        }


    }
}