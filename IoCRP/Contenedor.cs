using Autofac;
using DatosRP.Repositorio;
using NegocioRP.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCRP
{
    public class Contenedor
    {
        public static ContainerBuilder contains(ContainerBuilder container)
        {


            container.RegisterType(typeof(PersonaRepositorio)).As(typeof(IPersonaRepositorio)).InstancePerLifetimeScope();

            return container;
        }
    }
}
