using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalculaArea
{
    public class Retangulo
    {

        //atributos
        public double Lado1 { get; private set; }
        public double Lado2 { get; private set; }
        public double Area { get; private set; }

        //construtor
        public Retangulo()
        {

        }

        public Retangulo(double lado1, double lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        //método
        public void CalcularArea()
        {
            Area = Lado1 * Lado2;
        }

        public override string ToString()
        {
            return "O valor da área do retângulo é " + Area.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
