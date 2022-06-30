using FootballLeagueFinder.Contracts;
using FootballLeagueFinder.Data;
using FootballLeagueFinder.Models;
using FootballLeagueFinder.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballLeagueFinder.Controllers
{
    public class LeaguesController : Controller
    {
        private readonly ILeagueRepository _leagueRepository;
        private readonly IPhotoService _photoService;

        public LeaguesController(ILeagueRepository leagueRepository, IPhotoService photoService)
        {
            _leagueRepository = leagueRepository;
            _photoService = photoService;
        }
        public async Task<IActionResult> Index()
        {
            var leagues = await _leagueRepository.GetAllAsync();

            return View(leagues);
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
        public async Task<IActionResult> Create(CreateLeagueVM createLeagueVM)
        {
            if (ModelState.IsValid)
            {
                var photo = await _photoService.AddPhotoAsync(createLeagueVM.Photo);

                var league = new League
                {
                    Name = createLeagueVM.Name,
                    Location = createLeagueVM.Location,
                    Description = createLeagueVM.Description,
                    Photo = photo.Url.ToString()
                };
                _leagueRepository.Add(league);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("", "Ooops! Photo upload failed");
            }

            return View(createLeagueVM);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var league = await _leagueRepository.GetByIdAsync(id);
            if (league == null)
            {
                return View(nameof(ErrorViewModel));
                
            }
            var editLeagueVM = new EditLeagueVM
            {
                Name = league.Name,
                Location = league.Location,
                Description = league.Description,
                URL = league.Photo
            };
            return View(editLeagueVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditLeagueVM editLeagueVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "There was an error editing the league");
                return View("Edit", editLeagueVM);
            }
            var photoEdit = await _leagueRepository.GetByIdAsyncNoTracking(id);

            if (photoEdit != null)
                try
                {
                    await _photoService.DeletePhotoAsync(photoEdit.Photo);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Could not delete photo");
                    return View(editLeagueVM);
                }

            var photoResult = await _photoService.AddPhotoAsync(editLeagueVM.Photo);

            var league = new League
            {
                Id = id,
                Name = editLeagueVM.Name,
                Location = editLeagueVM.Location,
                Description = editLeagueVM.Description,
                Photo = photoResult.Url.ToString()
            };

            _leagueRepository.Update(league);
            return RedirectToAction(nameof(Index));
                
            
        }

        public async Task<IActionResult> Delete(int id)
        {
            var leagueDetails = await _leagueRepository.GetByIdAsync(id);
            if (leagueDetails == null) return View("Error");

            return View(leagueDetails);
        }

        [HttpPost, ActionName(nameof(Delete))]
        public async Task<IActionResult> DeleteClub(int id)
        {
            var leagueDetails = await _leagueRepository.GetByIdAsync(id);
            if (leagueDetails == null) return View("Error");

            _leagueRepository.Delete(leagueDetails);
            return RedirectToAction(nameof(Index));
        }
    }
}
