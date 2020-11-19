namespace BackHackaton
{
 
        public class Knight
        {
            public Guid KnightId { get; set; }
            public string KnightName { get; set; } // son nom

            public int Age { get; set; } // age

            public int Victories { get; set; } // nb de vitoires

            public int Defeats { get; set; }  // nb de defaites
            public string Badge { get; set; } // URL de son badge
            public string Moto { get; set; } // son expression
            public string Avatar { get; set; } // adresse URL de son avatar
            public string Region { get; set; } // d'ou il vient
            public string Pigeon { get; set; } // adresse email
            public Boolean Alive { get; set; } // en vie 
            public int Ranking { get; set; } // classement
            public ICollection<Gear> Gear { get; set; } // liste d'equipements
            public ICollection<Mount> Mount { get; set; } // liste de montures

 
    }
}