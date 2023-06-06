using System.Linq;

namespace GameOfGoose.Core.Domain
{
    public class Player
    {
        public int Position { get; set; }
        public int Id { get; set; }
        public bool hasWon { get; set; }
        public int Skipping { get; set; }
        public bool inWell { get; set; }
        public int TurnsInWell { get; set; }

       public Player(int id)
        {
            Position = 0;
            hasWon = false;
            Skipping = 0;
            inWell = false;
            TurnsInWell = 0;
            Id = id;
        }
    }
}