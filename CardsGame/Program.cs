using System;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueGame = true;
            Deck deck1 = new Deck();
            int topOfDeck = 0;
            while (continueGame)
            {
                Console.WriteLine("Choose one of the options from below:");
                Console.WriteLine("1. Play a card");
                Console.WriteLine("2. Shuffle the deck");
                Console.WriteLine("3. Restart the game");
                Console.WriteLine("4. Exit the game");
                string inVal = Console.ReadLine();

                switch (inVal)
                {
                    case "1":
                        if(topOfDeck==0)
                            deck1.ShuffleAll(deck1.deck);
                        if (deck1.deck.Length > topOfDeck)
                        {
                            Console.WriteLine(deck1.DealCard(topOfDeck));
                            topOfDeck++;
                        }
                        else
                        {
                            Console.WriteLine("There are no more cards available in the deck. Please restart the game.");
                        }
                        break;

                    case "2":
                        if (deck1.deck.Length > topOfDeck)
                            deck1.Shuffle(topOfDeck,deck1.deck);
                        else
                            Console.WriteLine("There are no more cards available in the deck. Please restart the game.");
                        break;

                    case "3":
                        topOfDeck = 0;
                        deck1.ShuffleAll(deck1.deck);
                        break;

                    case "4":
                        continueGame = false;
                        Console.WriteLine("Exit Sucessfull");
                        break;

                    default:
                        Console.WriteLine("Invalid value. Please enter a valid input.");
                        break;
                }
            }

            //to print all cards in the deck
            //for(int i=0; i<52; i++)
            //{
            //    Console.Write("{0,-19}", deck1.DealCards());
            //    if ((i + 1) % 4 == 0)
            //        Console.WriteLine();
            //}
            Console.ReadLine();
        }
    }
}
