using Calculos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosNUnitTest
{
    [TestFixture]
    public class CalculoTest
    {
        [Test]
        public void SomarDoisDouble_RetornarDouble()
        {
            //Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 6;

            //Act
            var soma = Calculo.Somar(num1, num2);

            //Assert
            Assert.AreEqual(valorEsperado, soma);
        }

        [Test]
        public void SubstraiDoisDouble_RetornarDpuble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = -0.2;

            // Act  
            var subtracao = Calculo.Subtrair(num1, num2);

            //Assert  
            Assert.AreEqual(valorEsperado, subtracao, 1);
        }

        [Test]
        public void MultiplicarDoisDouble_RetornarDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 8.99;

            // Act  
            var mult = Calculo.Multiplicar(num1, num2);

            //Assert  
            Assert.AreEqual(valorEsperado, mult, 2);
        }

        [Test]
        public void DividirDoisDouble_RetornarDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 0.94;

            // Act  
            var div = Calculo.Dividir(num1, num2);

            //Assert  
            Assert.AreEqual(valorEsperado, div, 2);
        }

        [TestCase(1, 2, 3)]
        [TestCase(-4, -6, -10)]
        [TestCase(-2, 2, 0)]
        [TestCase(int.MinValue, 1, int.MinValue + 1)]
        public void SomarDoisNumerosRelativos_RetornarNumeroRelativo(int num1, int num2, int valorEsperado)
        {
            //Act
            var resultado = Calculo.Somar(num1, num2);

            //Assert
            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}
