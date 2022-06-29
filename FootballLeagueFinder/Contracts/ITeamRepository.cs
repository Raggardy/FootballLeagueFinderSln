using FootballLeagueFinder.Models;

namespace FootballLeagueFinder.Contracts
{
    public interface ITeamRepository
    {
        Task<IEnumerable<Team>> GetAllAsync();
        Task<Team> GetByIdAsync(int id);
        Task<IEnumerable<Team>> GetTeamByLeague(string league);
        bool Add(Team team);
        bool Update(Team team);
        bool Delete(Team team);
        bool Save();
    }
}
