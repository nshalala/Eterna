using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class TeamController : Controller
    {
        private EternaDbContext _context;
        public TeamController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            TeamMemberViewModel vm = new TeamMemberViewModel()
            {
                TeamMembers = _context.TeamMembers.ToList(),
            };
            return View(vm);
        }
    }
}
