using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class Player : IComparable<Player>
    {
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public string Name {get;}
        public int Score {get;private set;}
        public int CompareTo(Player other)
        {
            if (other == null) return 1;
            return other.Score - this.Score;
        }
    }
}