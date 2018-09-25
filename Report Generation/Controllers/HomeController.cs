using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Report_Generation.ViewModels;
using Shodan;
using System.Linq;

namespace Report_Generation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var models = ShodanParser.GetData();
            var viewModels = models.Select(Mapper.Map<ResultViewModel>).Take(20).ToList();

            return View(viewModels);
        }
    }
}
