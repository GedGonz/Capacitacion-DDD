using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaDI.Repositorio;

namespace UnitTest
{
    [TestClass]
    public class AutoTest
    {
        [TestMethod]
        public void EncenderVoid()
        {
            var aceite = new Aceite(100);
            var combustibles = new Combustible(100);
            var motor = new Motor(aceite, combustibles);

            var Resultado = new Auto(motor);
            Resultado.Encender();
        }
        [TestMethod]
        public void NoEncenderVoid()
        {
            var aceite = new Aceite(0);
            var combustibles = new Combustible(100);
            var motor = new Motor(aceite, combustibles);

            var Resultado = new Auto(motor);
            Resultado.Encender();
        }

        [TestMethod]
        public void ArrancarVoid()
        {
            var aceite = new Aceite(100);
            var combustibles = new Combustible(100);
            var motor = new Motor(aceite, combustibles);

            var Resultado = new Auto(motor);
            Resultado.Encender();
            Resultado.Arrancar();
        }
        [TestMethod]
        public void NoArrancarVoid()
        {
            var aceite = new Aceite(0);
            var combustibles = new Combustible(0);
            var motor = new Motor(aceite, combustibles);

            var Resultado = new Auto(motor);
            Resultado.Arrancar();
        }
    }
}
