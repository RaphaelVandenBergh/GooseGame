using GameOfGoose.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Tests.Processor
{
    public class DeathTests
    {
        [Fact]
        public void DeathShouldMoveTo0()
        {
            //arrange
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 55;

            //act
            player.Move(3);

            //assert
            Assert.Equal(1, player.Position);
        }
    }
}
