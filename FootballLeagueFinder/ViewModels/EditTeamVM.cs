namespace FootballLeagueFinder.ViewModels
{
    public class EditTeamVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public IFormFile Photo { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public int LeagueId { get; set; }
    }
}
