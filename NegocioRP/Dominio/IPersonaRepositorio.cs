using NegocioRP.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRP.Dominio
{
    public interface IPersonaRepositorio
    {
        void Guardar(Persona persona);
        List<Persona> Lista();
    }
}
