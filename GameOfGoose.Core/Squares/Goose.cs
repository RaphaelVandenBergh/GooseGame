using GameOfGoose.Core.Domain;
using System;

namespace GameOfGoose.Core.Squares
{
    internal class Goose : ISquare
    {
        public Goose(int position)
        {
            Position = position;
            Type = SquareType.Goose;
        }

        public int Position { get; set; }
        public SquareType Type { get; set; }

        public void ProcessPlayer(Player player)
        {
            if (player.IsOvershot)
            {
                Console.WriteLine($"Player {player.Id} landed on a goose on his way back and moves to {player.Position}");
                player.MoveToPosition(player.Position - player.LastThrow);
            }
            else
            {
                Console.WriteLine($"Player {player.Id} landed on a goose and moves to {player.Position}");
                player.MoveToPosition(player.Position + player.LastThrow);
            }
        }
    }
}