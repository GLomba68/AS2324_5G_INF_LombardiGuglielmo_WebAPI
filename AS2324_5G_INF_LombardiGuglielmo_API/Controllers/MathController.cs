﻿using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_LombardiGuglielmo_API.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("GetMultiplo")]
        public JsonResult GetMultiplo(int num, int factor)
        {

            if(num % factor == 0)
            {
                return Json(new { output = $"Il numero inserito ({num}) è multiplo del secondo numero inserito({factor})", status = "OK" });
            }
            else
            {
                return Json(new { output = $"Il numero inserito ({num})NON è multiplo del secondo numero inserito({factor})", status = "OK" });
            }


        }






    }
    }
}
