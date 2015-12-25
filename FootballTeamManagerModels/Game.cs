using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamManagerModels
{
    public class Game
    {
        public Game()
        {
            Players = new HashSet<Player>();
            GoalsScored = new HashSet<Goal>();
        }
        public int GameID { get; set; }
        public string Opponent { get; set; }
        public DateTime Date { get; set; }
        public byte GoalsMissed { get; set; }
        public Result GameResult { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Goal> GoalsScored { get; set; }
        public virtual Tournament Tournament { get; set; }
    }

    public enum Result
    {
        win,
        draw,
        lose
    }
}
