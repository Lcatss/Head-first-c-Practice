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
    public partial class HiveForm : Form
    {
        public Renderer Renderer { get; set; }

        public HiveForm()
        {
            InitializeComponent();

        }

        private void HiveForm_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.X+ ","+ e.Location.Y);
        }

        private void HiveForm_Paint(object sender, PaintEventArgs e)
        {
            Renderer.PaintHive(e.Graphics);
        }
    }
}
