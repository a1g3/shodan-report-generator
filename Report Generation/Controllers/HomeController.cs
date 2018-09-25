using Microsoft.AspNetCore.Mvc;

namespace Report_Generation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
