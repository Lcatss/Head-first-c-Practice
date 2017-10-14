using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new List<Card>() );
            textBoxOnForm.Text += name + " has just joined the game." + Environment.NewLine ;
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books=new List<Values>();
            for (int i = 1; i <= 13; i++)
			{
			    Values value=(Values)i;
                int howMany=0;
                for(int card=0;card<cards.Count;card++)
                {
                    if(cards.Peek(card).Value==value)
                        howMany++;
                }
                if(howMany==4)
                {
                    books.Add(value);
                    for(int card=cards.Count-1; card>=0;card--)
                        if(cards.Peek(card).Value==value)
                            cards.Deal(card);
                }
            }
            return books;
			
        }

        public Values GetRandomValue()
        {
            while(true)
            {
                Values value = (Values)random.Next(1, 14);              
                if (cards.ContainsValue(value))
                    return value;              
            }

        }

        public Deck DoYouHaveAny(Values value)
        {

            Deck HasCards = cards.PullOutValues(value);
            textBoxOnForm.Text += name + " has " + HasCards.Count + " " + Card.Plural(value)+Environment.NewLine;
            return HasCards;

        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            Values value = GetRandomValue();
            AskForACard(players, myIndex, stock, value);
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += name + " asks if anyone has a " + value.ToString()+Environment.NewLine;

            Deck askCards=new Deck(new List<Card>());
            int takeCard=0;
            for (int i = 0; i < players.Count; i++)
            {
                if(i!=myIndex)
                {
                    askCards = players[i].DoYouHaveAny(value);
                    takeCard += askCards.Count;
                    while (askCards.Count > 0)
                        cards.Add(askCards.Deal());
                }
            }
            if (takeCard > 0)
                return;
            else
            {
                cards.Add(stock.Deal());
                textBoxOnForm.Text += name + " had to draw from the stock." + Environment.NewLine;
            }
        }

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber){return cards.Peek(cardNumber);}
        public void SortHand() { cards.SortByValue(); }

    }
}
