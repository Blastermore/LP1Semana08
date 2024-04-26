using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager1
{
    public class Player
    {
        public Player(name, score)
        {
            Name = name;
            Score = score;
        }
        public string Name {get;}
        public int Score {get;private set;}
    }
}