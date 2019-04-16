using Autofac;
using Business;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class Contenedor
    {
        public static ContainerBuilder contains(ContainerBuilder container)
        {


            container.RegisterType(typeof(Factura)).As(typeof(IFactura)).InstancePerLifetimeScope();

            return container;
        }
    }
}
