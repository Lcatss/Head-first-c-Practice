using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Fool:Person//傻子，随机选择合作或者欺骗
    {
        public Fool(Random random)
            : base(random)
        { }


        public override bool Decide()
        {
            if (random.Next(2) == 0)
                return true;
            return false;
        }
        
    }
}
