using CalculadoraBET6;

namespace TesteMsTest
{
    [TestClass]
    public class TesteCalcMsTest
    {
        [TestMethod]
        public void TesteSomarDoisNumeros()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - Ação
            var resultado = Calculadora.Somar(pNum, sNum);


            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }


        [DataTestMethod]
        [DataRow(1, 2, 4)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 5, 7)]
        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.AreEqual(rNum, resultado);
        }
    }
}