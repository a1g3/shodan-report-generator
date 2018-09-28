using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Report_Generation.ViewModels;
using Shodan;
using Shodan.Models;
using System.Linq;

namespace Report_Generation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var models = ShodanParser.GetData().Where(x => x is Https);
            var viewModels = models.Select(Mapper.Map<ResultViewModel>).ToList();

            return View(viewModels);
        }
    }
}
