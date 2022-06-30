using FootballLeagueFinder.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FootballLeagueFinder.ViewModels
{
    public class CreateLeagueVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile Photo { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        
        // public List<Team> Teams { get; set; }

    }
}
