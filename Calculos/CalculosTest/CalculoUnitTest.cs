using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculos;

namespace CalculosTest
{
    public class CalculoUnitTest
    {
        [Fact]
        public void SomarDoisDouble_RetornarDouble()
        {
            //Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 6;

            //Act
            var soma = Calculo.Somar(num1, num2);

            //Assert
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void SubstraiDoisDouble_RetornarDpuble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = -0.2;

            // Act  
            var subtracao = Calculo.Subtrair(num1, num2);

            //Assert  
            Assert.Equal(valorEsperado, subtracao, 1);
        }

        [Fact]
        public void MultiplicarDoisDouble_RetornarDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 8.99;

            // Act  
            var mult = Calculo.Multiplicar(num1, num2);

            //Assert  
            Assert.Equal(valorEsperado, mult, 2);
        }

        [Fact]
        public void DividirDoisDouble_RetornarDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 0.94;   

            // Act  
            var div = Calculo.Dividir(num1, num2);

            //Assert  
            Assert.Equal(valorEsperado, div, 2);
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(-4,-6,-10)]
        [InlineData(-2,2,0)]
        [InlineData(int.MinValue, 1,int.MinValue +1)]
        public void SomarDoisNumerosRelativos_RetornarNumeroRelativo(int num1, int num2, int valorEsperado)
        {
            //Act
            var resultado = Calculo.Somar(num1,num2);

            //Assert
            Assert.Equal(valorEsperado, resultado);
        }
    }
}
