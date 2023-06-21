using System;
using GameOfGoose.Core.Domain;

namespace GameOfGoose.Core.Squares
{
    public class Square : ISquare
    {
        public int Position { get; set; }
        public SquareType Type { get; set; }

        public Square(int position)
        {
            Position = position;
            Type = SquareType.Normal;
        }

        public void ProcessPlayer(Player player)
        {
            Console.WriteLine($"Player {player.Id} rolled a {player.LastThrow} and moved to {Position}");
        }
    }
}