using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Venta
    {
        private IFactura Factura;

        public Venta(IFactura Factura)
        {
            this.Factura = Factura;
        }

        public Venta()
        {

        }
        public string RealizarVenta()
        {
            var vendida = false;
            var Mensaje = string.Empty;

            if (paraVenta())
            {
                vendida = Factura.Guardar();
                Mensaje = (vendida) ? "Se realizo la Venta!" : "Ocurrio un Problema en la Venta!";
            }
            else
            {
                Mensaje = "No existe Stock suficiente!";
            }

            return Mensaje;
        }

        private bool paraVenta()
        {
            var stock = 10;
            return (stock > 0) ? true : false;
        }
    }
}
