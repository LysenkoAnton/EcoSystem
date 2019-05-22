using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Prey:Fish
    {
        
        public static int PreyCount;
        
        public Prey(Coordinate pos, char simbol = 'f') : base(pos, simbol)
        {
            PreyCount++;
        }
    }
}
