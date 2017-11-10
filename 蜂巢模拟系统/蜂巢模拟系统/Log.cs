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
    public partial class Log : Form
    {
        public delegate void AddLog(string message);
        public AddLog Add_Log { get { return new AddLog(AddNewLog); } }
        private string log;
        public string GetLog { get { return log; } }

        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            this.Size = new Size(334, 360);
        }

        private void AddNewLog(string message)
        {
            this.log += message += "\r\n\r\n";
            textBox1.Text=log;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }

        public void Reset()
        {
            log = "";
            textBox1.Text = "";
        }

        public void LoadLog(string log)
        {
            this.log = log;
            textBox1.Text = log;
        }
    }
}
