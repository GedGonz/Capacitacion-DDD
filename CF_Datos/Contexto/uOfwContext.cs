using CF_Negocio.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF_Datos.Contexto
{
    public class uOfwContext:DbContext
    {
        public uOfwContext():base("name=BDContext")
        {

        }

        public DbSet<Persona> Persona { get; set; }
    }
}
