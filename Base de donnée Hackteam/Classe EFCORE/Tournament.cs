using System;

namespace Base_de_donnée_Hackteam
{
	public class Tournament
	{
		public int TournamentId { get; set; }
		public string TournamentName { get; set; } // nom du tournois
		public DateTime TournamentDate { get; set; } // date du tournoi
		public int Price { get; set; } // prix d'inscription
		public int Prize { get; set; } // prix de recompense
		public string TournamentLocation { get; set; } // adresse du tournoi
		public string TournamentType { get; set; } // type du tournoi ( cheval ou a pied)
		public string Description { get; set; } // description du tournois
		public int Participants { get; set; } // NB de participants
		public string Champion { get; set; } // Champion en titre
		public string Images { get; set; } //URL image
		public string Videos { get; set; } // URL  video
	}
}