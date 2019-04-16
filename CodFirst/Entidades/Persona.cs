using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodFirst.Entidades
{
    [Table("Empleado")]
    public class Persona
    {
        public int PersonaId { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
