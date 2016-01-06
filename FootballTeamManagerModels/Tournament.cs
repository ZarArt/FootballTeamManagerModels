using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FootballTeamManagerModels
{
    public class Tournament
    {
        public Tournament()
        {
            Games = new HashSet<Game>();
            Players = new HashSet<Player>();
        }
        public int TournamentID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
