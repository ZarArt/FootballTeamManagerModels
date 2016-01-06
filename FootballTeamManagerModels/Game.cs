using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
        public int TournamentID { get; set; }
        public string Opponent { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM.dd.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public byte GoalsMissed { get; set; }
        public Result GameResult { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Goal> GoalsScored { get; set; }
        public virtual Tournament Tournament { get; set; }
    }

    public enum Result
    {
        Win,
        Draw,
        Lose
    }
}
