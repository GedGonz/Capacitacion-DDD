using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NegocioPRG.Dominio;
using DatosPRG.Repositorio;

namespace UnitTest
{
    [TestClass]
    public class PersonaNegocioTest
    {
        [TestMethod]
        public void ListarPersonasTest()
        {
            var PersonaRepositorio = new PersonaRepositorio();
            var Resultad = new PersonaNegocio(PersonaRepositorio).ListarPersonas();

            Assert.IsNotNull(Resultad);
        }
    }
}
