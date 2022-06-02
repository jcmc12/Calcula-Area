using CalculaArea;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TesteCalculaArea
{
    
    public class TesteQuadrado
    {
        [Fact]
        public void TesteCalcularAreaQuadrado()
        {
            //Arrange
            double Lado1 = 4.0;
            double Lado2 = 4.0;

            Quadrado quadrado = new Quadrado(Lado1, Lado2);

            //Act
            double AreaEsperada = Lado1 * Lado2;
            quadrado.CalcularArea();
            double AreaObservada = quadrado.Area;

            //Método

            Assert.Equal(AreaEsperada, AreaObservada);
        }
    }
}
