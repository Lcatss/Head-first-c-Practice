using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Zoomer : UserControl
    {
        private Bitmap photo = Properties.Resources.wuzi;

        public Zoomer()
        {
            InitializeComponent();

        }

        private void Zoomer_Load(object sender, EventArgs e)
        {
        }

        private void Zoomer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(photo,
                10, 10,
                (int)trackBar1.Value,
                (int)trackBar2.Value);     
            
                    
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
