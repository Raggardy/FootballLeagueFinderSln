using Microsoft.AspNetCore.Mvc.Rendering;

namespace FootballLeagueFinder.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public List<Team> Teams { get; set; }

        
    }
}
