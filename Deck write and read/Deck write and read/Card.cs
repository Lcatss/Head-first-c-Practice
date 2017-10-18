using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    class Card
    {
        public Card(Suits suit, Values value)
        {
            this.Suit=suit;
            this.Value=value;
        }

        public Suits Suit;
        public Values Value;

        public string Name
        {
            get
            {
                string suitSymbol, valueSymbol;
                switch (Suit)
                {
                    case Suits.Clubs:
                        suitSymbol = "♣";
                        break;
                    case Suits.Diamonds:
                        suitSymbol = "♦";
                        break;
                    case Suits.Hearts:
                        suitSymbol = "♥";
                        break;
                    case Suits.Spades:
                        suitSymbol = "♠";
                        break;
                    default:
                        suitSymbol = "";
                        break;
                }
                switch (Value)
                {
                    case Values.Ace:
                        valueSymbol = "A";
                        break;
                    case Values.Jack:
                        valueSymbol = "J";
                        break;
                    case Values.Queen:
                        valueSymbol = "Q";
                        break;
                    case Values.King:
                        valueSymbol = "K";
                        break;
                    default:
                        valueSymbol = ((int)Value).ToString();
                        break;
                }
                return suitSymbol + valueSymbol;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
                return true;
            else
                return false;
        }
    }
}
