using GameOfGoose.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Tests.Processor
{
    public class GooseTileTests
    {
        [Fact]
        public void GooseTileShouldDoubleMove()
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 7;

            player.Move(2);

            Assert.Equal(11, player.Position);
        }

        [Fact]
        public void ConsecutiveGooseTilesShouldDoubleMove()
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 4;

            player.Move(5);

            Assert.Equal(19, player.Position);
        }

        [Fact]
        public void OvershootGooseTileShouldMoveBack()
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 57;

            player.Move(10);

            Assert.Equal(49, player.Position);
        }
    }
}
