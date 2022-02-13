namespace CardGamesLib.Core.Cards
{
    public class CardDeck
    {
        public List<Card> Cards { get; internal set; } = new List<Card>();

        /// <summary>Initializes a new instance of the <see cref="CardDeck" /> class.</summary>
        public CardDeck()
        {
            foreach (var suit in Enum.GetValues<Suit>())
            {
                foreach (var rank in Enum.GetValues<Rank>())
                {
                    Card newCard = new(suit, rank);
                    this.Cards.Add(newCard);
                }
            }
        }

        /// <summary>Shuffles this deck instance.</summary>
        public void Shuffle()
        {
            this.Cards = Algorithms<Card>.Shuffle(this.Cards);
        }
    }
}
