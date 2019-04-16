using CF_Negocio.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF_Negocio.Contratos
{
    public interface IPersonaRepositorio: IBaseRepositorio<Persona>
    {
        IEnumerable<Persona> ListaPersona();
    }
}
