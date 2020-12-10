using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    class Deck
    {
        public Card[] deck;
        private int currentCard;
        private const int NUM_OF_CARDS = 52;
        private Random ranNum;

        public Deck()
        {
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            deck = new Card[NUM_OF_CARDS];
            currentCard = 0;
            ranNum = new Random();
            for(int count = 0; count<deck.Length; count++)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }

        public void ShuffleAll(Card[] deckVal)
        {
            for(int first = 0; first<deck.Length; first++)
            {
                int second = ranNum.Next(NUM_OF_CARDS);
                Card temp = deckVal[first];
                deckVal[first] = deckVal[second];
                deckVal[second] = temp;
            }
        }

        public void ShuffleInitial()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = ranNum.Next(NUM_OF_CARDS);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public void Shuffle(int topCard, Card[] deckVal)
        {
            for (int first = topCard; first < deck.Length; first++)
            {
                int second = ranNum.Next(topCard+1, NUM_OF_CARDS);
                Card temp = deckVal[first];
                deckVal[first] = deckVal[second];
                deckVal[second] = temp;
            }
        }

        public Card DealCards()//for dealing all the cards
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }

        public Card DealCard(int topCard)//for dealing one card at a time
        {
            if (topCard < deck.Length)
                return deck[topCard];
            else
                return null;
        }
    }
}
