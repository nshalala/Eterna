using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel()
            {
                Features = Data.Features,
                Services = Data.Services,
            };
            return View(vm);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
