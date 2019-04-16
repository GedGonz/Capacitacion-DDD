using PracticaDI.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI.Repositorio
{
    public class Motor:IMotor
    {
        private readonly IAceite Aceite;
        private readonly ICombustible Combustible;
        public Motor(IAceite Aceite, ICombustible Combustible)
        {
            this.Aceite = Aceite;
            this.Combustible = Combustible;
        }

        public bool EstaEncendido()
        {
            var EnciendeMotor = false;
            var _aceite = Aceite.Nivel();
            var _combustible = Combustible.Nivel();

            EnciendeMotor = (_aceite && _combustible) ? true : false;

            return EnciendeMotor;
        }
    }
}
