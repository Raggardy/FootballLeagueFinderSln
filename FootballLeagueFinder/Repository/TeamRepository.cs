using FootballLeagueFinder.Contracts;
using FootballLeagueFinder.Data;
using FootballLeagueFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballLeagueFinder.Repository
{
    public class TeamRepository : ITeamRepository
    {
        private readonly FootballDbContext _context;

        public TeamRepository(FootballDbContext context)
        {
            _context = context;
        }
        public bool Add(Team team)
        {
            _context.Add(team);
            return Save();
        }

        public bool Delete(Team team)
        {
            _context.Remove(team);
            return Save();
        }

        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Team> GetByIdAsync(int id)
        {
            return await _context.Teams
                .Include(p => p.Players)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Team> GetByIdAsyncNoTracking(int id)
        {
            return await _context.Teams
                .Include(p => p.Players)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Team>> GetTeamByLeague(string league)
        {
            return (IEnumerable<Team>)await _context.Leagues
                .Include(t => t.Teams)
                .ThenInclude(n => n.Name)
                .Where(l => l.Name.Contains(league))
                .ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Team team)
        {
            _context.Update(team);
            return Save();
        }
    }
}
