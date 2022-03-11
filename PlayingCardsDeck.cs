using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingCards
{
    public class PlayingCardsDeck
    {
        readonly string[] Suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };// Jokers are not considered
        readonly string[] Values = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        public Dictionary<int, PlayingCard> Cards { get; set; }//Key: Card number from 1 to 52, Value: Playing Card information, ex: 2 of Clubs

        /// <summary>
        /// Constructor to populate all the required cards in a Playing cards deck. PlayingCardsDeck class initiation will give the deck of all the cards.
        /// </summary>
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

        /// <summary>
        /// Display all the cards from the deck
        /// </summary>
        public void DisplayCards()
        {
            foreach (var card in Cards.Values)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }
        }

        /// <summary>
        /// Function to pull the N number of random cards from the Playing cards deck. Each pull will reduce the deck size by 1. 
        /// </summary>
        /// <param name="numberOfCardsToPull">Number of cards to pull as per the user's choice. Works only for the positive intergers. 
        /// Any value greater than 52 would pull all the cards from the deck and returns</param>
        public void PickNRandomCards(int numberOfCardsToPull)
        {
            if(numberOfCardsToPull < 1)
            {
                Console.WriteLine("Invalid Input: Only numbers from 1 to 52 are valid to pull the cards the playing cards deck.");
                return;
            }            
            int count = 1;
            while (Cards.Any() && count <= numberOfCardsToPull)
            {
                var random = new Random();
                var next = Cards.Keys.ToList()[random.Next(Cards.Count)];
                Console.WriteLine($"{Cards[next].Value} of {Cards[next].Suit}");
                Cards.Remove(next);
                count++;
            }

            if (numberOfCardsToPull > 52)
            {
                Console.WriteLine("Warning: Playing card deck will have only 52 maximum cards, but user choosed to pull more than 52 cards. Displayed all the available 52 cards.");
                return;
            }
        }
    }   
}
