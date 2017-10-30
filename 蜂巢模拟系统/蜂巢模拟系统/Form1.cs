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
        World world;
        private Random random = new Random();
        private DateTime start = DateTime.Now;
        private DateTime end;
        private int framesRun = 0;

        public Form1()
        {
            InitializeComponent();
            world = new World();

            timer1.Interval = 50 ;
            timer1.Tick+=new EventHandler(RunFrame);
            timer1.Enabled = false;
            UpdateStats(new TimeSpan());
        }

        private void UpdateStats(TimeSpan frameDuration)
        {
            Bees.Text = world.Bees.Count.ToString();
            Flowers.Text = world.Flowers.Count.ToString();
            HoneyInHive.Text = String.Format("{0:f3}", world.hive.Honey);
            double nectar = 0;
            foreach (Flower flower in world.Flowers)
                nectar += flower.Nectar;
            NectarInFlowers.Text = String.Format("{0:f3}", nectar);
            FramesRun.Text = framesRun.ToString();
            double milliSeconds = frameDuration.TotalMilliseconds;
            if (milliSeconds != 0.0)
                FrameRate.Text = String.Format("{0:f0} ({1:f1}ms)", 1000 / milliSeconds, milliSeconds);
            else
                FrameRate.Text = "N/A";
        }

        public void RunFrame(object sender, EventArgs e)
        {
            framesRun++;
            world.Go(random);
            end = DateTime.Now;
            TimeSpan frameDuration = end - start;
            start = end;
            
            UpdateStats(frameDuration);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                toolStripButton1.Text = "Resume Simulation";
                timer1.Start();
            }
            else
            {
                toolStripButton1.Text = "Pause Simulation";
                timer1.Stop();
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            world = new World();
            framesRun = 0;
            toolStripButton1.Text = "Start simulation";
            UpdateStats(new TimeSpan());
        }

    }
}
