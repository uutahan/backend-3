using System;
using Blackjack;
using Cards;

namespace backend_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackjackCard bj = new BlackjackCard(13, Suit.Diamond);
            Console.WriteLine(bj.value());

            Card card = new Card(13, Suit.Diamond);
            Console.WriteLine(card.value());
        }
    }
}
