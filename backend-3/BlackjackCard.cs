using System;
using System.Collections.Generic;
using System.Text;
using Cards;

namespace Blackjack
{
    public class BlackjackCard : Card
    {
        public BlackjackCard(int _value, Suit _suit) : base(value: _value, suit: _suit)
        {
           
        }

        public override int value()
        {
            int v = base.value();
            if (v == 1)
                return 11;
            if (v < 10)
                return v;
            return 10;
        }
    }
}
