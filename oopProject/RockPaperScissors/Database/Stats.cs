using System;

namespace RockPaperScissors.Database
{
    public class Stats
    {
        public int TotalGamesPlayed {
            get 
                {
                    return Preferences.Default.Get("total_games", 0);
                } 
            set 
                {
                    Preferences.Default.Set("total_games", value);
                } 
        }

        public int PlayerWins
        {
            get
            {
                return Preferences.Default.Get("player_wins", 0);
            }
            set
            {
                Preferences.Default.Set("player_wins", value);
            }
        }

        public int AIWins
        {
            get
            {
                return Preferences.Default.Get("ai_wins", 0);
            }
            set
            {
                Preferences.Default.Set("ai_wins", value);
            }
        }

        public int PlayerChoseRock
        {
            get
            {
                return Preferences.Default.Get("player_rock", 0);
            }
            set
            {
                Preferences.Default.Set("player_rock", value);
            }
        }

        public int PlayerChosePaper
        {
            get
            {
                return Preferences.Default.Get("player_paper", 0);
            }
            set
            {
                Preferences.Default.Set("player_paper", value);
            }
        }
        public int PlayerChoseScissors
        {
            get
            {
                return Preferences.Default.Get("player_scissors", 0);
            }
            set
            {
                Preferences.Default.Set("player_scissors", value);
            }
        }

    }
}
