
using GameOfGoose.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Tests.Processor
{
    public class OverShootTests
    {
        [Fact]
        public void OverShootShouldMoveBackwards()
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 60;

            player.Move(5);

            Assert.Equal(61, player.Position);
        }
    }
}
