using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack4K
{
    internal class Deck
    {
        private List<Card> cards = new List<Card>();
        public Deck() 
        {
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] colors = { "H", "D", "C", "S" };
            foreach (string value in values)
            {
                foreach (string color in colors)
                {
                    cards.Add(new Card(value, color));
                }
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int j = random.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
        public Card Draw()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}
