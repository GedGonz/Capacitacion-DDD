using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using IoC;
using Autofac;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            /********************Creando Objeto*********************/

            var Venta = new Venta(new Factura());



            /******************Usando Contenedor IoC*******************/

            var builder = new ContainerBuilder();
            Contenedor.contains(builder);

            IContainer Container = builder.Build();

            var Factura = Container.Resolve<IFactura>();
            var venta = new Venta(Factura);
            

            Console.WriteLine(venta.RealizarVenta());
            Console.ReadLine();



        }


        //public interface IFactura
        //{
        //    bool Guardar();
        //}

        //public class Factura : IFactura
        //{
        //    public bool Guardar()
        //    {
        //        //Codigo de persistencia de Datos con ORM... MYSQL or SQLSERVER
        //        return true;
        //    }
        //}

        //public class Venta
        //{
        //    private IFactura Factura;

        //    public Venta(IFactura Factura)
        //    {
        //        this.Factura = Factura;
        //    }
        //    public string RealizarVenta()
        //    {
        //        var vendida = false;
        //        var Mensaje = string.Empty;

        //        if (paraVenta())
        //        {
        //            vendida = Factura.Guardar();
        //            Mensaje = (vendida) ? "Se realizo la Venta!" : "Ocurrio un Problema en la Venta!";
        //        }
        //        else
        //        {
        //            Mensaje = "No existe Stock suficiente!";
        //        }

        //        return Mensaje;
        //    }

        //    private bool paraVenta()
        //    {
        //        var stock = 10;
        //        return (stock > 0) ? true : false;
        //    }
        //}
    }
}
