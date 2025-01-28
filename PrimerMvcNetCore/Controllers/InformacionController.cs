using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ControladorVista()
        {
            //VAMOS A ENVIAR INFORMACION SIMPLE A NUESTRA VISTA
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 24;
            ViewBag.DiaSemana = "Lunes";
            return View();
        }

        public IActionResult VistaControllerGet
            (string saludo, System.Nullable<int> year)
        {

            if (saludo != null)
            {
                ViewData["DATA"] = "Hola " + saludo
                + " en el año " + year;
            } else
            {
                ViewData["DATA"] = "Aquí no hay nada...";
            }

            if (year != null)
            {
                ViewData["DATA"] = "Hola " + saludo
                + " en el año " + year;
            }
            else
            {
                ViewData["DATA"] = "Aquí no tenemos año...";
            }
            return View();
        }

        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Email = "alumno@email.com";
            persona.Edad = 27;
            return View(persona);
        }

        public IActionResult VistaControllerPost
            (string cajanombre, string cajaemail, int cajaedad)
        {
            ViewData["DATA"] = "Nombre: " + cajanombre
                + ", Email: " + cajaemail
                + ", Edad: " + cajaedad;
            return View();
        }
    }
}
