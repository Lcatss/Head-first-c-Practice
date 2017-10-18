using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Guy Joe;
        Guy Bob;
        int bank = 100;

        public void UpdateForm()
        {
            joeCashLabel.Text = Joe.name + " has $" + Joe.cash;
            bobCashLabel.Text = Bob.name + " has $" + Bob.cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }   

        public Form1()
        {
            InitializeComponent();
            Joe = new Guy() { cash = 50, name = "Joe" };
            Bob = new Guy() { cash = 100, name = "Bob" };
            UpdateForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= Joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += Bob.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int amount;
            amount = Joe.GiveCash(10);
            Bob.ReceiveCash(amount);
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int amount;
            amount = Bob.GiveCash(5);
            Joe.ReceiveCash(5);
            UpdateForm();
        }

        private void saveJoe_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Guy_File.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, Joe);
            }
        }
        
        
    

        private void loadJoe_Click(object sender, EventArgs e)
        {
            using(Stream input=File.OpenRead("Guy_File.dat"))
            {
                BinaryFormatter formatter =new BinaryFormatter();
                Joe=(Guy)formatter.Deserialize(input);
            }
            UpdateForm();
        }
    }
}
