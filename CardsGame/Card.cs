using System;
using System.Collections.Generic;
using System.Text;

namespace CardsGame
{
    public class Card
    {
        private string face;//represents the face values of the cards - out of 13 available
        private string suit;//represents the suit of the card - out of 4 available

        public Card(string cardFace, string cardSuit)//constructor
        {
            face = cardFace;
            suit = cardSuit;
        }

        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}
