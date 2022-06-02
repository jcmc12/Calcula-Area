using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculaArea.Classes
{
    class Verificacao
    {
        public static bool Numero(string valor)
        {
            if (valor.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool NumeroMenu(int valor)
        {
            if(valor > 7 || valor < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool NumeroMenuCores(int valor)
        {
            if (valor > 14 || valor < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string NumeroQuebrado(string valor)
        {
            string[] numero;
            //string[] numeroVirgula = valor.Split(',')

            for (int i = 0; i < valor.Length; i++)
            {
                if(valor[i] == '.')
                {
                    numero = valor.Split('.');
                    return numero[0] + numero[1];
                }
                else if (valor[i] == ',')
                {
                    numero = valor.Split(',');
                    return numero[0] + numero[1];
                }
            }

            return valor;
        }
    }
}
