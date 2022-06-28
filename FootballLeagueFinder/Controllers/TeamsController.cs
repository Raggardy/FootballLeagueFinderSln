using FootballLeagueFinder.Data;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeagueFinder.Controllers
{
    public class TeamsController : Controller
    {
        private readonly FootballDbContext _context;

        public TeamsController(FootballDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var teams = _context.Teams.ToList();
            return View(teams);
        }
    }
}
