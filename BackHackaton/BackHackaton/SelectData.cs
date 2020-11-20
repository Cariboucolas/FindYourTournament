using BackHackaton.BDD.ClassesEfCore;
using BackHackaton.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackHackaton
{
    public static class  SelectData
    {

        public static List<Tournament> SelectAllTournaments()
        {
           
            List<Tournament> tournaments = new List<Tournament>();
            TournamentContext context = new TournamentContext();

            foreach (Tournament tournament in context.Tournament)
            {
                tournaments.Add(tournament);
            }

            return tournaments;
        }

        public static List<Knight> SelectAllKnights()
        {
            List<Knight> knights = new List<Knight>();
            TournamentContext context = new TournamentContext();

            foreach (Knight tournament in context.Knight)
            {
                knights.Add(tournament);
            }

            return knights;
        }

     

        internal static List<Knight> SelectAliveKnights()
        {
            List<Knight> knights = new List<Knight>();
            TournamentContext context = new TournamentContext();
            //  var CougarsAnimalsCount = context.Animals.Where((a) => a.Specie.SpecieName == "Cougars blancs")
            foreach (Knight tournament in context.Knight.Where((knight) => knight.Alive == true))
            {
                knights.Add(tournament);
            }

            return knights;
        }


        internal static List<Knight> SelectKnightsHaveAMount()
        {
            List<Knight> knights = new List<Knight>();
            TournamentContext context = new TournamentContext();
            //  var CougarsAnimalsCount = context.Animals.Where((a) => a.Specie.SpecieName == "Cougars blancs")
            foreach (Knight tournament in context.Knight.Where((knight) => knight.Mount == true))
            {
                knights.Add(tournament);
            }

            return knights;
        }
    }
    
    
}
