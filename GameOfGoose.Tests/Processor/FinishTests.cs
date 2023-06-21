using GameOfGoose.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Tests.Processor
{
    public class FinishTests
    {
        [Fact]
        public void FinishShouldSetPlayerToHasWon()
        {
            //arrange
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 60;

            //act
            player.Move(3);

            //assert
            Assert.True(player.HasWon);
        }
    }
}
