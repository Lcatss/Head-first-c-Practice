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
        private HiveForm hiveForm;
        private FieldForm fieldForm;


        public Menu(World world,Form1 form1,HiveForm hiveForm,FieldForm fieldForm)
        {
            InitializeComponent();
            this.world = world;
            this.form1 = form1;
            this.hiveForm = hiveForm;
            this.fieldForm = fieldForm;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            maxBeeNumber.Text = "Max Bee Number:" + MaxBeeNumberBar.Value;
            world.hive.MaxBeeNumber = (int)MaxBeeNumberBar.Value;
        }

        public void InitializeFinish()
        {
            InitialBeeNumberBar.Enabled = false;
        }

        private void InitialBeeNumberBar_Scroll(object sender, EventArgs e)
        { 
                
        }

        private void FpsBar_Scroll(object sender, EventArgs e)
        {
            Fps.Text = "Fps:" + FpsBar.Value;
            form1.ChangeFPS(FpsBar.Value);
        }


    }
}
