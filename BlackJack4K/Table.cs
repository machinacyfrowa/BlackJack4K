using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack4K
{
    internal class Table
    {
        public Hand[] hands = new Hand[4];
        private Deck deck = new Deck();

        public void NewGame()
        {
            deck = new Deck();
            deck.Shuffle();
            for (int i = 0; i < hands.Length; i++)
            {
                hands[i] = new Hand();
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (Hand hand in hands)
                {
                    hand.AddCard(deck.Draw());
                }
            }
        }
    }

}
