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
        private Queue<Lumberjack> breakfastLine;
        public Form1()
        {
            InitializeComponent();
            breakfastLine=new Queue<Lumberjack>();
            RedrawList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Crispy;
            else if (soggy.Checked == true)
                food = Flapjack.Soggy;
            else if (browned.Checked == true)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            RedrawList();
        }

        private void AddLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack currentLumberjack=new Lumberjack(LumberjackName.Text);
            breakfastLine.Enqueue(currentLumberjack);
            RedrawList();
        }

        private void RedrawList()
        {
            line.Items.Clear();
            int number = 1;
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number.ToString()+"."+lumberjack.Name);
                number++;
            }

            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + " flapjacks";
            }
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            breakfastLine.Dequeue().EatFlapJacks();
            RedrawList();
        }


    }
}
