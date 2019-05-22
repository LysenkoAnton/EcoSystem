using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Fish:Cell
    {
        const int REPRODUCETIME = 6;
        public static int FishCount;
        public Random _random;
        private int _timeReproduce;
        public Fish(Coordinate pos, char simbol = ' ') : base(pos, simbol)
        {
            FishCount++;
            _timeReproduce = REPRODUCETIME;
        }

        public void Move()
        {
           
            switch (_random.Next(0, 8))
            {
                case 0:
                    GetPosition().ChangeCoordinate(0, 1);
                    break;
                case 1:
                    GetPosition().ChangeCoordinate(1, 0);
                    break;
                case 2:
                    GetPosition().ChangeCoordinate(-1, 0);
                    break;
                case 3:
                    GetPosition().ChangeCoordinate(0, -1);
                    break;
                case 4:
                    GetPosition().ChangeCoordinate(-1, 1);
                    break;
                case 5:
                    GetPosition().ChangeCoordinate(1, -1);
                    break;
                case 6:
                    GetPosition().ChangeCoordinate(1, 1);
                    break;
                case 7:
                    GetPosition().ChangeCoordinate(-1, -1);
                    break;
            }

            if(_timeReproduce == 0)
            {
                Reproduce();
            }
        }

        public Fish Reproduce()
        {
            if (this is Prey)
            {
                return new Prey(GetPosition()); 
            }
            else
            {
                return new Predator(GetPosition());
            }
        }

        public Cell ToDie()
        {
                return new Cell(GetPosition());
        }

    }
}
