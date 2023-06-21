using GameOfGoose.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Tests.Processor
{
    public class InnTests
    {
        [Fact]
        public void InnShouldSetSkipping()
        {
            //arrange
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 17;

            //act
            player.Move(2);

            //assert
            Assert.True(player.Skipping>0);

        }
        [Fact]
        public void InnShouldSkipNextTurn()
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 17;

            player.Move(2);

            Assert.Equal(1, player.Skipping);
            Assert.Equal(19, player.Position);

            player.Move(2);

            Assert.Equal(0, player.Skipping);
            Assert.Equal(19, player.Position);

            player.Move(2);

            Assert.Equal(0, player.Skipping);
            Assert.Equal(21, player.Position);
        }
    }
}
