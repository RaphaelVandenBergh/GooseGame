using GameOfGoose.Core.Domain;
using System;

namespace GameOfGoose.Core.Squares
{
    public class Bridge : ISquare
    {
        public int Position { get; set; }
        public SquareType Type { get; set; }

        public Bridge(int position)
        {
            Position = position;
            Type = SquareType.Bridge;
        }

        public void ProcessPlayer(Player player)
        {
            player.MoveToPosition(12);
            Console.WriteLine($"Player {player.Id} has crossed the bridge they move to {player.Position}");
        }
    }
}