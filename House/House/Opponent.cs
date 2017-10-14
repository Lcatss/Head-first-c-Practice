using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location startLocation)
        {
            myLocation = startLocation;
            random = new Random();
        }

        public void Move()
        {
            if (myLocation is IHasExteriorDoor)
            {
                if (random.Next(2) == 1)
                {
                    IHasExteriorDoor HasDoor = myLocation as IHasExteriorDoor;
                    myLocation = HasDoor.DoorLocation;
                }
            }
            do
                myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];                
            while (!(myLocation is  IHidingPlace));
        }

        public bool Check(Location guessPlace)
        {
            if(myLocation==guessPlace)
                return true;
            return false;
        }
            
    }
}
