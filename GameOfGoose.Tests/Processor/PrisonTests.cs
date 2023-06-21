using GameOfGoose.Core.Domain;

namespace GameOfGoose.Tests.Processor
{
    public class PrisonTests
    {
        [Fact]
        public void PrisonShouldSetSkippingTo3()
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 49;

            player.Move(3);

            Assert.Equal(3, player.Skipping);
        }

        [Fact]
        public void PrisonShouldSkip3Turns()
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 49;

            player.Move(3);

            Assert.Equal(3, player.Skipping);
            Assert.Equal(52, player.Position);

            player.Move(3);

            Assert.Equal(2, player.Skipping);
            Assert.Equal(52, player.Position);

            player.Move(3);

            Assert.Equal(1, player.Skipping);
            Assert.Equal(52, player.Position);

            player.Move(3);

            Assert.Equal(0, player.Skipping);
            Assert.Equal(52, player.Position);

            player.Move(3);

            Assert.Equal(0, player.Skipping);
            Assert.Equal(55, player.Position);
        }
    }
}