using FootballLeagueFinder.Contracts;
using FootballLeagueFinder.Data;
using FootballLeagueFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballLeagueFinder.Repository
{
    public class LeagueRepository : ILeagueRepository
    {
        private readonly FootballDbContext _context;

        public LeagueRepository(FootballDbContext context)
        {
            _context = context;
        }
        public bool Add(League league)
        {
            _context.Add(league);
            return Save();
        }

        public bool Delete(League league)
        {
            _context.Remove(league);
            return Save();
        }

        public async Task<IEnumerable<League>> GetAllAsync()
        {
            return await _context.Leagues.ToListAsync();
        }

        public async Task<League> GetByIdAsync(int id)
        {
            return await _context.Leagues
                .Include(t => t.Teams)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<League> GetByIdAsyncNoTracking(int id)
        {
            return await _context.Leagues
                .Include(t => t.Teams)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(League league)
        {
            _context.Update(league);
            return Save();
        }
    }
}
