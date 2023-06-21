using System;
using GameOfGoose.Core.Squares;

namespace GameOfGoose.Core.Domain
{
    public class Player
    {
        public int Position { get; set; }
        public int Id { get; set; }
        public bool HasWon { get; set; }
        public int Skipping { get; set; }
        public bool InWell { get; set; }
        public int TurnsInWell { get; set; }
        public int LastThrow { get; set; }
        public bool IsOvershot { get; set; }

        public Player(int id)
        {
            Position = 1;
            HasWon = false;
            Skipping = 0;
            InWell = false;
            TurnsInWell = 0;
            Id = id;

            LastThrow = 0;
            IsOvershot = false;
        }

        public void MoveToPosition(int position)
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Position = position;
            if (position != 1)
            {
                ISquare square = gameBoard.GetSquare(Position);
                square.ProcessPlayer(this);
            }
        }

        public void Move(int amount)
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            IsOvershot = false;
            LastThrow = amount;

            if (Position == 1)
            {
                ISquare startsquare = gameBoard.GetSquare(Position);
                startsquare.ProcessPlayer(this);
                return;
            }

            if (Skipping > 0 || InWell)
            {
                if (InWell)
                {
                    Console.WriteLine($"Player {Id} is stuck in the well");
                }
                else
                {
                    Console.WriteLine($"Player {Id} is skipping a turn");
                }
                Skipping--;
                return;
            }

            Position += amount;
            ISquare square = gameBoard.GetSquare(Position);

            square.ProcessPlayer(this);
        }
    }
}