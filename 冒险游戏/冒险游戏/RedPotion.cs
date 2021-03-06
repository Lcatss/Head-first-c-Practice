﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class RedPotion:Weapon,IPotion
    {
        public RedPotion(Game game, Point location)
            : base(game, location)
        { used = false; }

        private bool used;
        public bool Used { get { return used; } }

        public override string Name
        {
            get { return "Red Potion"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            if (!used)
            {
                game.IncreasePlayerHealth(10, random);
                used = true;
            }

        }
    }
}
