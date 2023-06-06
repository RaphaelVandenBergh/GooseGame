using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfGoose.Core.Domain
{
    public class Game
    {
        public List<Player> Players { get; set; }

        public Game(int Amount)
        {
            Players = new List<Player>();
            for (int i = 0; i < Amount; i++)
            {
                Players.Add(new Player(i+1));
            }
        }


    }
}