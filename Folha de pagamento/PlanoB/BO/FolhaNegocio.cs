using BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanoB.BO
{
    public class FolhaNegocio
    {
        public static float calculoBruto(Folha folha)
        {
            return folha.QtdHorasTrabalhadas * folha.ValorHora;
        }

        public static float calculoIr(float bruto)
        {
            if (bruto <= 1903.98)
            {
                return 0;
            }
            else
            {
                if (bruto <= 2826.65)
                {
                    return (float)((bruto * 7.5 / 100) - 142.80);
                }
                else
                {
                    if (bruto <= 3751.05)
                    {
                        return (float)((bruto * 15 / 100) - 354.80);
                    }
                    else
                    {
                        if (bruto <= 4664.68)
                        {
                            return (float)((bruto * 22.5 / 100) - 636.13);
                        }
                        else
                        {
                            return (float)((bruto * 27.5 / 100) - 869.36);
                        }
                    }
                }
            }
        }
        public static float calculoInss(float bruto)
        {
            if (bruto <= 1399.12)
            {
                return (float)bruto * 8 / 100;
            }
            else
            {
                if (bruto <= 2331.88)
                {
                    return bruto * 9 / 100;
                }
                else
                {
                    if (bruto <= 4663.75)
                    {
                        return bruto * 11 / 100;
                    }
                    else
                    {
                        return (float)(bruto - 513.01);
                    }
                }
            }
        }

        public static float calculoFgts(float bruto)
        {
            return bruto * 8 / 100;
        }

        public static float salarioLiquido(float bruto, float ir, float inss)
        {
            return bruto - ir - inss;
        }

    }
}