namespace PlayingCards
{
    public class PlayingCard
    {
        public string Suit { get; set; }
        public string Value { get; set; }

        public PlayingCard(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
