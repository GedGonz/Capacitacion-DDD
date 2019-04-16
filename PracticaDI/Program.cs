using PracticaDI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var aceite = new Aceite(100);
            var combustibles = new Combustible(100);
            var motor = new Motor(aceite, combustibles);
            var auto = new Auto(motor);
            auto.Encender();
            auto.Arrancar();
            //Console.ReadLine();
        }
    }
}
