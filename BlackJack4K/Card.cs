using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack4K
{
    internal class Card
    {
        //wartość karty (2,3,4,J,Q,K,A)
        string value;
        //kolor karty (H = kier, D = karo, C = trefl, S = pik)
        string color;

        //konstruktor karty
        public Card(string value, string color)
        {
            this.value = value;
            this.color = color;
        }

        //metoda zwracająca wartość karty jako int (punkty)
        public int GetValue()
        {
            int result;
            if(int.TryParse(value, out result))
                return result;
            switch(value)
            {
                case "J":
                case "Q":
                case "K":
                    return 10;
                case "A":
                    return 11;
                default:
                    return 0;
            }
        }

        //metoda zwracajaca url obrazka utworzone z wartosci i koloru karty
        public string GetCardImageURL()
        {
            return value + color + ".png";
        }
    }
}
