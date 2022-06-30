namespace FootballLeagueFinder.ViewModels
{
    public class EditLeagueVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile Photo { get; set; }
        public string URL { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
