using GameOfGoose.Core.Domain;
using GameOfGoose.Core.Processor;

var game = new Game(4);
var turnProcessor = new TurnProcessor();
turnProcessor.Playing(game);