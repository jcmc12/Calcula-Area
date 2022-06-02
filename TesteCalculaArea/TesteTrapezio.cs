using CalculaArea.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TesteCalculaArea
{
    public class TesteTrapezio
    {
        [Fact]
        public void TesteCalcularAreaTrapezio()
        {
            //Arrange
            double BaseMaior = 10.0;
            double BaseMenor = 5.0;
            double Altura = 2.0;

            Trapezio trapezio = new Trapezio(BaseMaior, BaseMenor, Altura);

            //Act
            double AreaEsperada = ((BaseMaior + BaseMenor) * Altura) / 2;
            trapezio.CalcularArea();
            double AreaObservada = trapezio.Area;

            //Assert
            Assert.Equal(AreaEsperada, AreaObservada);
        }



    }
}
