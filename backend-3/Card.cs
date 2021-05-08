using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
    public enum Suit
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    public class Card
    {
        private int _value;
        private Suit _suit;

        public Card(int value, Suit suit)
        {
            _value = value;
            _suit = suit;
        }

        public virtual int value()
        {
            return _value;
        }
    }
}
