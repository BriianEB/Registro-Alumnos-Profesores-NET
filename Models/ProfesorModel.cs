using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroAlumnosYProfesores.Models
{
    public class ProfesorModel
    {
        [Key]
        [Required]
        [Display(Name = "Número de empleado")]
        public string NoEmpleado { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Carrera { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }
    }
}
