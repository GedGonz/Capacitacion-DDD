using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_DIP
{
    public class Soldado1
    {
        public string DispararRevolver()
        {
            return new Revolver1().Disparar();
        }

        public string DispararRifle()
        {
            return new Rifle1().Disparar();
        }

        public string DispararEscopeta()
        {
            return new Escopeta1().Disparar();
        }
    }
}
