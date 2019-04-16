using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_DIP.CodigoDesacoplado
{
    public class Revolver2 : IArma
    {
        public string Disparar()
        {
            return "Pum Pum ..";
        }
    }

    public class Rifle2 : IArma
    {
        public string Disparar()
        {
            return "Pum pum pum pum pum ..";
        }
    }

    public class Escopeta2 : IArma
    {
        public string Disparar()
        {
            return "pum PUMMM !! ..";
        }
    }

}
