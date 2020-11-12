using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistroAlumnosYProfesores.Models;
using RegistroAlumnosYProfesores.Services;

namespace RegistroAlumnosYProfesores.Controllers
{
    public class HomeController : Controller
    {
        private AlumnoService _alumnoService;
        private ProfesorService _profesorService;

        public HomeController(AlumnoService alumnoService, ProfesorService profesorService)
        {
            _alumnoService = alumnoService;
            _profesorService = profesorService;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel
            {
                Alumnos = _alumnoService.GetAlumnos(),
                Profesores = _profesorService.GetProfesores()
            };

            return View(viewModel);
        }

        public IActionResult Color()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
