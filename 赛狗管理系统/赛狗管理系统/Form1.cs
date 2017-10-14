using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Guy[] guy = new Guy[3];
        public Greyhound[] hound = new Greyhound[4];
        public Form1()
        {
            InitializeComponent();
            dog1.Parent = racetrack;
            dog2.Parent = racetrack;
            dog3.Parent = racetrack;
            dog4.Parent = racetrack;


            Random randomizer= new Random();

            guy[0] = new Guy() { name = "Joe", money = 50, myLabel = JoesBet, myRadioButton = JoeRadioButton};
            guy[1] = new Guy() { name = "Bob", money = 75, myLabel = BobsBet, myRadioButton = BobRadioButton};
            guy[2] = new Guy() { name = "Al", money = 45, myLabel = AlsBet, myRadioButton = AlRadioButton };

            hound[0] = new Greyhound() { myPicturebox = dog1, startingPosition = 22, randomizer = randomizer, racetrackLength = 363 };
            hound[1] = new Greyhound() { myPicturebox = dog2, startingPosition = 22, randomizer = randomizer, racetrackLength = 363 };
            hound[2] = new Greyhound() { myPicturebox = dog3, startingPosition = 22, randomizer = randomizer, racetrackLength = 363 };
            hound[3] = new Greyhound() { myPicturebox = dog4, startingPosition = 22, randomizer = randomizer, racetrackLength = 363 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (guy[i].myBet == null || guy[i].myBet.amount == 0)
                {
                    MessageBox.Show(guy[i].name + "还没有下注！");
                    return;
                }
            }
            bool hasWinner=false;
            int winner=0;
            betButton.Enabled = false;
            button1.Enabled=false;
            while (!hasWinner)
            {
                Thread.Sleep(10);
                for (int i = 0; i < 4 && !hasWinner; i++)
                {
                    hasWinner = hound[i].run();
                    winner=i+1;
                }
                Application.DoEvents();
            }
            MessageBox.Show("冠军是——狗 #" + winner);
            for (int i = 0; i < 3; i++)
            {
                guy[i].collect(winner);
                guy[i].clearBet();
                guy[i].updateLabels();
            }
            for (int i = 0; i < 4; i++)
            {
                hound[i].takingStartingPosition();
            }
            betButton.Enabled = true;
            button1.Enabled = true;
        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            guyLabel.Text = "Joe";
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            guyLabel.Text = "Bob";
        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            guyLabel.Text = "Al";
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (guy[i].myRadioButton.Checked == true)
                {
                    guy[i].placeBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                    guy[i].updateLabels();
                }
            }
        }
    }
}
