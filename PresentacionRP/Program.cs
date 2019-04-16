using Autofac;
using IoCRP;
using NegocioRP.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            Contenedor.contains(builder);

            IContainer Container = builder.Build();

            var repositorio = Container.Resolve<IPersonaRepositorio>();
            var personanegocio = new PersonaNegocio(repositorio);

            var Lista = personanegocio.Lista();

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
