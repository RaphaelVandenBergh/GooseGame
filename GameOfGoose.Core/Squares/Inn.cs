using System;
using GameOfGoose.Core.Domain;

namespace GameOfGoose.Core.Squares
{
    internal class Inn : ISquare
    {
        public Inn(int position)
        {
            Position = position;
            Type = SquareType.Inn;
        }
        public int Position { get; set; }
        public SquareType Type { get; set; }

        public void ProcessPlayer(Player player)
        {
            Console.WriteLine($"Player {player.Id} took a nap at the inn and skipped his next turn");
            player.Skipping = 1;
        }
    }
}