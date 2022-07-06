using Assessment;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ComprobarOpSuma()
        {
            double expected = 5;
            double actual = Calculadora.Suma(3, 4);

            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void ComprobarOpResta()
        {
            double expected = 0;

            double actual = Calculadora.Resta(1, 1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ComprobarOpMult()
        {
            double expected = 10;
            double actual = Calculadora.Multiplicacion(5,2);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ComprobarOpDiv()
        {
            double expected = 10;
            double actual = Calculadora.Division(100,10);

            Assert.Equal(expected, actual);
        }
    }
}
