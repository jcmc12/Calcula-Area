using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalculaArea.Classes
{
    public class Trapezio
    {
        //atributos
        public double BaseMaior { get; private set; }
        public double BaseMenor { get; private set; }
        public double Altura { get; private set; }
        public double Area { get; private set;}

        //construtor
        public Trapezio()
        {

        }

        public Trapezio(double baseMaior, double baseMenor, double altura)
        {
            BaseMaior = baseMaior;
            BaseMenor = baseMenor;
            Altura = altura;
        }

        //metodo
        public void CalcularArea()
        {
            Area = ((BaseMaior + BaseMenor) * Altura) / 2;
        }

        public override string ToString()
        {
            return "A área do trapézio é " + Area.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
