using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CardComparer_byValue:IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value < y.Value)
                return -1;
            if (x.Value > y.Value)
                return 1;
            return 0;
        }
    }
}
