using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListaOrdenada.Models;
using Microsoft.AspNetCore.Http;

namespace ListaOrdenada.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public string TrataLista(string numeros)
        {
            var data = Lista(numeros);
            var result = String.Join(",", data);

            return result;
        }

        public int[] Lista(string numeros)
        {
            int[] numerosDesordenados = numeros.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            int[] numerosOrdenados = { };

            try
            {
                Main.ordenarNumeros(numerosDesordenados);

                numerosOrdenados = Main.ordenarNumeros(numerosDesordenados);

                Main.mostrarNumeros(numerosOrdenados);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return numerosOrdenados;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
