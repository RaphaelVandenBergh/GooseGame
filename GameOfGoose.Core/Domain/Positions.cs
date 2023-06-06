using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Core.Domain
{
    public enum Positions
    {
        Start = 0,
        BridgeStart = 6,
        BridgeEnd = 12,
        Inn = 19,
        Well = 31,
        MazeStart = 42,
        MazeEnd = 39,
        Prison = 52,
        Death = 58,
        Finish = 63
    }
}
