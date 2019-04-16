using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaDI.Repositorio;

namespace UnitTest
{
    [TestClass]
    public class CombustibleTest
    {
        [TestMethod]
        public void NivelFalse()
        {

            var Valor_Esperado = false;

            var combustible = new Combustible(0);

            var Valor_Actual = combustible.Nivel();

            Assert.AreEqual(Valor_Esperado,Valor_Actual);
        }

        [TestMethod]
        public void NivelTrue()
        {

            var Valor_Esperado = true;

            var combustible = new Combustible(100);

            var Valor_Actual = combustible.Nivel();

            Assert.AreEqual(Valor_Esperado, Valor_Actual);
        }
    }
}
