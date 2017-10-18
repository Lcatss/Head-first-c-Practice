using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards= new List<Card>();
            for (int suit = 0; suit < 4; suit++)
			{
                for (int value = 1; value < 14; value++)
			    {
			        cards.Add(new Card((Suits)suit,(Values)value));
			    }
			}
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count
        {
            get { return cards.Count; }
        }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            int length = Count;
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(Count);
                newCards.Add(cards[index]);
                cards.RemoveAt(index);
            }
            cards = newCards;
        }

        public IEnumerable<string> GetCardNames()
        {
            List<string> CardNames = new List<string>();
            foreach (Card card in cards)
            {
                CardNames.Add(card.Name);

            }
            return CardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardComparerSuitsThenValues());
        }




    }
}
