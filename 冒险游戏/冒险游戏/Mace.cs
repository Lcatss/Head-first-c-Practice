using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Mace:Weapon
    {
        public Mace(Game game, Point location)
            : base(game,location)
        { }

        public override string Name
        {
            get { return "Mace"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            for (int i = 0; i < 4; i++)
            {
                DamageEnemy((Direction)i, 5, 6, random);
            }
        }
    
    }
}
