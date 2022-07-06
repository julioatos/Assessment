using Assessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PruebasUnitarias
{
    public class PruebasCalculadora
    {
        [Fact]
        public void Suma_CalculosCorrectos()
        {
            double expected = 5;

            double actual = Calculadora.Suma(3, 2);

            Assert.Equal(expected, actual);
        }
    }
}
