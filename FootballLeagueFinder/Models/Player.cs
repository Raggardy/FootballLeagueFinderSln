using System.ComponentModel.DataAnnotations.Schema;

namespace FootballLeagueFinder.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShirtNumber { get; set; }
        
        public string? Photo { get; set; }
        public Position Position { get; set; }


        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
