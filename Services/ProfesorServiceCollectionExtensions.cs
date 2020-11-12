using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace RegistroAlumnosYProfesores.Services
{
    public static class ProfesorServiceCollectionExtensions
    {
        public static IServiceCollection AddProfesorService(this IServiceCollection services)
        {
            services.AddScoped<ProfesorService>();

            return services;
        }
    }
}
