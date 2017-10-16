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

        Player person1;
        Fool person2;
        Fool person3;

        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            person1 = new Player(random);
            person2 = new Fool(random);
            person3 = new Fool(random);
        }

        private void UpdateForm()
        {
            moneyA.Text = person1.Money.ToString();
            moneyB.Text = person2.Money.ToString();
            moneyC.Text = person3.Money.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            person1.GetOrder(true);
            Game.Play(person1, person2);
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person1.GetOrder(false);
            Game.Play(person1, person2);
            UpdateForm() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                Game.Play(person2, person3);
                UpdateForm();
            }

        }
    }
}
