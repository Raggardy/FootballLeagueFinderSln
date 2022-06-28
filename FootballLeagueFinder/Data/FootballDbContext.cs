using FootballLeagueFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballLeagueFinder.Data
{
    public class FootballDbContext : DbContext
    {
        public FootballDbContext(DbContextOptions<FootballDbContext> options) : base(options)
        {
        }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<League>().HasData(
                new League { Id = 1, Name = "West Kent League", Location = "Kent", Description = "The West Kent League, is a football competition based in Kent, England. The league has seven senior divisions – a Premier Division, Division One East and West, Division Two East and West and Division Three East and West. It sits below the Southern Counties East League Division One (step 6 of the National League System)  ", Photo = "https://www.pngkey.com/png/full/233-2332677_ega-png.png" },
                new League { Id = 2, Name = "East Kent League", Location = "Kent", Description = "The East Kent League, is a football competition based in Kent, England. The league has seven senior divisions – a Premier Division, Division One East and West, Division Two East and West and Division Three East and West. It sits below the Southern Counties East League Division One (step 6 of the National League System)", Photo = "https://www.pngkey.com/png/full/233-2332677_ega-png.png" }
                );

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "West Kent United", Manager = "Sid Bananas", LeagueId = 1, Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" },
                new Team { Id = 2, Name = "Jongo Town", Manager = "Dave Turnip", LeagueId = 1, Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" },
                new Team { Id = 3, Name = "Dunkirk Athletic", Manager = "Jay Apple", LeagueId = 1, Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" },
                new Team { Id = 4, Name = "Dels Dynamos", Manager = "Fred Grape", LeagueId = 2, Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" },
                new Team { Id = 5, Name = "Hammly Rangers", Manager = "Chris Pommegranette", LeagueId = 2, Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" },
                new Team { Id = 6, Name = "Keebo United", Manager = "Tom Potato", LeagueId = 2, Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif" }
                );

            // Team 1

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, FirstName = "Jim", LastName = "Jones", Position = Position.Goalkeepeer, ShirtNumber = "1", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 2, FirstName = "Dave", LastName = "Digby", Position = Position.Defender, ShirtNumber = "2", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 3, FirstName = "Simon", LastName = "Jeffries", Position = Position.Defender, ShirtNumber = "3", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 4, FirstName = "Les", LastName = "Formby", Position = Position.Defender, ShirtNumber = "4", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 5, FirstName = "Jim", LastName = "Jones", Position = Position.Defender, ShirtNumber = "5", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 6, FirstName = "Albert", LastName = "Albert", Position = Position.Midfield, ShirtNumber = "6", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 7, FirstName = "Mitch", LastName = "Walker", Position = Position.Midfield, ShirtNumber = "7", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 8, FirstName = "Dave", LastName = "Jones", Position = Position.Midfield, ShirtNumber = "8", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 9, FirstName = "Richard", LastName = "Smith", Position = Position.Midfield, ShirtNumber = "9", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 10, FirstName = "Fred", LastName = "Astaire", Position = Position.Striker, ShirtNumber = "10", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 11, FirstName = "Jim", LastName = "Jones", Position = Position.Striker, ShirtNumber = "11", TeamId = 1, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },

                // Team 2

                 new Player { Id = 31, FirstName = "Cedric", LastName = "Pinkerton", Position = Position.Goalkeepeer, ShirtNumber = "1", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 32, FirstName = "Rupert", LastName = "Bear", Position = Position.Defender, ShirtNumber = "2", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 33, FirstName = "Calvin", LastName = "Blackberry", Position = Position.Defender, ShirtNumber = "3", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 34, FirstName = "Dean", LastName = "Cheese", Position = Position.Defender, ShirtNumber = "4", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 35, FirstName = "Peter", LastName = "Kadiri", Position = Position.Defender, ShirtNumber = "5", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 36, FirstName = "Scott", LastName = "Dobson", Position = Position.Midfield, ShirtNumber = "6", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 37, FirstName = "Keith", LastName = "Fry", Position = Position.Midfield, ShirtNumber = "7", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 38, FirstName = "Paul", LastName = "Perry", Position = Position.Midfield, ShirtNumber = "8", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 39, FirstName = "Sal", LastName = "Silver", Position = Position.Midfield, ShirtNumber = "9", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 40, FirstName = "Del", LastName = "Gold", Position = Position.Striker, ShirtNumber = "10", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 41, FirstName = "Paul", LastName = "Fry", Position = Position.Striker, ShirtNumber = "11", TeamId = 2, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },

                // Team 3

                new Player { Id = 12, FirstName = "Eric", LastName = "Erikson", Position = Position.Goalkeepeer, ShirtNumber = "1", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 13, FirstName = "Claus", LastName = "Jensen", Position = Position.Defender, ShirtNumber = "2", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 14, FirstName = "Steve", LastName = "Brown", Position = Position.Defender, ShirtNumber = "3", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 15, FirstName = "Clive", LastName = "Fink", Position = Position.Defender, ShirtNumber = "4", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 16, FirstName = "Ted", LastName = "Smith", Position = Position.Defender, ShirtNumber = "5", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 17, FirstName = "Phil", LastName = "Smith", Position = Position.Midfield, ShirtNumber = "6", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 18, FirstName = "Jack", LastName = "Jones", Position = Position.Midfield, ShirtNumber = "7", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 19, FirstName = "Tony", LastName = "Toblerone", Position = Position.Midfield, ShirtNumber = "8", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 20, FirstName = "Sid", LastName = "Kitkat", Position = Position.Striker, ShirtNumber = "9", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 21, FirstName = "Arnold", LastName = "Gates", Position = Position.Striker, ShirtNumber = "10", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 22, FirstName = "Simon", LastName = "Finch", Position = Position.Striker, ShirtNumber = "11", TeamId = 3, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },

                // Team 4

                new Player { Id = 42, FirstName = "Tony", LastName = "Montana", Position = Position.Goalkeepeer, ShirtNumber = "1", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 43, FirstName = "Oz", LastName = "Floss", Position = Position.Defender, ShirtNumber = "2", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 44, FirstName = "Si", LastName = "Brown", Position = Position.Defender, ShirtNumber = "3", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 45, FirstName = "Keith", LastName = "Beef", Position = Position.Defender, ShirtNumber = "4", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 46, FirstName = "Morgan", LastName = "Telford", Position = Position.Defender, ShirtNumber = "5", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 47, FirstName = "Caz", LastName = "Log", Position = Position.Midfield, ShirtNumber = "6", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 48, FirstName = "Richard", LastName = "Richardson", Position = Position.Midfield, ShirtNumber = "7", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 49, FirstName = "Ken", LastName = "Bruce", Position = Position.Midfield, ShirtNumber = "8", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 50, FirstName = "Ray", LastName = "Light", Position = Position.Striker, ShirtNumber = "9", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 51, FirstName = "Jason", LastName = "Gates", Position = Position.Striker, ShirtNumber = "10", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 52, FirstName = "Simon", LastName = "Finch", Position = Position.Striker, ShirtNumber = "11", TeamId = 4, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },

                // Team 5

                new Player { Id = 63, FirstName = "Alex", LastName = "Cod", Position = Position.Goalkeepeer, ShirtNumber = "1", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 53, FirstName = "John", LastName = "Phillips", Position = Position.Defender, ShirtNumber = "2", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 54, FirstName = "Barry", LastName = "Brown", Position = Position.Defender, ShirtNumber = "3", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 55, FirstName = "Mason", LastName = "Fred", Position = Position.Defender, ShirtNumber = "4", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 56, FirstName = "Eric", LastName = "Gonzo", Position = Position.Defender, ShirtNumber = "5", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 57, FirstName = "Les", LastName = "Wood", Position = Position.Midfield, ShirtNumber = "6", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 58, FirstName = "Alfie", LastName = "Gooch", Position = Position.Midfield, ShirtNumber = "7", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 59, FirstName = "Ron", LastName = "Bonne", Position = Position.Midfield, ShirtNumber = "8", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 60, FirstName = "Malcolm", LastName = "Lightfoot", Position = Position.Midfield, ShirtNumber = "9", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 61, FirstName = "Terry", LastName = "Ronford", Position = Position.Striker, ShirtNumber = "10", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 62, FirstName = "Tim", LastName = "Docherty", Position = Position.Striker, ShirtNumber = "11", TeamId = 5, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },

                // Team 6

                new Player { Id = 74, FirstName = "Paul", LastName = "Derk", Position = Position.Goalkeepeer, ShirtNumber = "1", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 73, FirstName = "Colin", LastName = "Clarke", Position = Position.Defender, ShirtNumber = "2", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 64, FirstName = "Barnie", LastName = "Rubble", Position = Position.Defender, ShirtNumber = "3", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 65, FirstName = "Len", LastName = "Fredson", Position = Position.Defender, ShirtNumber = "4", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 66, FirstName = "Igor", LastName = "Vasalivitch", Position = Position.Defender, ShirtNumber = "5", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 67, FirstName = "Gordon", LastName = "Smith", Position = Position.Midfield, ShirtNumber = "6", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 68, FirstName = "Cuthbert", LastName = "Dibble", Position = Position.Midfield, ShirtNumber = "7", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 69, FirstName = "Eldridge", LastName = "Coolerson", Position = Position.Midfield, ShirtNumber = "8", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 70, FirstName = "Zack", LastName = "Pow", Position = Position.Midfield, ShirtNumber = "9", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 71, FirstName = "Ben", LastName = "Boom", Position = Position.Striker, ShirtNumber = "10", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" },
                new Player { Id = 72, FirstName = "Sid", LastName = "Fortesque", Position = Position.Striker, ShirtNumber = "11", TeamId = 6, Photo = "http://shackmanlab.org/wp-content/uploads/2013/07/person-placeholder.jpg" }


                );

            



        }
    }
}
