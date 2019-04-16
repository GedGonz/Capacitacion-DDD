using PracticaDI.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI.Repositorio
{
    public class Auto : IAuto
    {
        private bool encedido = false;
        private readonly IMotor Motor;
        public Auto(IMotor Motor)
        {
            this.Motor = Motor;
        }

        public void Encender()
        {

            if (Motor.EstaEncendido())
            {
                encedido = true;
                Console.WriteLine("Motor Encendido: RRRRRNNNN");
            }
            else
            {
                encedido = false;
                Console.WriteLine("Motor No Enciende");
                Console.WriteLine("Indicador que falta Aceite o Gasolina");
            }

        }

        public void Arrancar()
        {
           
            if (encedido)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Auto en Marcha..");
                Console.WriteLine("-------------------------------");

                Console.WriteLine(@"         
                                             ___________
                                            //    ||  \ \
                                     _____ // ___ || _ \ \ ___
                                     ) _ _ \
                                     | _ / \ ________ / \ ___ |
                                    ___ \ _ / ________ \ _ / ______");


            }
            else
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Auto no se pudo poner en Marcha");
            }
        }

        
    }
}
