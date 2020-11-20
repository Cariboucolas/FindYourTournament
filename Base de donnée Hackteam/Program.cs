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
                    TournamentName = "Tournament of the year : Christmas Tournament ",
                    TournamentDate = Convert.ToDateTime("25/12/1392"),
                    Price = 100,
                    Prize = 12500,
                    TournamentLocation = "Castle of Vincennes",
                    Description = "This is the last tournament of the year, you will have the chance to fight in front of the king in person",
                    TournamentType = "With Mount",
                    Participants = 100,  
                    Champion = "Creddred",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_1.png", // URL image tournoi
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_horse_1.png", // URL image tournoi
                };
                Tournament tournament2 = new Tournament()
                {
                    TournamentName = "Easter Tournament",
                    TournamentDate = Convert.ToDateTime("15/04/1392"),
                    Price = 4,
                    Prize = 500,
                    TournamentLocation = "Castle of Roquetaillade",
                    Description = "We are not looking for eggs but for bloodthirsty fighters",
                    TournamentType = "With mount",
                    Participants = 50,
                    Champion = "Anosdagan",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_2.png", // URL image tournoi
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_horse_1.png", // URL image tournoi
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
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_foot_1.png", // URL image tournoi
                };
                Tournament tournament4 = new Tournament()
                {
                    TournamentName = "Mother's Day Tournament",
                    TournamentDate = Convert.ToDateTime("30/05/1392"),
                    Price = 10,
                    Prize = 250,
                    TournamentLocation = "Castle of Veauce",
                    Description = "Many mothers lose their children during this tournament",
                    TournamentType = "Without Mount",
                    Participants = 30,
                    Champion = "Creddred",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_4.png", // URL image tournoi
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_foot_1.png", // URL image tournoi
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
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_horse_1.png", // URL image tournoi
                };
                Tournament tournament6 = new Tournament()
                {
                    TournamentName = "Epiphany Tournament",
                    TournamentDate = Convert.ToDateTime("06/01/1392"),
                    Price = 1,
                    Prize = 100,
                    TournamentLocation = "Palace of the Dukes of Bourgogne",
                    Description = "Epiphany: opening of the Combats, we have been waiting for this since last year",
                    TournamentType = "Without Mount",
                    Participants = 50,
                    Champion = "",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_6.png", // URL image tournoi
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_foot_1.png", // URL image tournoi
                };
                Tournament tournament7 = new Tournament()
                {
                    TournamentName = "Pentecote Tournament",
                    TournamentDate = Convert.ToDateTime("23/05/1392"),
                    Price = 50,
                    Prize = 1000,
                    TournamentLocation = "Castle of Courtanvaux",
                    Description = "Commemorates the descent of the Holy Spirit and become an apostle of Jesus Christ",
                    TournamentType = "With Mount",
                    Participants = 50,
                    Champion = "Creddred",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_7.png", // URL image tournoi
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_horse_1.png", // URL image tournoi
                };
                Tournament tournament8 = new Tournament()
                {
                    TournamentName = "Assumption Tournament",
                    TournamentDate = Convert.ToDateTime("15/08/1392"),
                    Price = 50,
                    Prize = 1000,
                    TournamentLocation = "Castle of Thorens",
                    Description = "The Assumption of the Blessed Virgin and also of our fighters",
                    TournamentType = "With Mount",
                    Participants = 100,
                    Champion = "Holdjamy",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_8.png", // URL image tournoi
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_horse_1.png", // URL image tournoi
                };
                Tournament tournament9 = new Tournament()
                {
                    TournamentName = "Toussaint Tournament",
                    TournamentDate = Convert.ToDateTime("01/11/1392"),
                    Price = 25,
                    Prize = 500,
                    TournamentLocation = "Castle of Falaise",
                    Description = "The day after the feast of the dead: enough to honor all these fighters who left too early",
                    TournamentType = "Without Mount",
                    Participants = 50,
                    Champion = "Anosdagan",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_9.png", // URL image tournoi
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_foot_1.png", // URL image tournoi
                };
                Tournament tournament10 = new Tournament()
                {
                    TournamentName = "Charles V Tournament ",
                    TournamentDate = Convert.ToDateTime("01/11/1392"),
                    Price = 5,
                    Prize = 100,
                    TournamentLocation = "Castle of Veauce",
                    Description = "Fight here or join the ranks for war!",
                    TournamentType = "With Mount",
                    Participants = 20,
                    Champion = "Anosdagan",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_10.png", // URL image tournoi
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_horse_1.png", // URL image tournoi
                };
                Tournament tournament11 = new Tournament()
                {
                    TournamentName = "Clément VII Tournament ",
                    TournamentDate = Convert.ToDateTime("01/11/1392"),
                    Price = 10,
                    Prize = 500,
                    TournamentLocation = "Castle of Falaise",
                    Description = "Come and entertain Pope Clement VII",
                    TournamentType = "Without Mount",
                    Participants = 30,
                    Champion = "creddred",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_11.png", // URL image tournoi
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_foot_1.png", // URL image tournoi
                };
                Tournament tournament12 = new Tournament()
                {
                    TournamentName = "Annunciation Tournament",
                    TournamentDate = Convert.ToDateTime("15/02/1392"),
                    Price = 10,
                    Prize = 500,
                    TournamentLocation = "Castle of Falaise",
                    Description = "You can sprinkle your crepes with sugar or even the blood of our fighters, it's up to you",
                    TournamentType = "With Mount",
                    Participants = 30,
                    Champion = "creddred",
                    Images = "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_12.png", // URL image tournoi
                    Videos = "http://milhiecreation.com/imagesHackaton/Tournament/bg_horse_1.png", // URL image tournoi
                };

                context.AddRange(tournament1, tournament2, tournament3, tournament4, tournament5, tournament6, tournament7, tournament8, tournament9,tournament10, tournament11, tournament12);
                context.SaveChanges();

                Knight knight1 = new Knight()
                {
                    KnightName = "Anosdagan",
                    Age = 24,
                    Victories = 10,
                    Defeats = 1,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_1.png", // URL banner
                    Weapons = "Sword, shield",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = true,
                    MountType = "Warhorse",
                    MountTypeIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png", // URL typeIcons
                    MountName = "Cannasson",
                    Moto = "Houra!",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Anosdagan.png", // URL avatar
                    Region = "Francie",
                    Pigeon = "Anosdagan_Iledefrance@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 3,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_bronze.png", // URL RankingIcons
                    SuccessIcons = "http://milhiecreation.com/imagesHackaton/success/success_1tournament.png" // URL SuccessIcons

                };
                Knight knight2 = new Knight()
                {
                    KnightName = "Autfred",
                    Age = 32,
                    Victories = 3,
                    Defeats = 6,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_2.png", // URL banner
                    Weapons = "Spear",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Breastplate",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "I am not afraid of death !",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Autfred.png", // URL avatar
                    Region = "Berry",
                    Pigeon = "Autfred_Berry@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 21,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight3 = new Knight()
                {
                    KnightName = "Bertlance",
                    Age = 43,
                    Victories = 25,
                    Defeats = 9,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_3.png", // URL banner
                    Weapons = "Mace",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Chainmail",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Fear me !",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Bertlance.png", // URL avatar
                    Region = "Lyonnois",
                    Pigeon = "Bertlance_Lyonnois@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 4,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight4 = new Knight()
                {
                    KnightName = "Aeltor",
                    Age = 22,
                    Victories = 0,
                    Defeats = 5,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_4.png", // URL banner
                    Weapons = "Wood stick",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quilted weave",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "these last words are 'stop it!'",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Aeltor.png", // URL avatar
                    Region = "Chaimpaigne",
                    Pigeon = "Aeltor_Chaimpaigne@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = false,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png", // URL AliveIcons
                    Ranking = 25,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight5= new Knight()
                {
                    KnightName = "Creddred",
                    Age = 28,
                    Victories = 31,
                    Defeats = 0,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_5.png", // URL banner
                    Weapons = "Two handed sword",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = true,
                    MountType = "Griffon",
                    MountTypeIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png", // URL typeIcons
                    MountName = "Ragnar",
                    Moto = "Cool, you are food for my pet",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Creddred.png", // URL avatar
                    Region = "Languedoc",
                    Pigeon = "Creddred_Languedoc@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 1,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_or.png", // URL RankingIcons
                    SuccessIcons = "http://milhiecreation.com/imagesHackaton/success/success_1tournament.png , https://cdn.discordapp.com/attachments/778897010711330846/779148773964120084/success_3tournament.png" // URL SuccessIcons

                };
                Knight knight6 = new Knight()
                {
                    KnightName = "Daganho",
                    Age = 23,
                    Victories = 0,
                    Defeats = 0,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_6.png", // URL banner
                    Weapons = "Dague",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quilted weave",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Tzi shu force is with me",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Daganho.jpg", // URL avatar
                    Region = "Normaundie",
                    Pigeon = "Daganho_Normaundie@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 20,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight7 = new Knight()
                {
                    KnightName = "Ethward",
                    Age = 29,
                    Victories = 15,
                    Defeats = 8,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_7.png", // URL banner
                    Weapons = "Bow",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quilted Weave",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "My arrows are faster than your weapons",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Ethward.png", // URL avatar
                    Region = "Orleanois",
                    Pigeon = "Ethward_Orleanois@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 9,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight8 = new Knight()
                {
                    KnightName = "Holdjamy",
                    Age = 34,
                    Victories = 25,
                    Defeats = 4,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_8.png", // URL banner
                    Weapons = "Hammer",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Vikings armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = true,
                    MountType = "Wolf",
                    MountTypeIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png", // URL typeIcons
                    MountName = "Canis",
                    Moto = "I have thor's hammer!",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Holdjamy.png", // URL avatar
                    Region = "Aquitaine",
                    Pigeon = "Holdjamy_Aquitaine@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 2,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_silver.png", // URL RankingIcons
                    SuccessIcons = "http://milhiecreation.com/imagesHackaton/success/success_1tournament.png" // URL SuccessIcons

                };
                Knight knight9 = new Knight()
                {
                    KnightName = "Jasmor",
                    Age = 31,
                    Victories = 8,
                    Defeats = 6,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_2.png", // URL banner
                    Weapons = "Scourge",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Scale armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = true,
                    MountType = "Pagasus",
                    MountTypeIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png", // URL typeIcons
                    MountName = "Pegasus",
                    Moto = "My animal is still in the air",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Jasmor.png", // URL avatar
                    Region = "Berry",
                    Pigeon = "Jasmor_Berry@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 11,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight10 = new Knight()
                {
                    KnightName = "Leodagan",
                    Age = 25,
                    Victories = 15,
                    Defeats = 4,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_7.png", // URL banner
                    Weapons = "Axe",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = true,
                    MountType = "Hippogriff",
                    MountTypeIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png", // URL typeIcons
                    MountName = "Buck",
                    Moto = "Comme and measure yourself against me",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Leodagan.png", // URL avatar
                    Region = "Orleanois",
                    Pigeon = "Leodagan_Orleanois@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 5,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight11 = new Knight()
                {
                    KnightName = "Lotaut",
                    Age = 25,
                    Victories = 6,
                    Defeats = 4,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_4.png", // URL banner
                    Weapons = "Dagger",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quited weave",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = true,
                    MountType = "Boar",
                    MountTypeIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png", // URL typeIcons
                    MountName = "Grouik",
                    Moto = "My pet isn't fodd",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Lotaut.png", // URL avatar
                    Region = "Chaimpaigne",
                    Pigeon = "Lotaut_Chaimpaigne@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 15,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight12 = new Knight()
                {
                    KnightName = "Nulfar",
                    Age = 29,
                    Victories = 1,
                    Defeats = 8,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_8.png", // URL banner
                    Weapons = "Sword",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Harness",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "I will be the best !",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Nulfar.png", // URL avatar
                    Region = "Aquitaine",
                    Pigeon = "Nulfar_Aquitaine@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = false,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png", // URL AliveIcons
                    Ranking = 24,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight13 = new Knight()
                {
                    KnightName = "Percyward",
                    Age = 28,
                    Victories = 2,
                    Defeats = 4,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_6.png", // URL banner
                    Weapons = "Sword",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Harness",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "I will be the best !",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Percyward.png", // URL avatar
                    Region = "Normaundie",
                    Pigeon = "Percyward_Normaundie@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = false,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png", // URL AliveIcons
                    Ranking = 23,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight14 = new Knight()
                {
                    KnightName = "Agaaut",
                    Age = 28,
                    Victories = 19,
                    Defeats = 8,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_5.png", // URL banner
                    Weapons = "Hallebarde",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Drop to my halberd",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Agaaut.png", // URL avatar
                    Region = "Languedoc",
                    Pigeon = "Agaaut_Languedoc@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 6,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight15 = new Knight()
                {
                    KnightName = "Bojas",
                    Age = 18,
                    Victories = 4,
                    Defeats = 4,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_5.png", // URL banner
                    Weapons = "Spear",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Breastplate",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Drop to my halberd",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Bojas.png", // URL avatar
                    Region = "Languedoc",
                    Pigeon = "Bojas_Languedoc@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 17,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight16 = new Knight()
                {
                    KnightName = "Jeain",
                    Age = 27,
                    Victories = 17,
                    Defeats = 9,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_8.png", // URL banner
                    Weapons = "Mace",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Chainmail",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = true,
                    MountType = "Unicorn",
                    MountTypeIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png", // URL typeIcons
                    MountName = "Pony",
                    Moto = "Do you know the realy death ?",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Jeain.jpg", // URL avatar
                    Region = "Aquitaine",
                    Pigeon = "Jeain_Aquitaine@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 7,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight17 = new Knight()
                {
                    KnightName = "Nardarnold",
                    Age = 27,
                    Victories = 5,
                    Defeats = 4,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_4.png", // URL banner
                    Weapons = "Scourge",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Scale Armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Could you be nice to me ?",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Nardarnold.jpg", // URL avatar
                    Region = "Chaimpaigne",
                    Pigeon = "Nardarnold_Chaimpagne@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 18,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight18 = new Knight()
                {
                    KnightName = "Tuslot",
                    Age = 27,
                    Victories = 0,
                    Defeats = 1,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_7.png", // URL banner
                    Weapons = "Dagger",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quilted weave",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Let's go",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Tuslot.jpg", // URL avatar
                    Region = "Orleanois",
                    Pigeon = "Tuslot_Orleanois@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = false,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png", // URL AliveIcons
                    Ranking = 22,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight19 = new Knight()
                {
                    KnightName = "Valeranos",
                    Age = 27,
                    Victories = 9,
                    Defeats = 4,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_6.png", // URL banner
                    Weapons = "Scourge",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate Armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = true,
                    MountType = "Camel",
                    MountTypeIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png", // URL typeIcons
                    MountName = "Case",
                    Moto = "Say your prayer",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Valeranos.png", // URL avatar
                    Region = "Normaundie",
                    Pigeon = "Valeranos_Normaundie@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 8,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight20 = new Knight()
                {
                    KnightName = "Reindric",
                    Age = 44,
                    Victories = 37,
                    Defeats = 25,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_1.png", // URL banner
                    Weapons = "Sword",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Plate Armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "There was a time when i was first",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Reindric.jpg", // URL avatar
                    Region = "Francie",
                    Pigeon = "Reindric_Francie@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 10,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png", // URL RankingIcons
                    SuccessIcons = "https://cdn.discordapp.com/attachments/778897010711330846/779148773964120084/success_2tournament.png" // URL SuccessIcons

                };
                Knight knight21 = new Knight()
                {
                    KnightName = "Rollrein",
                    Age = 21,
                    Victories = 3,
                    Defeats = 1,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_1.png", // URL banner
                    Weapons = "Mace",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Chainmail",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "I have the courage to face the greatest",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Rollrein.png", // URL avatar
                    Region = "Francie",
                    Pigeon = "Rollrein_Francie@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 19,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight22 = new Knight()
                {
                    KnightName = "Tanje",
                    Age = 24,
                    Victories = 7,
                    Defeats = 3,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_2.png", // URL banner
                    Weapons = "Sword",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Breastplate",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "I learn every day",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Tanje.jpg", // URL avatar
                    Region = "Berry",
                    Pigeon = "Tanje_Berry@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 16,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight23 = new Knight()
                {
                    KnightName = "Telperce",
                    Age = 28,
                    Victories = 14,
                    Defeats = 8,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_3.png", // URL banner
                    Weapons = "Spear",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Harness",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "Call me the last punishment",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Telperce.png", // URL avatar
                    Region = "Lyonnois",
                    Pigeon = "Telperce_Lyonnois@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 12,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight24 = new Knight()
                {
                    KnightName = "Thurward",
                    Age = 36,
                    Victories = 14,
                    Defeats = 11,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_2.png", // URL banner
                    Weapons = "Axe",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Scale Armor",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "like King Leonidas: Spartan what is your profession ? HAOU!",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Thurward.jpg", // URL avatar
                    Region = "Berry",
                    Pigeon = "Thurward_Berry@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = true,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png", // URL AliveIcons
                    Ranking = 13,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "" // URL SuccessIcons

                };
                Knight knight25 = new Knight()
                {
                    KnightName = "Vallande",
                    Age = 26,
                    Victories = 18,
                    Defeats = 9,
                    Banner = "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_7.png", // URL banner
                    Weapons = "Dagger",
                    WeaponsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png", // URL weaponsIcons
                    Armors = "Quilted Weave",
                    ArmorsIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png", // URL armorIcons
                    Mount = false,
                    MountType = "",
                    MountTypeIcons = "", // URL typeIcons
                    MountName = "",
                    Moto = "You were born dust and you will be again",
                    Avatar = "http://milhiecreation.com/imagesHackaton/Avatar/Vallande.png", // URL avatar
                    Region = "Orleanois",
                    Pigeon = "Vallande_Orleanois@pigeon.com", //adress mail
                    PigeonIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png", // URL PigeonIcons
                    Alive = false,
                    AliveIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png", // URL AliveIcons
                    Ranking = 14,
                    RankingIcons = "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png", // URL RankingIcons
                    SuccessIcons = "", // URL SuccessIcons
                };
                context.AddRange(knight1, knight2, knight3, knight4, knight5, knight6, knight7, knight8, knight9, knight10, knight11, knight12, knight13,
                    knight14, knight15, knight16, knight17, knight18, knight19, knight20, knight21, knight22, knight23, knight24, knight25);
                context.SaveChanges();
            }
        }
    }
}
