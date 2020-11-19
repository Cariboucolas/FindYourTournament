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

                Tournament tournament1 = new Tournament()
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
                Tournament tournament2 = new Tournament()
                {
                    TournamentName = "Tournoi N°2",
                    TournamentDate = Convert.ToDateTime("11/03/1392"),
                    Price = 5,
                    Prize = 200,
                    TournamentLocation = "Chateau de Colas",
                    Description = "Viens labourer la pelouse",
                    TournamentType = "Cheval",
                    Participants = 10,
                };
                Tournament tournament3 = new Tournament()
                {
                    TournamentName = "Tournoi N°3",
                    TournamentDate = Convert.ToDateTime("22/01/1392"),
                    Price = 0 ,
                    Prize = 50,
                    TournamentLocation = "Chateau d'eau",
                    Description = "Initiation",
                    TournamentType = "Au sol",
                    Participants = 100,
                };
                Tournament tournament4 = new Tournament()
                {
                    TournamentName = "Tournoi N°4",
                    TournamentDate = Convert.ToDateTime("15/01/1392"),
                    Price = 100,
                    Prize = 2500,
                    TournamentLocation = "Le château de Fontainebleau.",
                    Description = "Affronte les plus grands adversaire du moment !",
                    TournamentType = "Au sol",
                    Participants = 10,
                };

                Knight knight1  = new Knight()
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
                    Ranking = 3,
                    
                };
                Knight knight2 = new Knight()
                {
                    KnightName = "Le jeunot",
                    Age = 16,
                    Alive = true,
                    Mount = false,
                    Region = "Breton",
                    Moto = "Ne me tuez pas",
                    Victories = 0,
                    Weapons = "Wood stick",
                    Armors = "goat leather",
                    Ranking = 4,
                    

                };
                Knight knight3 = new Knight()
                {
                    KnightName = "Leonidas",
                    Age = 35,
                    Alive = true,
                    Mount = true,
                    MountName = "Xerxès",
                    MountType = "Man",
                    Region = "Greecce",
                    Moto = "WAHOU",
                    Victories = 65,
                    Defeats = 0,
                    Weapons = "sword, spear, shield",
                    Armors = "pants",
                    Ranking = 1,
                    Pigeon = "sparte@pigeon.com",
                    Avatar = "",


                };
                Knight knight4 = new Knight()
                {
                    KnightName = "Maximus",
                    Age = 30,
                    Alive = true,
                    Mount = false,
                    Region = "Rome",
                    Moto = "Force et honneur.",
                    Victories = 25,
                    Defeats = 2,
                    Weapons = "sword , sword",
                    Armors = "chestplate",
                    Pigeon = "VillaPoggioManzuoli@pigeon.com",
                    Ranking = 2,

                };
                Knight knight5 = new Knight()
                {
                    KnightName = "Guillaume",
                    Age = 28,
                    Alive = false,
                    Mount = false,
                    Region = "Mésopotamie",
                    Moto = "I have an army",
                    Victories = 100,
                    Weapons = "More humans",
                    Armors = "Big walls",
                    Ranking = 5,
                    Pigeon = "Angleterre@pigeon.com"

                };
                context.AddRange(tournament1, tournament2, tournament3, tournament4, knight1, knight2, knight3, knight4, knight5);
                context.SaveChanges();

            }
        }
    }
}
