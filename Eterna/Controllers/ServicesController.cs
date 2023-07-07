using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class ServicesController : Controller
    {
        private EternaDbContext _context;
        public ServicesController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ServicesViewModel vm = new ServicesViewModel()
            {
                Services = _context.Services.ToList(),
            };
            return View(vm);
        }
    }
}
