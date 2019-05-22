using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Cell
    {
        public static int CellCount;
        private char _simbol;
        private Coordinate _position;
        public Cell(Coordinate pos, char simbol = ' ')
        {
            _position = pos;
            _simbol = simbol;
            CellCount++;
        }
        
        public Coordinate GetPosition()
        {
            return _position;
        }

        public void SetPosition(Coordinate pos)
        {
            _position = pos;
        }

        public void Display()
        {
            Console.Write(_simbol);
        }

    }
}
