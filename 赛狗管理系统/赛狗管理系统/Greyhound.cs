using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class Greyhound
    {
        public int startingPosition;
        public int racetrackLength;
        public PictureBox myPicturebox=null;
        public int location = 0;
        public Random randomizer;

        public bool run()//随机移动1-4格
        {
            int distance = randomizer.Next(1, 5);
            Point p = myPicturebox.Location;
            p.X += distance;
            myPicturebox.Location = p;
            if (myPicturebox.Location.X - startingPosition >= racetrackLength)
                return true;
            else
                return false;
        }

        public void takingStartingPosition()//重置位置到起点
        {
            Point p = myPicturebox.Location;
            p.X = startingPosition;
            myPicturebox.Location = p;
        }


    }
}
