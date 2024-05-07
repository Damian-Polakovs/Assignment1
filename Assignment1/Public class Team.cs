using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Assignment1
{

    public class Team
    {
        public int Position { get; set; } = 0;
        public string TeamName { get; set; }
        public int MatchesPlayed { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; } public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifference => GoalsFor - GoalsAgainst;
        public int Points => (Wins * 3) + Draws;
        public string BadgeImagePath { get; set; }

        public List<string> Players {get; set;}
        public string Manager { get; set; }

        public Team(string teamName, int matchesPlayed, int wins, int draws, int losses, int goalsFor, int goalsAgainst, List<string> players, string manager, string badgeImagePath)
        {
            TeamName = teamName;
            MatchesPlayed = matchesPlayed;
            Wins = wins;
            Draws = draws;
            Losses = losses;
            GoalsFor = goalsFor;
            GoalsAgainst = goalsAgainst;
            Players = players;
            Manager = manager;
            BadgeImagePath = badgeImagePath;
        }


    }
}
