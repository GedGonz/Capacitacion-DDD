using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class Venta
    {
        public string RealizarVenta()
        {
            var vendida = false;
            var Mensaje = string.Empty;

            if (paraVenta())
            {
                vendida = new Factura().Guardar();
                Mensaje = (vendida) ? "Se realizo la Venta!" : "Ocurrio un Problema en la Venta!";
            }
            else
            {
                Mensaje = "No existe Stock suficiente!";
            }

            return Mensaje;
        }

        public bool paraVenta()
        {
            var stock = 0;
            return (stock > 0) ? true : false;
        }
    }
}
