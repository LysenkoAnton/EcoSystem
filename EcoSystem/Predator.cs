using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Predator:Fish
    {
        const int TIMETOEAT = 6;
        private int _timeToEat;
        public static int PredatorCount;
        public Predator(Coordinate pos, char simbol = 'S') : base(pos, simbol)
        {
            PredatorCount++;
            _timeToEat = TIMETOEAT;
        }

        public void PredatorEat()
        {
            _timeToEat = TIMETOEAT;
        }
    }

}
