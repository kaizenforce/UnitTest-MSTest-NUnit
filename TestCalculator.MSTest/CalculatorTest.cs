using Kaizen_UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculator.MSTest
{
    [TestClass]
    public class CalculatorTest
    {

        /*
            To Name to Test Method, is recomended use the follow format:
            [EntityName]_[MethodNameToTest]_[BriefDescriptionAboutMethodAndCaseToTest]_[ResultExpect]
        */

        #region Initialize

        private static Calculadora calculadora;
        private static int Numero_1;
        private static int Numero_2;

        [ClassInitialize]
        public static void SetupTestEnvironment(TestContext context)
        {
            calculadora = new Calculadora();            
        }

        [ClassCleanup]
        public static void FinishTestEnvironment()
        {
            calculadora = null;
        }

        #endregion

        #region Test Methods

        [TestMethod]
        public void Calculator_Sumar_RetornaLaSumaDeDosNumerosEnteros_SumaAmbosNumeros()
        {

            //Arrange
            Numero_1 = 10;
            Numero_2 = 15;

            //Act
            int resultado = calculadora.Sumar(Numero_1, Numero_2);

            //Assert
            Assert.AreEqual(resultado, 25);
        }

        [TestMethod]
        public void Calculator_Restar_RetornaLaRestaDeDosNumerosEnteros_DiferenciaAmbosNumeros()
        {

            //Arrange
            Numero_1 = 50;
            Numero_2 = 30;

            //Act
            int resultado = calculadora.Restar(Numero_1, Numero_2);

            //Assert
            Assert.AreEqual(resultado, 20);
        }

        [TestMethod]
        public void Calculator_Multiplicar_RetornaElProductoDeDosNumerosEnteros_ProductoAmbosNumeros()
        {

            //Arrange
            Numero_1 = 15;
            Numero_2 = 4;

            //Act
            int resultado = calculadora.Multiplicar(Numero_1, Numero_2);

            //Assert
            Assert.AreEqual(resultado, 60);
        }

        [TestMethod]
        public void Calculator_Dividir_RetornaDivisionDeDosNumerosEnteros_DivisionAmbosNumeros()
        {

            //Arrange
            Numero_1 = 60;
            Numero_2 = 12;

            //Act
            int resultado = calculadora.Dividir(Numero_1, Numero_2);

            //Assert
            Assert.AreEqual(resultado, 5);
        }

        [TestMethod]
        public void Calculator_Dividir_RetornaDivisionDeDosNumerosEnteros_Cero()
        {

            //Arrange
            Numero_1 = 0;
            Numero_2 = 4;

            //Act
            int resultado = calculadora.Dividir(Numero_1, Numero_2);

            //Assert
            Assert.AreEqual(resultado, 0);
        }

        [TestMethod]
        [Ignore()]
        public void Calculator_Dividir_RetornaDivisionDeDosCeros_Ignore()
        {

            //Arrange
            Numero_1 = 0;
            Numero_2 = 0;

            //Act
            int resultado = calculadora.Dividir(Numero_1, Numero_2);

            //Assert
            Assert.AreEqual(resultado, 0);
        }

        #endregion
    }
}
