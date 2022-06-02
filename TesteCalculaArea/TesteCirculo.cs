using Xunit;
using System;
using CalculaArea;

namespace TesteCalculaArea
{
    public class TesteCirculo
    {
        [Fact]
        public void TesteCalcularAreaCirculo()
        {
            //Arrange
            double Raio = 4.0;
            const double Pi = 3.14;
            Circulo circulo = new Circulo(Raio);

            //Act
            double AreaEsperada = Raio * Pi;
            circulo.CalculaArea();
            double AreaObservada = circulo.Area;

            //Assert
            Assert.Equal(AreaEsperada, AreaObservada);
        }
    }
}
