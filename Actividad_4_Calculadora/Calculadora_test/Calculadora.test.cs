using Microsoft.VisualStudio.TestTools.UnitTesting;
using Actividad_4_Calculadora.Clases;

namespace CalculadoraApp.Tests
{
    [TestClass]
    public class CalculadoraTests
    {
        private Calculadora calc;

        [TestInitialize]
        public void Setup() 
        {
            calc = new Calculadora();
        }

        [TestMethod]
        public void Sumar_DosNumeros_RetornaSumaCorrecta()
        {
            double resultado = calc.Sumar(5, 3);
            Assert.AreEqual(8, resultado);
        }

        [TestMethod]
        public void Restar_DosNumeros_RetornaRestaCorrecta()
        {
            double resultado = calc.Restar(10, 4);
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void Multiplicar_DosNumeros_RetornaMultiplicacionCorrecta()
        {
            double resultado = calc.Multiplicar(2, 3);
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void Dividir_DosNumeros_RetornaDivisionCorrecta()
        {
            double resultado = calc.Dividir(10, 2);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Dividir_EntreCero_LanzaExcepcion()
        {
            // Solución al problema CS0117: Se reemplaza ThrowsException con Throws.     
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(5, 0));
        }
    }
}
