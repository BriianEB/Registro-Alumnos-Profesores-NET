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
    public class ProfesoresController : Controller
    {
        private ProfesorService _profesorService;

        public ProfesoresController(ProfesorService profesorService)
        {
            _profesorService = profesorService;
        }

        // GET: /<controller>/
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registrar([Bind("NoEmpleado,Nombre,Carrera,Telefono")] ProfesorModel profesor)
        {
            if (ModelState.IsValid)
            {
                _profesorService.AddProfesor(profesor);

                return RedirectToAction("Index", "Home");
            }

            return View(profesor);
        }

        public IActionResult Ver(int id)
        {
            string noEmpleado = id.ToString();

            if (noEmpleado == null)
            {
                return NotFound();
            }

            var profesor = _profesorService.GetProfesor(noEmpleado);

            if (profesor == null)
            {
                return NotFound();
            }

            return View(profesor);
        }
    }
}
