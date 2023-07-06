using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            ServicesViewModel vm = new ServicesViewModel()
            {
                Services = Data.Services,
            };
            return View(vm);
        }
    }
}
