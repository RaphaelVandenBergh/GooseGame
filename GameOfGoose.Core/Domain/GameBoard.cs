using GameOfGoose.Core.Factories;
using GameOfGoose.Core.Squares;
using System.Collections.Generic;
using System.Linq;

namespace GameOfGoose.Core.Domain
{
    public class GameBoard
    {
        private static GameBoard _instance;
        private readonly ISquareFactory _squareFactory;

        public static GameBoard GetInstance()
        {
            //SINGLETON PATERN
            if (_instance == null)
            {
                _instance = new GameBoard();
            }
            return _instance;
        }

        private GameBoard()
        {
            // NOT IDEAL

            _squareFactory = new SquareFactory();
            Squares = new List<ISquare>();

            CreateSquares();
        }

        public IList<ISquare> Squares { get; set; }

        public ISquare GetSquare(int position)
        {
            return Squares.FirstOrDefault(s => s.Position == position);
        }

        private void CreateSquares()
        {
            for (int i = 1; i < 75; i++)
            {
                //TODO special cases
                switch (i)
                {
                    case 1:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Start));
                        break;

                    case 5:
                    case 9:
                    case 14:
                    case 18:
                    case 23:
                    case 27:
                    case 32:
                    case 36:
                    case 41:
                    case 45:
                    case 50:
                    case 54:
                    case 59:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Goose));
                        break;

                    case 6:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Bridge));
                        break;

                    case 19:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Inn));
                        break;

                    case 31:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Well));
                        break;
                    case 42:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Maze));
                        break;

                    case 52:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Prison));
                        break;

                    case 58:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Death));
                        break;

                    case 63:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Finish));
                        break;

                    case > 63:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Overshoot));
                        break;

                    default:
                        Squares.Add(_squareFactory.CreateSquare(i, SquareType.Normal));
                        break;
                }
            }
        }
    }
}