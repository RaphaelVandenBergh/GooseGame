using GameOfGoose.Core.Squares;

namespace GameOfGoose.Core.Factories
{
    public interface ISquareFactory
    {
        ISquare CreateSquare(int position, SquareType type);
    }
}