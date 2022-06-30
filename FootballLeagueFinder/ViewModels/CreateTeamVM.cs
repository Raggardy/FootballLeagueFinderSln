using FootballLeagueFinder.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FootballLeagueFinder.ViewModels
{
    public class CreateTeamVM
    {
        public string Name { get; set; }
        public string Manager { get; set; }
        public IFormFile Photo { get; set; }
        public string Description { get; set; }

        public int LeagueId { get; set; }
    }
}
