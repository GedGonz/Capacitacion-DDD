using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using CapaNegocio;

namespace Capa_Datos
{
    public class Factura : IFactura
    {
        public bool Guardar()
        {
            //Codigo de persistencia de Datos con ORM... MYSQL or SQLSERVER
            return true;
        }

       
    }
}
