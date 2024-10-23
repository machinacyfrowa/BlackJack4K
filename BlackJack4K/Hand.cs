using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack4K
{
    internal class Hand
    {
        //lista kart w ręce
        List<Card> cards = new List<Card>();

        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        public int CountPoints()
        {
            int points = 0;
            int aces = 0;
            foreach (Card card in cards)
            {
                int value = card.GetValue();
                if (value == 11)
                    aces++;
                points += value;
            }
            while (points > 21 && aces > 0)
            {
                points -= 10;
                aces--;
            }
            return points;
        }
    }

}
