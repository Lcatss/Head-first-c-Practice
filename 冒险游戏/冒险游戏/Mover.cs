using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;
        protected int maxHitPoints;
        public int MaxHitPoints { get { return maxHitPoints; } }
        protected int hitPoints;
        public int HitPoints { get { return hitPoints; } }
        public bool Alive
        {
            get { return (hitPoints > 0); }
        }

        public Mover(Game game, Point location,int hitPoints)
        {
            this.game = game;
            this.location = location;
            this.hitPoints = hitPoints;
            this.maxHitPoints = hitPoints;


        }

        

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage + 1);
            if (hitPoints < 0)
                hitPoints = 0;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && (Math.Abs(Location.Y - locationToCheck.Y) < distance))
                return true;
            else
                return false;
        }

        public static bool Nearby(Point location1, Point location2, int distance)
        {
            if (Math.Abs(location2.X - location1.X) < distance && (Math.Abs(location2.Y - location1.Y) < distance))
                return true;
            else
                return false;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;
            }
            return newLocation;
        }

        public static Point Move(Direction direction,Point currentLocation,Rectangle boundaries)
        {
            Point newLocation = currentLocation;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;
            }
            return newLocation;
        }
    }
}
