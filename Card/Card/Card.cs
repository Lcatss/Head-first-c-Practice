using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
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
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
