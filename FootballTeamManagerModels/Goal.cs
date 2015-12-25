using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamManagerModels
{
    public class Goal
    {
        public int GoalID { get; set; }
        public Byte Minute { get; set; }
        public virtual Player Author { get; set; }
        public virtual Game Game { get; set; }
    }
}
