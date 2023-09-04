using Microsoft.AspNetCore.Mvc;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Marry";
            ViewBag.FV = 99999.99;
            return View();
        }
    }
}
