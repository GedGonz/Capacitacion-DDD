using Autofac;
using IoCP;
using NegocioP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var content = new ContainerBuilder();
            Contenedor.content(content);
            IContainer Container = content.Build();
            var SQL = Container.Resolve<IBaseDatos>();


            BasedeDato BD = new BasedeDato(SQL);
            BD.AddData("Dato");
            Console.ReadLine();
        }
    }
}
