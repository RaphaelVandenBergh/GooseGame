using System;
using GameOfGoose.Core.Domain;

namespace GameOfGoose.Core.Squares
{
    internal class Prison : ISquare
    {
        public int Position { get; set; }
        public SquareType Type { get; set; }

        public Prison(int position)
        {
            Position = position;
        }

        public void ProcessPlayer(Player player)
        {
            Console.WriteLine($"Player {player.Id} has been found guilty of tax evasion and been sent to prison for 3 turns");
            player.Skipping = 3;
        }
    }
}