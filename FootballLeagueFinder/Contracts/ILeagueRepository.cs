using FootballLeagueFinder.Models;

namespace FootballLeagueFinder.Contracts
{
    public interface ILeagueRepository
    {
        Task<IEnumerable<League>> GetAllAsync();
        Task<League> GetByIdAsync(int id);
        bool Add(League league);
        bool Update(League league);
        bool Delete(League league);
        bool Save();
    }
}
