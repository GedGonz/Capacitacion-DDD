using PracticaDI.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI.Repositorio
{
    public class Aceite : IAceite
    {
        private decimal Deposito;
        private decimal cuarto = 25;

        public Aceite()
        {

        }
        public Aceite(decimal Deposito)
        {
            this.Deposito = Deposito;
        }

        public bool Nivel()
        {
            var bajo = false;
            bajo = (Deposito >= cuarto) ? true : false;

            return bajo;
        }

    }
}
