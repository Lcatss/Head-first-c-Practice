using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class CardComparerSortByValues:IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {

            if (x.Value < y.Value)
                return -1;
            else if (x.Value > y.Value)
                return 1;
            else
                return 0;

        }
    }
}
