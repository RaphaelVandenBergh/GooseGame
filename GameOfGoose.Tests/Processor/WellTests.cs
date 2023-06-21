using GameOfGoose.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfGoose.Tests.Processor
{
    public class WellTests
    {
        [Fact]  
        public void WellShouldKeepSkipping()
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 28;

            player.Move(3);

            Assert.Equal(31, player.Position);
            Assert.True(player.InWell);

            player.Move(3);

            Assert.Equal(31, player.Position);
            Assert.True(player.InWell);
        }

        [Fact] 
        public void SecondPlayerInWellShouldFreeFirst() 
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player1 = new Player(1);
            Player player2 = new Player(2);
            player1.Position = 28;
            player2.Position = 24;

            player1.Move(3);

            Assert.Equal(31, player1.Position);
            Assert.True(player1.InWell);

            player2.Move(2);

            Assert.Equal(26, player2.Position);
            Assert.True(player1.InWell);
            Assert.False(player2.InWell);

            player2.Move(5);
            Assert.Equal(31, player2.Position);
            Assert.False(player1.InWell);
            Assert.True(player2.InWell);

            player1.Move(3);
            Assert.Equal(34, player1.Position);
        }


    }
}
