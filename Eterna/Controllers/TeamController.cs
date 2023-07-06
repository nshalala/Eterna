using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            TeamMemberViewModel vm = new TeamMemberViewModel()
            {
                TeamMembers = Data.TeamMembers,
            };
            return View(vm);
        }
    }
}
