using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalculaArea
{
    class Triangulo
    {
        //atributos
        public double Base { get; private set; }
        public double Altura { get; private set; }

        private double Area;

        //construtor
        public Triangulo()
        {

        }

        public Triangulo(double _base, double altura)
        {
            Base = _base;
            Altura = altura;
        }

        //metodo
        public void CalcularArea()
        {
            Area = (Base * Altura) / 2;
        }

        public override string ToString()
        {
            return "A área do triângulo é " + Area.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
