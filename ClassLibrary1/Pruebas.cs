using Assessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary1
{
    public class Pruebas
    {
        [Fact]
        public void Suma_CalculosCorrectos()
        {
            // Arrange
            double valorEsperado = 5;
            // Act
            double valorVerdadero = Calculadora.Suma(3, 2);
            // Assert
            Assert.Equal(valorEsperado, valorVerdadero);
        }
    }
}
