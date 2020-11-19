using System;

namespace BackHackaton.Controllers
{
    public class Tournaments
    {
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public DateTime TournamentDate { get; set; }
       public int Price { get; set; }
        public int Prize { get; set; }
        public string TournamentLocation { get; set; }
        public string TournamentType { get; set; }
        public string Descrpition { get; set; }
        public int Participants { get; set; }
        public int Champion { get; set; }
        public string Images { get; set; }
        public string Videos { get; set; }
    }
}