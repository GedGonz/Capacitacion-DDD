using PracticaDI.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI.Repositorio
{
    public class Combustible : ICombustible
    {
        private decimal Tanque;
        private decimal cuarto = 25;

        public Combustible(decimal Tanque)
        {
            this.Tanque = Tanque;
        }
        public bool Nivel()
        {
            var nivel = false;
            nivel = (Tanque >= cuarto) ? true : false;

            return nivel;
        }
    }
}
