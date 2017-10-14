using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    class RoomWithDoor:RoomWithHidingPlace,IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration,string hidingPlaceName,string doorDescription)
            : base(name, decoration,hidingPlaceName)
        {
            this.doorDescription = doorDescription;
        }
        private string doorDescription;
        public string DoorDescription
        {
            get
            {
                return doorDescription;
            }
        }

        private Location doorLocation;
        public Location DoorLocation
        {
            get
            {
                return doorLocation;
            }
            set
            {
                doorLocation = value;
            }
        }

        public override string Description
        {
            get
            {
                return base.Description+"You see "+doorDescription+".";
            }
        }
    }
}
