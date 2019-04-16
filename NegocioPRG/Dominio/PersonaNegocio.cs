using NegocioPRG.Contratos;
using NegocioPRG.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioPRG.Dominio
{
    public class PersonaNegocio
    {
        private readonly IPersonaRepositorio repositorio;
        public PersonaNegocio(IPersonaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<Persona> ListarPersonas()
        {
            return repositorio.ListaPersonas().ToList();
        }

    }
}
