using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Core.Squares
{
    public enum SquareType
    {
        Start = 1,
        Bridge = 6,
        Inn = 19,
        Well = 31,
        Maze = 42,
        Prison = 52,
        Death = 58,
        Finish = 63,
        Goose,
        Overshoot,
        Normal
    }
}
