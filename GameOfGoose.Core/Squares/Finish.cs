using GameOfGoose.Core.Domain;
using GameOfGoose.Core.Squares;
using System;

namespace GameOfGoose.Core.Factories
{
    internal class Finish : ISquare
    {
        public Finish(int position)
        {
            Position = position;
            Type = SquareType.Finish;
        }

        public int Position { get; set; }
        public SquareType Type { get; set; }

        public void ProcessPlayer(Player player)
        {
            Console.WriteLine($"Player {player.Id} rolled a {player.LastThrow} they have won this round of goosegame");
            player.HasWon = true;
        }
    }
}