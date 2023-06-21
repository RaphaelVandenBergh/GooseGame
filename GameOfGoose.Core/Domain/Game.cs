using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace GameOfGoose.Core.Domain
{
    public class Game
    {
        public List<Player> Players { get; set; }

        public Game(int Amount)
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Players = new List<Player>();
            for (int i = 0; i < Amount; i++)
            {
                Players.Add(new Player(i+1));
            }
        }

        public void Playing()
        {
            Random random = new Random();
            while (!Players.Exists(p=>p.HasWon==true))
            {
                foreach (Player player in Players)
                {
                    
                    int throw1 = random.Next(1, 7);
                    int throw2 = random.Next(1, 7);
                    int total = throw1 + throw2;
                    player.Move(total);
                    if (player.HasWon)
                    {
                        
                        break;
                    }
                }   
            }
            
        }


    }
}