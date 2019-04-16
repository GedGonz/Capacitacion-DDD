using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaDI;

namespace UnitTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void Maintest()
        {
            var array = new string[0];
            Program.Main(array);
        }
    }
}
