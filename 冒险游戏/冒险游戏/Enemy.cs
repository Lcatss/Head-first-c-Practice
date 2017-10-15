using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class Enemy:Mover
    {
        private const int NearPlayerDistance = 25;


        public Enemy(Game game, Point location, int hitPoints)
            : base(game, location,hitPoints)
        { }
        

        public abstract void Move(Random random);

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;
        }


    }
}
