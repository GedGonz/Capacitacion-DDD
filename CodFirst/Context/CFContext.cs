using CodFirst.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodFirst.Context
{
    public class CFContext:DbContext
    {
        public CFContext():base("name=BDContext")
        {

        }

        public DbSet<Persona> Persona { get; set; }
    }
}
