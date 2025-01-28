using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SumarNumerosGet
        (int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["MENSAJE"] = "La suma de "
                + numero1 + " + " + numero2
                + " = " + suma;
            return View();
        }

        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            //DEBEMOS DEVOLVER UN OBJETO COMPLEJO CON
            //UNA LISTA DE NÚMEROS
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if (numero % 2 == 0) 
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            //DEVOLVEMOS EL MODEL A LA VISTA
            return View(numeros);
        }

        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult
            SumarNumerosPost(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["MENSAJE"] = "La suma de "
                + numero1 + " + " + numero2
                + " = " + suma;
            return View();
        }

        public IActionResult TablaMultiplicarSimple()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarSimple(int numero)
        {
            // LISTA PARA ALMACENAR LOS RESULTADOS DE LA TABLA
            List<int> numeros = new List<int>();

            // GENERAR LA TABLA DE MULTIPLICAR DESDE 1 HASTA 10
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(numero * i);
            }

            // DEVOLVEMOS EL MODEL A LA VISTA
            return View(numeros);
        }

    }
}
