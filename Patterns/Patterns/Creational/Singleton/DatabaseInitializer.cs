using System.Collections.Generic;
using System.Data.Entity;

namespace Patterns.Creational.Singleton
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<Singleton>
    {
        protected override void Seed(Singleton context)
        {
            var player1 = new Player { Name = "Ivan", Age = 22, IsCaptain = true };
            var player2 = new Player { Name = "Jackie", Age = 20 };
            var player3 = new Player { Name = "Vlad", Age = 27, IsCaptain = true };
            var player4 = new Player { Name = "Danny", Age = 24 };
            
            context.Players.AddRange(new List<Player> { player1, player2, player3, player4 });

            context.Teams.AddRange(new List<Team>
            {
                new Team() {TeamName = "NA-VI", Players = new List<Player>(){player1, player2}},
                new Team() {TeamName = "Virtuous", Players = new List<Player>(){player3, player4}}
            });
            
            context.SaveChanges();
        }
    }
}