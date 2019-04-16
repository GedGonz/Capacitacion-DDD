using NegocioPRG.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPRG.Contexto
{
    public class RPGContexto:DbContext
    {
        public RPGContexto():base("name=BDContext")
        {

        }

        public DbSet<Persona> Persona { get; set; }
    }
}
