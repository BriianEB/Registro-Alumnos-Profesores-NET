using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroAlumnosYProfesores.Models;
using RegistroAlumnosYProfesores.Data;

namespace RegistroAlumnosYProfesores.Services
{
    public class ProfesorService
    {
        private readonly AppDbContext _context;

        public ProfesorService(AppDbContext context)
        {
            _context = context;
        }

        public IList<ProfesorModel> GetProfesores()
        {
            return _context.Profesores.ToList();
        }

        public void AddProfesor(ProfesorModel profesor)
        {
            _context.Add(profesor);
            _context.SaveChanges();
        }

        public ProfesorModel GetProfesor(string noEmpleado)
        {
            return _context.Profesores.FirstOrDefault(p => p.NoEmpleado == noEmpleado);
        }
    }
}
