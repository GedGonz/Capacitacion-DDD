using NegocioPRG.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioPRG.Contratos
{
    public interface IPersonaRepositorio:IBaseRepositorio<Persona>
    {
        IEnumerable<Persona> ListaPersonas();
    }
}
