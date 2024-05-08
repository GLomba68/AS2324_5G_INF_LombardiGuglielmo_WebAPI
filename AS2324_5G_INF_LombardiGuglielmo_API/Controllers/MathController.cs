using Microsoft.AspNetCore.Mvc;

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

            


        }






    }
    }
}
