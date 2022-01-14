using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class Scorer
    {
        private readonly Dictionary<string, int> _birdValues = new System.Collections.Generic.Dictionary<string, int>
        {
            {"Bird", 10},
            {"CrestedIbis", 100},
            {"GreatKiskudee", 300},
            {"RedCrossbill", 500},
            {"Red-neckedPhalarope", 700},
            {"EveningGrosbeak", 1000},
            {"GreaterPrairieChicken", 2000},
            {"IcelandGull", 3000},
            {"Orange-BelliedParrot", 5000}
        };

        private int _hunterValue = 200;

        private readonly Player _player;
        public Scorer(Player player)
        {
            _player = player;
        }

        public void ScorePoints(string action)
        {
            if(action == "VulnerableBirdHunter")
            {
                _player.Score += _hunterValue;
                _hunterValue *= 2;
            }
            else if (action == "InvulnerableBirdHunter")
            {
                _player.Lives -= 1;
                _hunterValue = 200;
            }
            else
            {
                _player.Score += _birdValues[action];
            }
        }
    }
}