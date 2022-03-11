using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingCards
{
    public class PlayingCardsDeck
    {
        readonly string[] Suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
        readonly string[] Values = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        public Dictionary<int, PlayingCard> Cards { get; set; }

        public PlayingCardsDeck()
        {
            Cards = new Dictionary<int, PlayingCard>();
            int count = 1;
            foreach(var value in Values)
            {
                foreach(var suit in Suits)
                {
                    var newCard = new PlayingCard(suit, value);
                    Cards.Add(count, newCard);
                    count++;
                }
            }
        }

        public void DisplayCards()
        {
            foreach (var card in Cards.Values)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }
        }

        public void PickNRandomCards(int numberOfCardsToPull)
        {
            int count = 1;
            while (Cards.Any() && count <= numberOfCardsToPull)
            {
                var random = new Random();
                var next = Cards.Keys.ToList()[random.Next(Cards.Count)];
                Console.WriteLine($"{Cards[next].Value} of {Cards[next].Suit}");
                Cards.Remove(next);
                count++;
            }
        }
    }   
}
