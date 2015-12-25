using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FootballTeamManagerModels
{
    public class Player
    {
        public Player()
        {
            Games = new HashSet<Game>();
            Goals = new HashSet<Goal>();
            Tournaments = new HashSet<Tournament>();
        }
        public int PlayerID { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<Tournament> Tournaments { get; set; }

    }
}
