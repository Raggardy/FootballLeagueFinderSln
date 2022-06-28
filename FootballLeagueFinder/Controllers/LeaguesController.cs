using FootballLeagueFinder.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballLeagueFinder.Controllers
{
    public class LeaguesController : Controller
    {
        private readonly FootballDbContext _context;

        public LeaguesController(FootballDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var clubs = await _context.Leagues.ToListAsync();

            return View(clubs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var league = await _context.Leagues
                .Include(t => t.Teams)
                .FirstOrDefaultAsync(x => x.Id == id);

            return View(league);
        }
    }
}
