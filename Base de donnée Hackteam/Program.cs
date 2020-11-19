using System;
using System.Collections.Generic;

namespace Base_de_donnée_Hackteam
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TournamentContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Tournament tournament = new Tournament()
                {
                    TournamentName = "Tournoi N°1",
                    TournamentDate = Convert.ToDateTime("15/01/1392"),
                    Price = 2,
                    Prize = 100,
                    TournamentLocation = "Chateau de Versailles",
                    Description = "Viens de friter contre ton rival",
                    TournamentType = "Au sol",
                    Participants = 25,               
                };

                Knight LaMachine  = new Knight()
                {
                    KnightName = "La machine",
                    Age = 25,
                    Alive = true,
                    Mount = false,
                    Region = "Occitanie",
                    Moto = "Banzai",
                    Victories = 5,
                    Weapons = "sword , shield", 
                    Armors = "Plate Armor",
                    
                };
                context.AddRange(tournament, LaMachine);
                context.SaveChanges();

            }
        }
    }
}
