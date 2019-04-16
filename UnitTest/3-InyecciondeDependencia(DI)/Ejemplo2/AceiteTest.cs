using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaDI.Repositorio;
namespace UnitTest
{
    [TestClass]
    public class AceiteTest
    {


        [TestMethod]
        public void NivelTestContructorNull()
        {
            var Valor_Esperado = false;

            var Aceite = new Aceite();
            var valor_Actual = Aceite.Nivel();

            Assert.AreEqual(Valor_Esperado, valor_Actual);
        }
        [TestMethod]
        public void NivelTestTrue()
        {
            var Valor_Esperado = true;

            var Aceite = new Aceite(100);
            var valor_Actual = Aceite.Nivel();

            Assert.AreEqual(Valor_Esperado,valor_Actual);
        }

        [TestMethod]
        public void NivelTestFalse()
        {
            var Valor_Esperado = false;

            var Aceite = new Aceite(0);
            var valor_Actual = Aceite.Nivel();

            Assert.AreEqual(Valor_Esperado, valor_Actual);
        }
    }
}
