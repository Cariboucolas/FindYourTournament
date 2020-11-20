using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackHackaton.BDD.ClassesEfCore
{
    
        public class TournamentContext : DbContext
        {
            public virtual DbSet<Tournament> Tournament { get; set; }
            public virtual DbSet<Knight> Knight { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:backhackatondb.database.windows.net,1433;Initial Catalog=HackTeam;Persist Security Info=False;User ID=hackteam;Password=$Hack2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    
}
