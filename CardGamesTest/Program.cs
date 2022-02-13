using CardGamesLib.Core;
using CardGamesLib.Core.Players;

namespace CardGamesTest
{
    class Application
    {
        public static void Main()
        {
            var players = new List<Player>();

            var newPlayer = new Player("steve", 100);
            players.Add(newPlayer);

            newPlayer = new Player("Jess", 150);
            players.Add(newPlayer);

            newPlayer = new Player("Henry", 90);
            players.Add(newPlayer);

            var cardGame = new Game(players, 5, GameType.BlackJack);
        }
    }
}