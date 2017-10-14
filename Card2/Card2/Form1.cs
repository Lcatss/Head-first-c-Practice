using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Deck deck1, deck2;
        Random random=new Random();

        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            RedrawDeck(1);
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Values.Three);
            MessageBox.Show(doesItMatch.ToString());
        }

        private void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                deck1ListBox.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                {
                    deck1ListBox.Items.Add(cardName);
                }
                deck1Label.Text = "Deck #1 (" + deck1.Count + " cards)";
            }
            else
            {
                deck2ListBox.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                {
                    deck2ListBox.Items.Add(cardName);
                }
                deck2Label.Text = "Deck #2 (" + deck2.Count + " cards)";
            }
        }

        private void ResetDeck(int DeckNumber)
        {
            if(DeckNumber==1)
            {
                List<Card> cards=new List<Card>();
                int number = random.Next(1,11);
                for (int i = 0; i <number; i++)
			    {
			        cards.Add(new Card((Suits)random.Next(4),(Values)random.Next(1,14)));
			    }

                deck1=new Deck(cards);
                deck1.Sort();
            }

            else
            {
                deck2 = new Deck();
                deck2.Sort();
            }
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);

        }

        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int index = deck1ListBox.SelectedIndex;
            if (index >= 0 & index < deck1.Count)
            {
                deck2.Add(deck1.Deal(index));
                RedrawDeck(1);
                RedrawDeck(2);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = deck2ListBox.SelectedIndex;
            if (index >= 0 & index < deck2.Count)
            {
                deck1.Add(deck2.Deal(index));
                RedrawDeck(1);
                RedrawDeck(2);
            }
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }
                
    
    }
		 

}
