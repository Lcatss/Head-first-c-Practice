using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    abstract class Weapon
    {

        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }

        protected Game game;
        protected Point location;
        public Point Location { get { return location; } }


        public Weapon(Game game, Point location)
            
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }

        public void PickUpWeapon()
        {
            pickedUp = true;
        }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;

            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Mover.Nearby(enemy.Location, target, 30)&&enemy.Alive)
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Mover.Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }
}
