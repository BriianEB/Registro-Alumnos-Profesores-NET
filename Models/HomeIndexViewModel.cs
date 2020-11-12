using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroAlumnosYProfesores.Models
{
    public class HomeIndexViewModel
    {
        public IList<AlumnoModel> Alumnos { get; set; }
        public IList<ProfesorModel> Profesores { get; set; }
    }
}
