# PlayingCards
Take home assignment - Create a deck of playing cards and pulling the cards randomly.
Summary of the problem: 
1.	Create a deck of cards(collection) in sorted order (52 cards, excluding the jokers)
2.	Pull as many cards as required from the Deck as long as the Deck is not empty – Every pull will reduce the deck size by 1. User will choose the number of cards to pull randomly. 
a.	For example, if user chooses any number less than 52, let’s say 5, then the program will pull 5 random cards and display.
b.	If the user chooses a number more than 52, then the program will pull all the cards in random order until the deck is empty and display.
3.	I have the DisplayCards method to display the sorted deck of cards from step 1, but I am not calling it anywhere. In case if we want to display the deck, then we can call the DisplayCards method.
4.	Assumption: I am not handling any cases where user enter negative values, zero etc...
