using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalculaArea
{
    public class Circulo
    {
        //Atributos
        public double Raio { get; private set; }
        public double Area { get; private set; }
        const double Pi = 3.14;

        //Construtor
        public Circulo()
        {

        }

        public Circulo(double valor)
        {
            Raio = valor;
        }

        //Método
        public void CalculaArea()
        {
            Area = Raio * Pi;
        }

        public override string ToString()
        {
            return "A área do círculo é " + Area.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
