using GameOfGoose.Core.Domain;
using GameOfGoose.Core.Processor;

namespace GameOfGoose.Tests.Processor
{
    public class GooseProcessorTests
    {
        //private readonly TurnProcessor _turnProcessor;

        //public GooseProcessorTests()
        //{
        //    _turnProcessor = new TurnProcessor();
        //}

        //[Fact]
        //public void PlayerShouldWinOnPosition63()
        //{
        //    // Arrange
        //    var game = new Game(1);


        //    // Act
        //    game.Players[0].Position = 60;
        //    _turnProcessor.CheckForWin(game.Players[0]);
        //    Assert.False(game.Players[0].HasWon);

        //    // Assert



        //    game.Players[0].Position = 63;
        //    _turnProcessor.CheckForWin(game.Players[0]);
        //    Assert.True(game.Players[0].HasWon);


        //}

        //[Fact]
        //public void PlayerShouldNotWinOnOvershoot()
        //{
        //    // Arrange
        //    var game = new Game(1);


        //    // Act
        //    game.Players[0].Position = 60;
        //    _turnProcessor.move(game.Players[0], 2, 2);
        //    _turnProcessor.CheckForWin(game.Players[0]);

        //    // Assert


        //    Assert.False(game.Players[0].HasWon);
        //}

        //[Fact]
        //public void PlayersShouldMoveBackOnOvershoot()
        //{
        //    var game = new Game(1);
        //    game.Players[0].Position = 60;
        //    _turnProcessor.move(game.Players[0], 2, 3);

        //    Assert.Equal(61, game.Players[0].Position);
        //}

        //[Fact]
        //public void PlayersShouldMove()
        //{
        //    var game = new Game(1);
        //    _turnProcessor.PlayTurn(game);

        //    Assert.True(game.Players[0].Position > 0);
        //}

        //[Theory]
        //[InlineData(6, 3, 53)]
        //[InlineData(3, 6, 53)]
        //[InlineData(4, 5, 26)]
        //[InlineData(5, 4, 26)]
        //[InlineData(3, 1, 4)]
        //public void FirstThrowExeptionsShouldWork(int dice1, int dice2, int expected)
        //{
        //    var game = new Game(1);
        //    game.Players[0].Position = 0;
        //    _turnProcessor.move(game.Players[0], dice1, dice2);

        //    Assert.Equal(expected, game.Players[0].Position);
        //}

        //[Theory]
        //[InlineData(1, 1, 3, 7)]
        //[InlineData(2, 2, 10, 22)]
        //public void GooseTileShouldMultiply(int die1, int die2, int position, int expected)
        //{
        //    var game = new Game(1);
        //    game.Players[0].Position = position;
        //    _turnProcessor.move(game.Players[0], die1, die2);
        //    _turnProcessor.GooseTileMultiplier(game.Players[0], die1 + die2, false);

        //    Assert.Equal(expected, game.Players[0].Position);
        //}

        //[Theory]
        //[InlineData(5, 5, 57, 49)]
        //public void GooseTileShouldWorkBackwards(int die1, int die2, int position, int expected)
        //{
        //    var game = new Game(1);
        //    game.Players[0].Position = position;
        //    _turnProcessor.move(game.Players[0], die1, die2);
        //    _turnProcessor.GooseTileMultiplier(game.Players[0], die1 + die2, false);

        //    Assert.Equal(expected, game.Players[0].Position);
        //}

        //[Fact]
        //public void BridgeTileShouldMoveTo12()
        //{
        //    var game = new Game(1);
        //    _turnProcessor.move(game.Players[0], 3, 3);
        //    _turnProcessor.Bridge(game.Players[0]);
        //}

        //[Fact]
        //public void InnShouldSkipTurn()
        //{
        //    var game = new Game(1);
        //    game.Players[0].Position = 17;
        //    _turnProcessor.move(game.Players[0], 1, 1);
        //    _turnProcessor.Inn(game.Players[0]);

        //    Assert.Equal(1, game.Players[0].Skipping);

        //    _turnProcessor.PlayTurn(game);

        //    Assert.Equal(19, game.Players[0].Position);
        //    Assert.Equal(0, game.Players[0].Skipping);

        //    _turnProcessor.PlayTurn(game);

        //    Assert.NotEqual(19, game.Players[0].Position);

        //}

        //[Fact]
        //public void PrisonShouldSkip3Turns()
        //{
        //    var game = new Game(1);
        //    game.Players[0].Position = 49;
        //    _turnProcessor.move(game.Players[0], 1, 2);
        //    _turnProcessor.Prison(game.Players[0]);

        //    Assert.Equal(3, game.Players[0].Skipping);

        //    _turnProcessor.PlayTurn(game);

        //    Assert.Equal(52, game.Players[0].Position);
        //    Assert.Equal(2, game.Players[0].Skipping);

        //    _turnProcessor.PlayTurn(game);

        //    Assert.Equal(52, game.Players[0].Position);
        //    Assert.Equal(1, game.Players[0].Skipping);

        //    _turnProcessor.PlayTurn(game);

        //    Assert.Equal(52, game.Players[0].Position);
        //    Assert.Equal(0, game.Players[0].Skipping);

        //    _turnProcessor.PlayTurn(game);

        //    Assert.NotEqual(52, game.Players[0].Position);
        //}

        //[Fact]
        //public void MazeShouldMoveTo39()
        //{
        //    var game = new Game(1);
        //    game.Players[0].Position = 40;
        //    _turnProcessor.move(game.Players[0], 1, 1);
        //    _turnProcessor.Maze(game.Players[0]);

        //    Assert.Equal(39, game.Players[0].Position);
        //}

        //[Fact]
        //public void DeathShouldMoveToStart()
        //{
        //    var game = new Game(1);
        //    game.Players[0].Position = 56;
        //    _turnProcessor.move(game.Players[0], 1, 1);
        //    _turnProcessor.Death(game.Players[0]);

        //    Assert.Equal(0, game.Players[0].Position);
        //}

        //[Fact]
        //public void WellShouldKeepStillUntilSecondPlayer()
        //{
        //    var game = new Game(2);
        //    game.Players[0].Position = 29;
            
        //    _turnProcessor.move(game.Players[0], 1, 1);
        //    _turnProcessor.Well(game.Players[0]);

            

        //    Assert.True(game.Players[0].InWell);

        //    _turnProcessor.PlayTurn(game);

        //    Assert.Equal(31, game.Players[0].Position);
        //    Assert.Equal(1, game.Players[0].TurnsInWell);

        //    game.Players[1].Position = 29;
        //    _turnProcessor.move(game.Players[1], 1, 1);
        //    _turnProcessor.Well(game.Players[1]);
        //    _turnProcessor.WellRelease(game);

        //    Assert.True(game.Players[1].InWell);

        //    _turnProcessor.PlayTurn(game);

        //    Assert.Equal(31, game.Players[1].Position);
        //    Assert.Equal(1, game.Players[1].TurnsInWell);
        //    Assert.True(game.Players[1].InWell);
        //    Assert.Equal(0, game.Players[0].TurnsInWell);
        //    Assert.False(game.Players[0].InWell);
        //    Assert.NotEqual(31, game.Players[0].Position);


        //}

        //[Fact]
        //public void GooseShouldntAllowOvershoot()
        //{
        //    var game = new Game(1);
        //    game.Players[0].Position = 51;
        //    _turnProcessor.move(game.Players[0], 3, 5);
        //    _turnProcessor.GooseTileMultiplier(game.Players[0], 8, true);
        //    Assert.Equal(51, game.Players[0].Position);

        //}

    }
}
