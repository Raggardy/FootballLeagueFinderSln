using System.ComponentModel.DataAnnotations.Schema;

namespace FootballLeagueFinder.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(League))]
        public int LeagueId { get; set; }
        public League League { get; set; }

        public List<Player> Players { get; set; }
    }
}
