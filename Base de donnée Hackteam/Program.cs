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
                    TournamentName = "Tournament Of the year : Christmas tournament ",
                    TournamentDate = Convert.ToDateTime("25/12/1392"),
                    Price = 100,
                    Prize = 12500,
                    TournamentLocation = "Castle of Vincennes",
                    Description = "This is the last tournament of the year, you will have the chance to fight in front of the king in person",
                    TournamentType = "With Mount",
                    Participants = 100,  
                    Champion = "Creddred",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_1.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament2 = new Tournament()
                {
                    TournamentName = "Easter tournament",
                    TournamentDate = Convert.ToDateTime("15/04/1392"),
                    Price = 4,
                    Prize = 500,
                    TournamentLocation = "Castle of Roquetaillade",
                    Description = "We are not looking for eggs but for bloodthirsty fighters",
                    TournamentType = "With mount",
                    Participants = 50,
                    Champion = "Anosdagan",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_2.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament3 = new Tournament()
                {
                    TournamentName = "Spring Tournament",
                    TournamentDate = Convert.ToDateTime("20/03/1392"),
                    Price = 1,
                    Prize = 100,
                    TournamentLocation = "Castle of Faverges",
                    Description = "No time to see the tulips bloom, the fights have started again",
                    TournamentType = "Without Mount",
                    Participants = 25,
                    Champion = "Holdjamy",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_3.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament4 = new Tournament()
                {
                    TournamentName = "Mother's Day tournament",
                    TournamentDate = Convert.ToDateTime("30/05/1392"),
                    Price = 10,
                    Prize = 250,
                    TournamentLocation = "Castle of Veauce",
                    Description = "Many mothers lose their children during this tournament",
                    TournamentType = "Without Mount",
                    Participants = 30,
                    Champion = "Creddred",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_4.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament5 = new Tournament()
                {
                    TournamentName = "Ascension Tournament",
                    TournamentDate = Convert.ToDateTime("13/05/1392 "),
                    Price = 10,
                    Prize = 1000,
                    TournamentLocation = "Castle of Rouen",
                    Description = "As the symbol of faith expresses it: “He ascended into Heaven; he is seated at the right hand of the Father. He will come again in glory to judge the living and the dead, and his reign will have no end ",
                    TournamentType = "With Mount",
                    Participants = 75,
                    Champion = "Asnosdagan",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_5.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament6 = new Tournament()
                {
                    TournamentName = "Epiphany tournament",
                    TournamentDate = Convert.ToDateTime("06/01/1392"),
                    Price = 1,
                    Prize = 100,
                    TournamentLocation = "Palace of the Dukes of Bourgogne",
                    Description = "Epiphany: opening of the Combats, we have been waiting for this since last year",
                    TournamentType = "Without Mount",
                    Participants = 50,
                    Champion = "",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_6.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament7 = new Tournament()
                {
                    TournamentName = "Pentecote tournament",
                    TournamentDate = Convert.ToDateTime("23/05/1392"),
                    Price = 50,
                    Prize = 1000,
                    TournamentLocation = "Castle of Courtanvaux",
                    Description = "",
                    TournamentType = "With Mount",
                    Participants = 50,
                    Champion = "Creddred",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_7.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament8 = new Tournament()
                {
                    TournamentName = "Assumption tournament",
                    TournamentDate = Convert.ToDateTime("15/08/1392"),
                    Price = 50,
                    Prize = 1000,
                    TournamentLocation = "Castle of Thorens",
                    Description = "The Assumption of the Blessed Virgin and also of our fighters",
                    TournamentType = "With Mount",
                    Participants = 100,
                    Champion = "Holdjamy",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_8.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament9 = new Tournament()
                {
                    TournamentName = "Toussaint tournament",
                    TournamentDate = Convert.ToDateTime("01/11/1392"),
                    Price = 25,
                    Prize = 500,
                    TournamentLocation = "Castle of Falaise",
                    Description = "The day after the feast of the dead: enough to honor all these fighters who left too early",
                    TournamentType = "Without Mount",
                    Participants = 50,
                    Champion = "Anosdagan",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_9.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament10 = new Tournament()
                {
                    TournamentName = "Charles V tournament ",
                    TournamentDate = Convert.ToDateTime("01/11/1392"),
                    Price = 5,
                    Prize = 100,
                    TournamentLocation = "Castle of Veauce",
                    Description = "Fight here or join the ranks for war!",
                    TournamentType = "With Mount",
                    Participants = 20,
                    Champion = "Anosdagan",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_10.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament11 = new Tournament()
                {
                    TournamentName = "Clément VII tournament ",
                    TournamentDate = Convert.ToDateTime("01/11/1392"),
                    Price = 10,
                    Prize = 500,
                    TournamentLocation = "Castle of Falaise",
                    Description = "Come and entertain Pope Clement VII",
                    TournamentType = "With Mount",
                    Participants = 30,
                    Champion = "creddred",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_11.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };
                Tournament tournament12 = new Tournament()
                {
                    TournamentName = "",
                    TournamentDate = Convert.ToDateTime("01/11/1392"),
                    Price = 10,
                    Prize = 500,
                    TournamentLocation = "Castle of Falaise",
                    Description = "Come and entertain Pope Clement VII",
                    TournamentType = "With Mount",
                    Participants = 30,
                    Champion = "creddred",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_12.png", // URL image tournoi
                    Videos = "", // URL image tournoi
                };

                context.AddRange(tournament1, tournament2, tournament3, tournament4, tournament5, tournament6, tournament7, tournament8, tournament9,tournament10, tournament11, tournament12);
                context.SaveChanges();

                Knight knight1 = new Knight()
                {
                    KnightName = "Anosdagan",
                    Age = 24,
                    Victories = 10,
                    Defeats = 1,
                    Banner = "", // URL banner
                    Weapons = "Sword, shield",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_Armors.png", // URL armorIcons
                    Mount = true,
                    MountType = "Warhorse",
                    MountTypeIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png", // URL typeIcons
                    MountName = "Cannasson",
                    Moto = "Houra!",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 3,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "http://milhiecreation.com/imagesHackaton/success/success_1tournament.png" // URL SuccessIcons

                };
                Knight knight2 = new Knight()
                {
                    KnightName = "Autfred",
                    Age = 32,
                    Victories = 3,
                    Defeats = 6,
                    Banner = "", // URL banner
                    Weapons = "Spear",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Breastplate",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "I am not afraid of death !",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 21,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight3 = new Knight()
                {
                    KnightName = "Bertlance",
                    Age = 43,
                    Victories = 25,
                    Defeats = 9,
                    Banner = "", // URL banner
                    Weapons = "Mace",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Chainmail",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Fear me !",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 4,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight4 = new Knight()
                {
                    KnightName = "Aeltor",
                    Age = 22,
                    Victories = 0,
                    Defeats = 5,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_1", // URL banner
                    Weapons = "Wood stick",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quilted weave",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "these last words are 'stop it!'",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Aeltor.png", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = false,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png", // URL AliveIcons
                    Ranking = 25,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight5= new Knight()
                {
                    KnightName = "Creddred",
                    Age = 28,
                    Victories = 31,
                    Defeats = 0,
                    Banner = "", // URL banner
                    Weapons = "Two handed sword",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate armor",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = true,
                    MountType = "Griffon",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "Ragnar",
                    Moto = "Cool, you are food for my pet",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 1,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "http://milhiecreation.com/imagesHackaton/success/success_1tournament.png , https://cdn.discordapp.com/attachments/778897010711330846/779148773964120084/success_3tournament.png" // URL SuccessIcons

                };
                Knight knight6 = new Knight()
                {
                    KnightName = "Daganho",
                    Age = 23,
                    Victories = 0,
                    Defeats = 0,
                    Banner = "", // URL banner
                    Weapons = "Dague",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quilted weave",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Tzi shu force is with me",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 20,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight7 = new Knight()
                {
                    KnightName = "Ethward",
                    Age = 29,
                    Victories = 15,
                    Defeats = 8,
                    Banner = "", // URL banner
                    Weapons = "Bow",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quilted Weave",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "My arrows are faster than your weapons",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 9,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight8 = new Knight()
                {
                    KnightName = "Holdjamy",
                    Age = 34,
                    Victories = 25,
                    Defeats = 4,
                    Banner = "", // URL banner
                    Weapons = "Hammer",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Vikings armor",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = true,
                    MountType = "Wolf",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "Canis",
                    Moto = "I have thor's hammer!",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 2,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "http://milhiecreation.com/imagesHackaton/success/success_1tournament.png" // URL SuccessIcons

                };
                Knight knight9 = new Knight()
                {
                    KnightName = "Jasmor",
                    Age = 31,
                    Victories = 8,
                    Defeats = 6,
                    Banner = "", // URL banner
                    Weapons = "Scourge",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Scale armor",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = true,
                    MountType = "Pagasus",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "Pegasus",
                    Moto = "My animal is still in the air",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 11,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight10 = new Knight()
                {
                    KnightName = "Leodagan",
                    Age = 25,
                    Victories = 15,
                    Defeats = 4,
                    Banner = "", // URL banner
                    Weapons = "Axe",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate armor",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = true,
                    MountType = "Hippogriff",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "Buck",
                    Moto = "Comme and measure yourself against me",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 5,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight11 = new Knight()
                {
                    KnightName = "Lotaut",
                    Age = 25,
                    Victories = 6,
                    Defeats = 4,
                    Banner = "", // URL banner
                    Weapons = "Dagger",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quited weave",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = true,
                    MountType = "Boar",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "Grouik",
                    Moto = "My pet isn't fodd",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 15,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight12 = new Knight()
                {
                    KnightName = "Nulfar",
                    Age = 29,
                    Victories = 1,
                    Defeats = 8,
                    Banner = "", // URL banner
                    Weapons = "Sword",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Harness",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "I will be the best !",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = false,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png", // URL AliveIcons
                    Ranking = 24,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight13 = new Knight()
                {
                    KnightName = "Percyward",
                    Age = 28,
                    Victories = 2,
                    Defeats = 4,
                    Banner = "", // URL banner
                    Weapons = "Sword",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Harness",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "I will be the best !",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = false,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png", // URL AliveIcons
                    Ranking = 23,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight14 = new Knight()
                {
                    KnightName = "Agaaut",
                    Age = 28,
                    Victories = 19,
                    Defeats = 8,
                    Banner = "", // URL banner
                    Weapons = "Hallebarde",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate armor",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Drop to my halberd",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 6,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight15 = new Knight()
                {
                    KnightName = "Bojas",
                    Age = 18,
                    Victories = 4,
                    Defeats = 4,
                    Banner = "", // URL banner
                    Weapons = "Spear",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Breastplate",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Drop to my halberd",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 17,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight16 = new Knight()
                {
                    KnightName = "Jeain",
                    Age = 27,
                    Victories = 17,
                    Defeats = 9,
                    Banner = "", // URL banner
                    Weapons = "Mace",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Chainmail",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = true,
                    MountType = "Unicorn",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "Pony",
                    Moto = "Do you know the realy death ?",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 7,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight17 = new Knight()
                {
                    KnightName = "Nardarnold",
                    Age = 27,
                    Victories = 5,
                    Defeats = 4,
                    Banner = "", // URL banner
                    Weapons = "Scourge",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Scale Armor",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Could you be nice to me ?",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 18,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight18 = new Knight()
                {
                    KnightName = "Tuslot",
                    Age = 27,
                    Victories = 0,
                    Defeats = 1,
                    Banner = "", // URL banner
                    Weapons = "Dagger",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quilted weave",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Let's go",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = false,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png", // URL AliveIcons
                    Ranking = 22,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight19 = new Knight()
                {
                    KnightName = "Valeranos",
                    Age = 27,
                    Victories = 9,
                    Defeats = 4,
                    Banner = "", // URL banner
                    Weapons = "Scourge",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate Armor",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = true,
                    MountType = "Camel",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "Case",
                    Moto = "Say your prayer",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 8,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight20 = new Knight()
                {
                    KnightName = "Reindric",
                    Age = 44,
                    Victories = 37,
                    Defeats = 25,
                    Banner = "", // URL banner
                    Weapons = "Sword",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate Armor",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "There was a time when i was first",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 10,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "https://cdn.discordapp.com/attachments/778897010711330846/779148773964120084/success_2tournament.png" // URL SuccessIcons

                };
                Knight knight21 = new Knight()
                {
                    KnightName = "Rollrein",
                    Age = 21,
                    Victories = 3,
                    Defeats = 1,
                    Banner = "", // URL banner
                    Weapons = "Mace",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Chainmail",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "I have the courage to face the greatest",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 19,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight22 = new Knight()
                {
                    KnightName = "Tanje",
                    Age = 24,
                    Victories = 7,
                    Defeats = 3,
                    Banner = "", // URL banner
                    Weapons = "Sword",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Breastplate",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 16,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight23 = new Knight()
                {
                    KnightName = "Telperce",
                    Age = 28,
                    Victories = 14,
                    Defeats = 8,
                    Banner = "", // URL banner
                    Weapons = "Spear",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Harness",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 12,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight24 = new Knight()
                {
                    KnightName = "Thurward",
                    Age = 36,
                    Victories = 14,
                    Defeats = 11,
                    Banner = "", // URL banner
                    Weapons = "Axe",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Scale Armor",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 13,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight25 = new Knight()
                {
                    KnightName = "Vallande",
                    Age = 26,
                    Victories = 18,
                    Defeats = 9,
                    Banner = "", // URL banner
                    Weapons = "Dagger",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quilted Weave",
                    ArmorsIcons = "", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "",
                    Avatar = "", // URL avatar
                    Region = "",
                    Pigeon = "@pigeon.com", //adress mail
                    PigeonIcons = "", // URL PigeonIcons
                    Alive = false,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png", // URL AliveIcons
                    Ranking = 14,
                    RankingIcons = "", // URL RankingIcons
                    SuccessIcons = "", // URL SuccessIcons
                };
                context.AddRange(knight1, knight2, knight3, knight4, knight5, knight6, knight7, knight8, knight9, knight10, knight11, knight12, knight13,
                    knight14, knight15, knight16, knight17, knight18, knight19, knight20, knight21, knight22, knight23, knight24, knight25);
                context.SaveChanges();
            }
        }
    }
}
