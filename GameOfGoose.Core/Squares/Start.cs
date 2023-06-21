using GameOfGoose.Core.Domain;
using System;
using System.Threading.Channels;

namespace GameOfGoose.Core.Squares
{
    public class Start : ISquare
    {
        public Start(int position)
        {
            Position = position;
            Type = SquareType.Start;
        }

        public int Position { get; set; }
        public SquareType Type { get; set; }

        public void ProcessPlayer(Player player)
        {
            Random rnd = new Random();
            

            if (player.LastThrow == 9)
            {
                if (rnd.Next(100)>50)
                {
                    Console.WriteLine($"Player {player.Id} rolled a 6 and 3 and proceeds to 53");
                    player.MoveToPosition(53);
                }
                else
                {
                    Console.WriteLine($"Player {player.Id} rolled a 5 and 4 and proceeds to 26");

                    player.MoveToPosition(26);
                }

            }
            else
            {
                player.MoveToPosition(player.Position + player.LastThrow);
            }
        }
    }
}