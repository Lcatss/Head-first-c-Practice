using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> cards=new List<Card>();
            for (int i = 0; i < 5; i++)
			{
			    cards.Add(new Card((Suits)random.Next(4),(Values)random.Next(1,14)));
			}

            foreach (Card card in cards)
                Console.WriteLine(card);
            Console.WriteLine();

            CardComparer_byValue cardComparer = new CardComparer_byValue();
            cards.Sort(cardComparer);

            foreach (Card card in cards)
                Console.WriteLine(card);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
