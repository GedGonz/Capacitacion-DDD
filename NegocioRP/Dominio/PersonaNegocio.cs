using NegocioRP.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRP.Dominio
{
    public class PersonaNegocio
    {
        private readonly IPersonaRepositorio PersonaRepositorio;
        public PersonaNegocio(IPersonaRepositorio PersonaRepositorio)
        {
            this.PersonaRepositorio = PersonaRepositorio;
        }

        public void Guardar(Persona persona)
        {
            PersonaRepositorio.Guardar(persona);
        }

        public List<Persona> Lista()
        {
            return PersonaRepositorio.Lista();
        }
    }
}
