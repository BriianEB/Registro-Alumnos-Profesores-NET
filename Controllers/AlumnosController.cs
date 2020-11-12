using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistroAlumnosYProfesores.Models;
using RegistroAlumnosYProfesores.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegistroAlumnosYProfesores.Controllers
{
    public class AlumnosController : Controller
    {
        private AlumnoService _alumnoService;

        public AlumnosController(AlumnoService alumnoService)
        {
            _alumnoService = alumnoService;
        }

        // GET: /<controller>/
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registrar([Bind("Matricula,Nombre,Carrera,Email,Telefono")] AlumnoModel alumno)
        {
            if (ModelState.IsValid)
            {
                _alumnoService.AddAlumno(alumno);

                return RedirectToAction("Index", "Home");
            }

            return View(alumno);
        }

        public IActionResult Ver(int id)
        {
            string matricula = id.ToString();

            if (matricula == null)
            {
                return NotFound();
            }

            var alumno = _alumnoService.GetAlumno(matricula);

            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }
    }
}
