using CalculadoraBET6;
using Xunit;

namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 2;
            double rNum = 3;

            //Act - Ação
            var resultado = Calculadora.Somar(pNum, sNum);


            //Assert - Verificação
            Assert.Equal(rNum, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 5)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }
    }
}