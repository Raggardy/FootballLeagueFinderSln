using FootballLeagueFinder.Contracts;
using FootballLeagueFinder.Data;
using FootballLeagueFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballLeagueFinder.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ITeamRepository _teamRepository;

        public TeamsController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        public async Task<ActionResult<List<Team>>> Index()
        {
            var teams = await _teamRepository.GetAllAsync();
            return View(teams);
        }

        public async Task<ActionResult<Team>> Detail(int id)
        {
            var team = await _teamRepository.GetByIdAsync(id);

            return View(team);
        }

        public ActionResult<Team> Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult<Team> Create(Team team)
        {
            if (!ModelState.IsValid) return View(team);

            _teamRepository.Add(team);

            return RedirectToAction(nameof(Index));
        }
    }
}
