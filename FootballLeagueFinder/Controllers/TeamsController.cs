using FootballLeagueFinder.Contracts;
using FootballLeagueFinder.Data;
using FootballLeagueFinder.Models;
using FootballLeagueFinder.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballLeagueFinder.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IPhotoService _photoService;

        public TeamsController(ITeamRepository teamRepository, IPhotoService photoService)
        {
            _teamRepository = teamRepository;
            _photoService = photoService;
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
        public async Task<IActionResult> Create(CreateTeamVM createTeamVM)
        {
            if (ModelState.IsValid)
            {
                var photo = await _photoService.AddPhotoAsync(createTeamVM.Photo);

                var team = new Team
                {
                    Name = createTeamVM.Name,
                    Manager = createTeamVM.Manager,
                    Description = createTeamVM.Description,
                    Photo = photo.Url.ToString(),
                    LeagueId = createTeamVM.LeagueId
                };
                _teamRepository.Add(team);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("", "Ooops! Photo upload failed");
            }
            return View(createTeamVM);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var team = await _teamRepository.GetByIdAsync(id);
            if (team == null)
            {
                return View(nameof(ErrorViewModel));

            }
            var editTeamVM = new EditTeamVM
            {
                Name = team.Name,
                Manager = team.Manager,
                Description = team.Description,
                LeagueId = team.LeagueId,
                URL = team.Photo
            };
            return View(editTeamVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditTeamVM editTeamVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "There was an error editing the league");
                return View("Edit", editTeamVM);
            }
            var photoEdit = await _teamRepository.GetByIdAsyncNoTracking(id);

            if (photoEdit != null)
                try
                {
                    await _photoService.DeletePhotoAsync(photoEdit.Photo);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Could not delete photo");
                    return View(editTeamVM);
                }

            var photoResult = await _photoService.AddPhotoAsync(editTeamVM.Photo);

            var team = new Team
            {
                Id = id,
                Name = editTeamVM.Name,
                Manager = editTeamVM.Manager,
                Description = editTeamVM.Description,
                LeagueId = editTeamVM.LeagueId,
                Photo = photoResult.Url.ToString()
            };

            _teamRepository.Update(team);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var teamDetails = await _teamRepository.GetByIdAsync(id);
            if (teamDetails == null) return View("Error");

            return View(teamDetails);            
        }

        [HttpPost, ActionName(nameof(Delete))]
        public async Task<IActionResult> DeleteClub(int id)
        {
            var teamDetails = await _teamRepository.GetByIdAsync(id);
            if (teamDetails == null) return View("Error");

            _teamRepository.Delete(teamDetails);
            return RedirectToAction(nameof(Index));
        }
    }
}

