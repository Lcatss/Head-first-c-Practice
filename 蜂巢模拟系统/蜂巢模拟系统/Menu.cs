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
    public partial class Menu : Form
    {
        private World world;
        private Form1 form1;
        private Random random;


        public Menu(World world, Form1 form1, Random random)
        {
            InitializeComponent();
            this.world = world;
            this.form1 = form1;
            this.random=random;
            InitialBeeNumberBar.Enabled = true;
        }




        public void InitializeFinish()
        {
            InitialBeeNumberBar.Enabled = false;
        }

        private void InitialBeeNumberBar_Scroll(object sender, EventArgs e)
        {
            InitialBeeNumber.Text = "Initial Bee Number:" + InitialBeeNumberBar.Value;
            int n=InitialBeeNumberBar.Value-world.Bees.Count;
            if (n > 0)
                for (int i = 0; i < n; i++)
                {
                    world.hive.AddBee(random);
                    world.hive.AddHoney(0.5*4);
                }
            else if (n < 0)
                for (int i = 0; i < -n; i++)
                {
                    world.Bees.RemoveAt(world.Bees.Count - 1);
                    world.hive.AddHoney(-0.5 * 4);
                }
            form1.UpdateStats(new TimeSpan());
        }

        private void FpsBar_Scroll(object sender, EventArgs e)
        {
            Fps.Text = "Fps:" + FpsBar.Value;
            form1.ChangeFPS(FpsBar.Value);
        }

        private void MaxBeeNumberBar_Scroll(object sender, EventArgs e)
        {
            maxBeeNumber.Text = "Max Bee Number:" + MaxBeeNumberBar.Value;
            world.hive.MaxBeeNumber = (int)MaxBeeNumberBar.Value;
            int n = MaxBeeNumberBar.Value - world.Bees.Count;
            if (n < 0)
                for (int i = 0; i < -n; i++)
                    world.Bees.RemoveAt(world.Bees.Count - 1);
            form1.UpdateStats(new TimeSpan());
        }




    }
}
