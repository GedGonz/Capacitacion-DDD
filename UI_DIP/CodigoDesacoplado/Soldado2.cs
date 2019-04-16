using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_DIP.CodigoDesacoplado
{
    public class Soldado2
    {
        private readonly IArma arma;

        public Soldado2(IArma _arma)
        {
            this.arma = _arma;
        }

        public string Disparar()
        {



            return arma.Disparar();
        }
    }
}
