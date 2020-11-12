using Microsoft.EntityFrameworkCore;
using RegistroAlumnosYProfesores.Models;

namespace RegistroAlumnosYProfesores.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AlumnoModel> Alumnos { get; set; }
        public DbSet<ProfesorModel> Profesores { get; set; }
    }
}
