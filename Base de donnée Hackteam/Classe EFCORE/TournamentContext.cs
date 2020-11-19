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
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=HackTeam;Integrated Security=True");
        }
    }
}