using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_DIP.CodigoDesacoplado;

namespace UI_DIP
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Codigo Acoplado
            //var Soladado1 = new Soldado1();
            //var Disparo = Soladado1.DispararEscopeta();
            //Console.WriteLine("Soldado Ataca!!.. " + Disparo);
            //Console.ReadLine();


            //Codio Desacoplado
            var Arma_Rifle = new Rifle2();
            var Arma_Revolver = new Revolver2();
            var Arma_Basuca = new Basuca();

            var Soldado2 = new Soldado2(Arma_Basuca);
            var Disparo = Soldado2.Disparar();
            Console.WriteLine("Soldado Ataca!!.. " + Disparo);
            Console.ReadLine();

        }
    }
}
