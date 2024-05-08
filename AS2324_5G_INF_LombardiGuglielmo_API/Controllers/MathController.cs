using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System;

namespace AS2324_5G_INF_LombardiGuglielmo_API.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Getmultiplointero")]
        public JsonResult Getmultiplointero(int num, int factor)
        {

            if(factor % num == 0)
            {
                return Json(new { output = $"Il numero inserito ({num}) è multiplo del secondo numero inserito({factor})", status = "OK" });
            }
            else
            {
                return Json(new { output = $"Il numero inserito ({num}) NON è multiplo del secondo numero inserito ({factor})", status = "OK" });
            }


        }

        [HttpGet("Getipotenusa")]
        public JsonResult Getipotenusa(double cateto1, double cateto2)
        {
            return Json(new { output = $"Il valore dell' ipotenusa è : " + Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2)) , status = "OK" });
        }

        [HttpGet("Getpotenza")]
        public JsonResult Getpotenza(int b, int esponente)
        {
            int risultato = b;
            for (int i = 1; i<esponente;i++)
            {
                risultato *= b;
            }
            return Json(new { output = $"Il valore della potenza : {b}^{esponente} è = {risultato}", status = "OK" });
        }
    }
}

