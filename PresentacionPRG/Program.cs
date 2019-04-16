using Autofac;
using IoCPRG;
using NegocioPRG.Contratos;
using NegocioPRG.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionPRG
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new ContainerBuilder();
            var build=Contenedor.contains(container).Build();

            var repositorio = build.Resolve<IPersonaRepositorio>();

            var persona = new PersonaNegocio(repositorio);
            var Lista = persona.ListarPersonas();
        }
    }
}
