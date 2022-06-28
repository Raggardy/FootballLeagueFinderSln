using Microsoft.AspNetCore.Mvc;

namespace FootballLeagueFinder.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
