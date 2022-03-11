using System;

namespace PlayingCards
{
    public class Program
    {
        static void Main(string[] args)
        {
            var playingCardsDeck = new PlayingCardsDeck();
            Console.WriteLine("Deck has 52 cards, enter any number to pull that many cards from the Deck");
            var numberOfCardsToPull = int.Parse(Console.ReadLine());
            playingCardsDeck.PickNRandomCards(numberOfCardsToPull);
            Console.ReadLine();
        }
    }
}
