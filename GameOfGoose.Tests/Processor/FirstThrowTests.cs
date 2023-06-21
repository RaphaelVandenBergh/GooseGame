using GameOfGoose.Core.Domain;

namespace GameOfGoose.Tests.Processor
{
    public class FirstThrowTests
    {
        [Fact]
        public void Throwing9ShouldMoveTo26Or53()
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 1;

            player.Move(9);

            Assert.Contains(player.Position, new int[] { 26, 53 });
        }

        [Fact]
        public void SpecialThrowShouldWorkAfterDeath()
        {
            GameBoard gameBoard = GameBoard.GetInstance();
            Player player = new Player(1);
            player.Position = 55;
            player.Move(3);

            Assert.Equal(1, player.Position);

            player.Move(9);

            Assert.Contains(player.Position, new int[] { 26, 53 });
        }
    }
}