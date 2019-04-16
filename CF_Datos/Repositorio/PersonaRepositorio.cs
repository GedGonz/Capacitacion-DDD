using CF_Negocio.Contratos;
using CF_Negocio.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CF_Datos.Repositorio
{
    public class PersonaRepositorio : BaseRepositorio<Persona>, IPersonaRepositorio
    {

        public PersonaRepositorio(DbContext contexto) : base(contexto)
        {
        }

        public IEnumerable<Persona> ListaPersona()
        {
            return Tabla.ToList();
        }
    }
}
