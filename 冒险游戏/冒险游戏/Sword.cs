using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base(game, location)
        { }

        public override string Name
        {
            get { return "Sword"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 3, 3, random))
            {
                switch (direction)
                {
                    case Direction.Up:
                        if (!DamageEnemy(Direction.Right, 3, 3, random))
                            DamageEnemy(Direction.Left, 3, 3, random);
                        break;
                    case Direction.Down:
                        if (!DamageEnemy(Direction.Left, 3, 3, random))
                            DamageEnemy(Direction.Right, 3, 3, random);
                        break;
                    case Direction.Left:
                        if (!DamageEnemy(Direction.Up, 3, 3, random))
                            DamageEnemy(Direction.Down, 3, 3, random);
                        break;
                    case Direction.Right:
                        if (!DamageEnemy(Direction.Down, 3, 3, random))
                            DamageEnemy(Direction.Up, 3, 3, random);
                        break;
                    default: break;
                }
            }
        }

    }
}   


