using CalculaArea;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TesteCalculaArea
{
    public class TesteRetangulo
    {
        [Fact]
        public void TesteCalcularAreaRetangulo()
        {
            //Arrange
            double Lado1 = 7.0;
            double Lado2 = 5.0;

            Retangulo retangulo = new Retangulo(Lado1, Lado2);

            //Act
            double AreaEsperada = Lado1 * Lado2;
            retangulo.CalcularArea();
            double AreaObservada = retangulo.Area;

            //Assert
            Assert.Equal(AreaEsperada, AreaObservada);

        }
    }
}
