using System;
using System.Collections.Generic;

namespace Scrabble.Model
{
    public class Player : IComparable
    {
        // Player data
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int score;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string LastAction;

        public List<Tile> PlayingTiles;

        public Player()
        {
            PlayingTiles = new List<Tile>();
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Player OtherPlayer = obj as Player;
            if (OtherPlayer != null)
                return this.Score.CompareTo(OtherPlayer.Score);
            else
                throw new ArgumentException(Scrabble2018.Locales.skin.Player_PlayerException);
        }

        public override string ToString()
        {
            //return "Player " + this.id + " has scores " + this.score + " now!";
            return Scrabble2018.Locales.skin.Player_PlayerScore1; this.id, Scrabble2018.Locales.skin.Player_PlayerScore2; this.score;
            //redesign split into two strings; Player {0} scored {1} points now! --> Player {0} + Points Scored: {0}
        }

    }
}
