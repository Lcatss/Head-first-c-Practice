using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Ball ball;
        Pitcher pitcher;
        Fan fan;
        public Form1()
        {
            InitializeComponent();
            ball = new Ball();
            pitcher = new Pitcher(ball);
            fan = new Fan(ball);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bat bat = ball.GetNewBat();
            BallEventArgs ballEventArgs = new BallEventArgs((int)trajectory.Value, (int)distance.Value);
            bat.HitTheBall(ballEventArgs);
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
