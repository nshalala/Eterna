using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private EternaDbContext _context;
        public HomeController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel()
            {
                Features = _context.Features.ToList(),
                Services = _context.Services.ToList(),
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
