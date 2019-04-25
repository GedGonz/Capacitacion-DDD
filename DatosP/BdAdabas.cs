using NegocioP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosP
{
    public class BdAdabas : IBaseDatos
    {
       
        public string AddData()
        {
            return "Dato Insertado: ";
        }

        public string Coneccion()
        {
            return "Conectado a ADABAS!!";
        }
    }
}
