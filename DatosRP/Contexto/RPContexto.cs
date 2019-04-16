using NegocioRP.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosRP.Contexto
{
    public class RPContexto:DbContext
    {

        public RPContexto():base("name=BDContext")
        {

        }

        public DbSet<Persona> Persona { get; set; }
    }
}
