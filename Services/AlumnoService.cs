using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroAlumnosYProfesores.Models;
using RegistroAlumnosYProfesores.Data;

namespace RegistroAlumnosYProfesores.Services
{
    public class AlumnoService
    {
        private readonly AppDbContext _context;

        public AlumnoService(AppDbContext context)
        {
            _context = context;
        }

        public IList<AlumnoModel> GetAlumnos()
        {
            return _context.Alumnos.ToList();
        }

        public void AddAlumno(AlumnoModel alumno)
        {
            _context.Add(alumno);
            _context.SaveChanges();
        }

        public AlumnoModel GetAlumno(string matricula)
        {
            return _context.Alumnos.FirstOrDefault(a => a.Matricula == matricula);
        }
    }
}
