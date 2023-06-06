using GameOfGoose.Core.Domain;
using System;
using System.Linq;

namespace GameOfGoose.Core.Processor
{
    public class TurnProcessor
    {
        private readonly Random random = new Random();

        public void Playing(Game game)
        {
            
            while (!game.Players.Exists(p => p.hasWon == true))
            {
                PlayTurn(game);
                
            }
        }

        public void PlayTurn(Game Game)
        {
            foreach (var Player in Game.Players)
            {
                if (Player.inWell == true)
                {
                    Player.TurnsInWell++;
                    Console.WriteLine($"Player {Player.Id} is still stuck in the well");
                }
                else if (Player.Skipping > 0)
                {
                    Player.Skipping--;
                    Console.WriteLine($"Player {Player.Id} is still skipping their turn");
                }
                else
                {
                    if (Player.TurnsInWell > 0)
                    {
                        Player.TurnsInWell = 0;
                    }
                    int dice1 = random.Next(1, 7);
                    int dice2 = random.Next(1, 7);

                    move(Player, dice1, dice2);
                    GooseTileMultiplier(Player, dice1 + dice2, false);
                    if (Player.Position > (int)Positions.Finish)
                    {
                        Player.Position = (int)Positions.Finish - (Player.Position - (int)Positions.Finish);
                        Console.WriteLine($"Player {Player.Id} rolled a {dice1} and a {dice2} they overshot and moved back to {Player.Position}");
                        GooseTileMultiplier(Player, dice1 + dice2, true);
                    }

                    CheckForWin(Player);
                    CheckForSpecial(Player);
                }

            }

            WellRelease(Game);
        }



        public void move(Player Player, int dice1, int dice2)
        {
            if (dice1 + dice2 == 9 && Player.Position == 0)
            {
                switch (dice1)
                {
                    case 5:
                    case 4:
                        Player.Position = 26;
                        Console.WriteLine($"Player {Player.Id} rolled a {dice1} and a {dice2} on their first turn so they moved to {Player.Position}");
                        break;
                    case 3:
                    case 6:
                        Player.Position = 53;
                        Console.WriteLine($"Player {Player.Id} rolled a {dice1} and a {dice2} on their first turn so they moved to {Player.Position}");
                        break;

                }
                return;
            }
            Player.Position += dice1 + dice2;
            if (Player.Position < (int)Positions.Finish) 
            {
                Console.WriteLine($"Player {Player.Id} rolled a {dice1} and a {dice2} they move to {Player.Position}");
            }
            if (Player.Position > (int)Positions.Finish)
            {
                Player.Position = (int)Positions.Finish - (Player.Position - (int)Positions.Finish);
                Console.WriteLine($"Player {Player.Id} rolled a {dice1} and a {dice2} they overshot and moved back to {Player.Position}");
                GooseTileMultiplier(Player, dice1 + dice2, true);
            }
        }

        public void CheckForSpecial(Player Player)
        {
            Death(Player);
            Bridge(Player);
            Maze(Player);
            Well(Player);
            Inn(Player);
            Prison(Player);
        }

        public void CheckForWin(Player Player)
        {
            if (Player.Position == (int)Positions.Finish)
            {
                Console.WriteLine("Player " + Player.Id + " has won!");
                Player.hasWon = true;

            }
        }



        public void Death(Player Player)
        {

            if (Player.Position == (int)Positions.Death)
            {

                Player.Position = (int)Positions.Start;
                Console.WriteLine($"Player {Player.Id} has died, better luck next time");
            }

        }

        public void Bridge(Player Player)
        {

            if (Player.Position == (int)Positions.BridgeStart)
            {
                Player.Position = (int)Positions.BridgeEnd;
                Console.WriteLine($"Player {Player.Id} has crossed the bridge they move to {Player.Position}");
            }

        }

        public void Maze(Player Player)
        {

            if (Player.Position == (int)Positions.MazeStart)
            {
                Player.Position = (int)Positions.MazeEnd;
                Console.WriteLine($"Player {Player.Id} has entered the maze they move to {Player.Position}");
            }

        }

        public void Well(Player Player)
        {

            if (Player.Position == (int)Positions.Well)
            {
                Player.inWell = true;
                Console.WriteLine($"Player {Player.Id} has fallen into a well they need to wait for someone tho help them out");
            }

        }

        public void WellRelease(Game Game)
        {
            int PlayersInWell = Game.Players.Where(x => x.inWell == true).Count();
            if (PlayersInWell >= 2)
            {
                var highest = Game.Players.MaxBy(x => x.TurnsInWell);
                highest.inWell = false;
                Console.WriteLine($"Player {highest.Id} has been helped out of the well");
            }

        }

        public void Inn(Player Player)
        {

            if (Player.Position == (int)Positions.Inn)
            {
                Player.Skipping = 1;
                Console.WriteLine($"Player {Player.Id} has stopped at the inn for a drink");
            }

        }

        public void Prison(Player Player)
        {

            if (Player.Position == (int)Positions.Prison)
            {
                Player.Skipping = 3;
                Console.WriteLine($"Player {Player.Id} has been sent to prison");
            }

        }
        public void GooseTileMultiplier(Player Player, int SpacesMoved, bool backwards)
        {
            while (new[] { 5, 9, 14, 18, 23, 27, 32, 36, 41, 45, 50, 54, 59 }.Contains(Player.Position))
            {
                if (backwards)
                {
                    Player.Position -= SpacesMoved;
                    Console.WriteLine($"Player {Player.Id} landed on a goose on his way back and moves to {Player.Position}");
                }
                else
                {
                    Player.Position += SpacesMoved;
                    Console.WriteLine($"Player {Player.Id} landed on a goose and moves to {Player.Position}");
                }
            }

        }
    }
}
