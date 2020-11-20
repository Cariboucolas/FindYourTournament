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
		public string Banner { get; set; } // URL de son badge
		public string Weapons { get; set; } // arme
		public string WeaponsIcons { get; set; } // URL des armes
		public string Armors { get; set; } // Armure
		public string ArmorsIcons { get; set; } // url d'armure
		public bool Mount { get; set; } // Monture
		public string MountType { get; set; } // type de monture
		public string MountTypeIcons { get; set; } // url tye de monture
		public string MountName { get; set; } // nom de la monture
		public string Moto { get; set; } // son expression
		public string Avatar { get; set; } // adresse URL de son avatar
		public string Region { get; set; } // d'ou il vient
		public string Pigeon { get; set; }
		public string PigeonIcons { get; set; }// adresse email
		public bool Alive { get; set; }
		public string AliveIcons { get; set; }// en vie 
		public int Ranking { get; set; } // classement
		public string RankingIcons { get; set; }
		public string SuccessIcons { get; set; }

	}
}