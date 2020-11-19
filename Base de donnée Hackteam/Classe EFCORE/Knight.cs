using System.Collections.Generic;

namespace Base_de_donnée_Hackteam
{
	public class Knight
	{
		public int KnightId { get; set; }
		public string KnightName { get; set; } // son nom

		public int Age { get; set; } // age

		public int Victories { get; set; } // nb de vitoires

		public int Defeats { get; set; }  // nb de defaites
		public string Badge { get; set; } // URL de son badge
		public string Weapons { get; set; }
		public string Armors { get; set; }
		public bool Mount { get; set; }
		public string MountType { get; set; }
		public string MountName { get; set; }
		public string Moto { get; set; } // son expression
		public string Avatar { get; set; } // adresse URL de son avatar
		public string Region { get; set; } // d'ou il vient
		public string Pigeon { get; set; } // adresse email
		public bool Alive { get; set; } // en vie 
		public int Ranking { get; set; } // classement

	}
}