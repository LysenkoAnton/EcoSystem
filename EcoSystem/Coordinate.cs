using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Coordinate
    {
        private int _x;
        private int _y;

        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void ChangeCoordinate(int x, int y)
        {
            _x += x;
            _y += y;
        }

        public void NewCoordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
