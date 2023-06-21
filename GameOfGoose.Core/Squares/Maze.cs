using GameOfGoose.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Core.Squares
{
    internal class Maze : ISquare
    {
        public Maze(int position)
        {
            Position = position;
            Type = SquareType.Maze;
        }

        public int Position { get; set; }
        public SquareType Type { get; set; }

        public void ProcessPlayer(Player player)
        {
            player.MoveToPosition(39);
            Console.WriteLine($"Player {player.Id} has entered the maze they move to {player.Position}");
        }
    }
}
