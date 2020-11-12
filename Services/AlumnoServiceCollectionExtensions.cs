using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace RegistroAlumnosYProfesores.Services
{
    public static class AlumnoServiceCollectionExtensions
    {
        public static IServiceCollection AddAlumnoService(this IServiceCollection services)
        {
            services.AddScoped<AlumnoService>();

            return services;
        }
    }
}
