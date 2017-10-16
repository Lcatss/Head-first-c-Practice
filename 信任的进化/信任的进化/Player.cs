using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Player:Person
    {
        public Player(Random random)
            : base(random)
        { }

        private bool order;
        public void GetOrder(bool order)
        { this.order = order; }

        public override bool Decide()
        {
            return order;
        }
    }
}
