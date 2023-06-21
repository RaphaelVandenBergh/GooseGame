using GameOfGoose.Core.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace GameOfGoose.Core.Squares
{
    internal class Well : ISquare
    {
        public Well(int position)
        {
            Position = position;
            Type = SquareType.Well;
            Players = new List<Player>();
        }

        public int Position { get; set; }

        public IList<Player> Players { get; set; }
        public SquareType Type { get; set; }

        public void ProcessPlayer(Player player)
        {
            player.InWell = true;
            player.TurnsInWell++;
            Players.Add(player);
            if (Players.Count > 1)
            {
                Player LongestInWell = Players[0];
                foreach (Player p in Players)
                {
                    if (p.TurnsInWell > LongestInWell.TurnsInWell)
                    {
                        LongestInWell = p;
                    }
                }
                Console.WriteLine($"player {LongestInWell.Id} has been saved from the well");
                LongestInWell.InWell = false;
            }


        }
    }
}