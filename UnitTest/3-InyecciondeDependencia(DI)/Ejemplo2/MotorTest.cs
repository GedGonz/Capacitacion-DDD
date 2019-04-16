using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaDI.Repositorio;

namespace UnitTest
{
    [TestClass]
    public class MotorTest
    {
        [TestMethod]
        public void EstaEncendidoTrue()
        {
            var Valor_Esperado = true;

            var aceite = new Aceite(100);
            var combustibles = new Combustible(100);
            var motor = new Motor(aceite, combustibles);

            var Valor_Actual = motor.EstaEncendido();

            Assert.AreEqual(Valor_Esperado,Valor_Actual);
        }


        [TestMethod]
        public void EstaEncendidoFalse()
        {
            var Valor_Esperado = false;

            var aceite = new Aceite(0);
            var combustibles = new Combustible(0);
            var motor = new Motor(aceite, combustibles);

            var Valor_Actual = motor.EstaEncendido();

            Assert.AreEqual(Valor_Esperado, Valor_Actual);
        }
    }
}
