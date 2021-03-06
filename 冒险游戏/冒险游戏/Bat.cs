﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Bat:Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        { }

        public override void Move(Random random)
        {
            if (HitPoints > 0)
            {
                if (random.Next(2) == 0)
                    base.location=Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                else
                    base.location=Move((Direction)random.Next(4), game.Boundaries);

                if (Nearby(game.PlayerLocation, 30))
                    game.HitPlayer(2, random);
            }
        }
    }
}
