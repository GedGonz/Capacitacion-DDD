using Autofac;
using DatosPRG.Repositorio;
using NegocioPRG.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCPRG
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
