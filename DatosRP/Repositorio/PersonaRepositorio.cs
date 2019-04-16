using DatosRP.Contexto;
using NegocioRP.Dominio;
using NegocioRP.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosRP.Repositorio
{
    public class PersonaRepositorio: IPersonaRepositorio
    {
        public void Guardar(Persona persona)
        {
            using (var conexion=new RPContexto())
            {
                conexion.Persona.Add(persona);
                conexion.SaveChanges();
            }
        }

        public List<Persona> Lista()
        {
            var Lista = new List<Persona>();
            using (var conexion = new RPContexto())
            {
                Lista = conexion.Persona.ToList();
            }

            return Lista;
       }
    }
}
