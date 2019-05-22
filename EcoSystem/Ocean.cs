using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Ocean
    {
        private Cell[,] _flatness;
        private int _size;
        private int _step;
        private int _row;
        private int _column;
        Random _random;


        public Ocean(int colum, int row)
        {
            _column = colum;
            _row = row;
            _size = _row * _column;
            _flatness = new Cell[_row, _column];
            _random = new Random();
            
        }

        public void CreateObjects()
        {
            for (int i = 0; i < _row - 1; i++)
            {
                for (int j = 0; j < _column - 1; j++)
                {
                    switch (_random.Next(1, 50))
                    {
                        case 1:
                            _flatness[i, j] = new Prey(new Coordinate(i, j));
                            break;
                        case 2:
                            _area[i, j] = new Shark(new Coordinate(i, j), Swop, MakeNewFish, KillFish, isFood);
                            _sharksNumber++;
                            break;
                        case 5:
                            _area[i, j] = new Block(new Coordinate(i, j));
                            break;
                        default:
                            _area[i, j] = new Cell(new Coordinate(i, j));
                            break;
                    }
                }
            }
        }
    }
}
