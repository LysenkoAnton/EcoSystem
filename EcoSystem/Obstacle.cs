using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Obstacle:Cell
    {
        public static int ObstacleCount;
        public Obstacle(Coordinate pos, char simbol = '#') : base(pos,simbol)
        {
            ObstacleCount++;
        }
    }
}
