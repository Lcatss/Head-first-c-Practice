using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Fan
    {
        public Fan(Ball ball)
        {
            ball.BallInPlay += new EventHandler<BallEventArgs>(ball_BallInPlay);
        }


        void ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Distance > 400 && ballEventArgs.Trajectory > 30)
                    Console.WriteLine("Fan:Home run!I'm going for the ball!");
                else
                    Console.WriteLine("Fan:Woo-hoo! Yeah!");
            }

        }
    }
}
