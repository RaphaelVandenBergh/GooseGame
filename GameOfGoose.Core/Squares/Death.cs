using GameOfGoose.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Core.Squares
{
    public class Death : ISquare
    {
        public Death(int position)
        {
            Position = position;
            Type = SquareType.Death;
        }

        public int Position { get ; set; }
        public SquareType Type { get; set; }

        public void ProcessPlayer(Player player)
        {
            Console.WriteLine($"Player {player.Id} has died and starts over again");
            player.MoveToPosition(1);
        }
    }
}
