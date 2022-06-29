using FootballLeagueFinder.Contracts;
using FootballLeagueFinder.Data;
using FootballLeagueFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballLeagueFinder.Controllers
{
    public class LeaguesController : Controller
    {
        private readonly ILeagueRepository _leagueRepository;

        public LeaguesController(ILeagueRepository leagueRepository)
        {
            _leagueRepository = leagueRepository;
        }
        public async Task<IActionResult> Index()
        {
            var clubs = await _leagueRepository.GetAllAsync();

            return View(clubs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var league = await _leagueRepository.GetByIdAsync(id);

            return View(league);
        }

        public ActionResult<League> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(League league)
        {
            if (!ModelState.IsValid) return View(league);

            _leagueRepository.Add(league);

            return RedirectToAction(nameof(Index));
        }
    }
}
