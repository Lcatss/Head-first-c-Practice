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
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            jobComboBox.SelectedIndex = 0;

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar Collector", "Honey manufacturing" },175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" },114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "String patrol" },149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Egg care", "Hive maintenance", "Baby bee tutoring", "Honey manufacturing", "String patrol" },155);
            queen = new Queen(workers,275);
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(jobComboBox.Text, (int)shifts.Value))
                MessageBox.Show("The job \"" + jobComboBox.Text + "\" will be done in " + shifts.Value.ToString() + " shifts", "The queen bee says...");
            else
                MessageBox.Show("No bee can do this job", "The queen bee says...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string report = queen.WorkTheNextShift();
            reportTextBox.Text = report;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
