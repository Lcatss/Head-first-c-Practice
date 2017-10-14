using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    class OutsideWithHidingPlace:Outside,IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName)
            : base(name, hot)
        {
            this.hidingPlaceName = hidingPlaceName;
        }

        private string hidingPlaceName;
        public string HidingPlaceName
        {
            get { return hidingPlaceName; }
        }
    }
}
