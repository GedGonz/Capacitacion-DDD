using Autofac;
using DatosP;
using NegocioP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCP
{
    public class Contenedor
    {
        public static ContainerBuilder content(ContainerBuilder cont)
        {
            cont.RegisterType(typeof(BdAdabas)).As(typeof(IBaseDatos)).InstancePerLifetimeScope();
           // cont.RegisterType(typeof(BdSql)).As(typeof(IBaseDatos)).InstancePerLifetimeScope();
            return cont;
        }
    }
}
