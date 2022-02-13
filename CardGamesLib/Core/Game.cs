using CardGamesLib.Core.Players;
using CardGamesLib.Core.Cards;

namespace CardGamesLib.Core
{
    public enum GameType
    {
        BlackJack,
        //Poker
    }

    public class Game
    {

        public List<Player> Players { get; set; }
        public Guid GameId { get; init; }
        public GameType GameType { get; set; }
        public List<CardDeck> Decks { get; set; } = new();

        /// <summary>Initializes a new instance of the <see cref="Game" /> class.</summary>
        /// <param name="players">The List Object to be added to the game.</param>
        /// <param name="deckCount">The number of decks that should be included in the game.</param>
        public Game(List<Player> players, int deckCount, GameType gameType)
        {
            this.Players = players;

            for (int i = 0; i < deckCount; i++)
            {
                var newDeck = new CardDeck();
                this.Decks.Add(newDeck);
            }

            SetGameType(gameType);

            int deckNumber = 0;
            foreach (var deck in this.Decks)
            {
                Console.WriteLine($"Deck {deckNumber}:");
                int cardsInDeck = 0;
                deck.Shuffle();
                foreach (var card in deck.Cards)
                {
                    cardsInDeck++;
                    Console.WriteLine($"Card {cardsInDeck}: {card.Rank} of {card.Suit}");
                }
                deckNumber++;
                Console.WriteLine();
            }

            foreach (var player in this.Players)
            {
                Console.WriteLine($"{player.GetName()} - Chips: {player.GetChips()}");
            }

            Console.WriteLine($"Game Type: {GetGameType()}");
        }

        /// <summary>Sets the type of the game.</summary>
        /// <param name="game">The game type.</param>
        public void SetGameType(GameType game) => this.GameType = game;

        /// <summary>Gets the type of the game.</summary>
        /// <returns>The current game type.</returns>
        public GameType GetGameType() => this.GameType;


    }
}
