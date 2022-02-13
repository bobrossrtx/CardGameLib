namespace CardGamesLib.Core.Cards
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Rank
    {
        Ace,    Two,   Three,  Four,
        Five,   Six,   Seven,  Eight,
        Nine,   Ten,   Jack,   Queen,
        King
    }

    public class Card
    {
        public Rank Rank { get; init; }
        public Suit Suit { get; init; }
        public bool InUse { get; private set; }

        /// <summary>Initializes a new instance of the <see cref="Card" /> class.</summary>
        /// <param name="suit">The card suit.</param>
        /// <param name="rank">The card rank.</param>
        public Card(Suit suit, Rank rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        /// <summary>Sets the card to Used state.</summary>
        public void SetUsed()
        {
            this.InUse = true;
        }

        /// <summary>Sets the card to Unused state.</summary>
        public void SetUnused()
        {
            this.InUse = false;
        }
    }
}
