using GameOfGoose.Core.Squares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Core.Factories
{
    public class SquareFactory : ISquareFactory
    {
        public ISquare CreateSquare(int position, SquareType type)
        {
            switch (type)
            {
                case SquareType.Start:
                    return new Start(position); 
                case SquareType.Bridge:
                    return new Bridge(position);
                case SquareType.Goose:
                    return new Goose(position);
                case SquareType.Inn:
                    return new Inn(position);
                case SquareType.Well:
                    return new Well(position);
                case SquareType.Maze:
                    return new Maze(position);
                case SquareType.Prison:
                    return new Prison(position);
                case SquareType.Death:
                    return new Death(position);
                case SquareType.Finish:
                    return new Finish(position);
                case SquareType.Overshoot:
                    return new Overshoot(position);
                default:
                    return new Square(position);
            }
        }
    }
}
