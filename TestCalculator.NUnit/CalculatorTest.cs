
using Kaizen_UnitTest;
using NUnit.Framework;

namespace TestCalculator.NUnit
{

    [TestFixture]
    public class CalculatorTest
    {
        #region Initialize
        private static Calculadora calculadora;
        private static int Numero_1;
        private static int Numero_2;

        [OneTimeSetUp]
        public static void SetupTestEnvironment()
        {
            calculadora = new Calculadora();
        }

        [OneTimeTearDown]
        public void FinishTestEnvironment()
        {
            calculadora = null;
        }
        #endregion

        #region Test Methods

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
        [Ignore("Test by Kaizen Force")]
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
/*Go to "Tools -> Extensions and Updates -> Online" and search for  "NUnit3 Test Adapter" and then install.*/
