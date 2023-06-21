using GameOfGoose.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Tests.Processor
{
    public class BridgeTests
    {
        [Fact]
        public void BridgeShouldMoveTo12()
        {
            //arrange
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 4;

            //act
            player.Move(2);

            //assert
            Assert.Equal(12, player.Position);
        }
    }
}
