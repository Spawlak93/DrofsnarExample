using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class Player
    {
        public Player(int lives, int score)
        {
            Lives = lives;
            Score = score;
        }
        
        public int Lives { get; set; }
        public int Score { get; set; }
    }
}