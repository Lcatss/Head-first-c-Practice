using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Duck : Bird,IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;



        public int CompareTo(Duck other)
        {
            if (this.Size > other.Size)
                return 1;
            else if (this.Size < other.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return "A "+Size+" inch "+Kind.ToString();
        }
    }
           

}
