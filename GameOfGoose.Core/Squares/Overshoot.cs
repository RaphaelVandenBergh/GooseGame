using System;
using GameOfGoose.Core.Domain;

namespace GameOfGoose.Core.Squares
{
    internal class Overshoot : ISquare
    {
        public Overshoot(int position)
        {
            Position = position;
            Type = SquareType.Overshoot;
        }

        public int Position { get; set; }
        public SquareType Type { get; set; }

        public void ProcessPlayer(Player player)
        {
            player.IsOvershot = true;
            player.MoveToPosition(63 - (Position-63));
            Console.WriteLine($"Player {player.Id} rolled a {player.LastThrow} they overshot and move back to {63 - (Position - 63)} ");
        }
    }
}