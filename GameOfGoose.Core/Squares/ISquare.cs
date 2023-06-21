using GameOfGoose.Core.Domain;

namespace GameOfGoose.Core.Squares
{
    public interface ISquare
    {
        int Position { get; set; }
        SquareType Type { get; set; }
        void ProcessPlayer(Player player);
    }
}
