using CardGamesLib.Core.Cards;

namespace CardGamesLib.Core.Players
{
    public class Player
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        private int? Chips { get; set; }
        private List<Card>? Cards { get; set; }

        /// <summary>Initializes a new instance of the <see cref="Player" /> class.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="chips">The chips.</param>
        public Player(Guid id, string name, int chips)
        {
            this.Id = id;
            this.Name = name;
            this.Chips = chips;
        }

        /// <summary>Initializes a new instance of the <see cref="Player" /> class.</summary>
        /// <param name="name">The name.</param>
        /// <param name="chips">The chips.</param>
        public Player(string name, int chips)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Chips = chips;
        }

        /// <summary>Gets the name.</summary>
        /// <returns>Player's Name</returns>
        public string GetName() => this.Name;

        /// <summary>Gets the chips.</summary>
        /// <returns>The Player's Chip Count.</returns>
        public int GetChips()
        {
            if (this.Chips == null) return 0;
            return this.Chips.Value;
        }

        /// <summary>Sets the name.</summary>
        /// <param name="name">The name to set the player to.</param>
        public void SetName(string name)
        {
            this.Name = name;
        }

        /// <summary>Adds the chips.</summary>
        /// <param name="amount">The amount to add to the chips.</param>
        public void AddChips(int amount)
        {
            if (this.Chips == null)
                this.Chips = 0;

            this.Chips += amount;
        }

        /// <summary>Removes specified ammount of chips.</summary>
        /// <param name="amount">The amount to remove from the chips.</param>
        public void RemoveChips(int amount)
        {
            if (this.Chips == null)
                return;

            this.Chips -= amount;

            if (this.Chips < 0)
                this.Chips = 0;
        }
    }
}
