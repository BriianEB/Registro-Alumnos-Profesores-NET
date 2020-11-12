using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroAlumnosYProfesores.Models
{
    public class AlumnoModel
    {
        [Key]
        [Required]
        [Display(Name = "Matrícula")]
        public string Matricula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Carrera { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

    }
}
