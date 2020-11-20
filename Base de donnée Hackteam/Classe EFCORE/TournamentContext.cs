using Microsoft.EntityFrameworkCore;
using System;

namespace Base_de_donnée_Hackteam
{
    public class TournamentContext : DbContext
    {
        public virtual DbSet<Tournament> Tournament { get; set; }
        public virtual DbSet<Knight> Knight { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=tcp:backhackatondb.database.windows.net,1433;Initial Catalog=hackTeam;Persist Security Info=False;User ID=hackteam;Password=$Hack2020;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;");

        }
    }
}