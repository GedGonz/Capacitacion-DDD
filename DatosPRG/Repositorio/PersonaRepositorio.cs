using NegocioPRG.Contratos;
using NegocioPRG.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DatosPRG.Contexto;

namespace DatosPRG.Repositorio
{
    public class PersonaRepositorio : BaseRepositorio<Persona>, IPersonaRepositorio
    {
        //private readonly DbContext contexto;
        //private readonly DbSet<Persona> Tabla;
        public PersonaRepositorio() : base(new RPGContexto())
        {
        }

        public IEnumerable<Persona> ListaPersonas()
        {
            return Tabla.ToList();
        }
    }
}
