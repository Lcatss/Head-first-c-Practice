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
    public partial class FieldForm : Form
    {
        public Renderer Renderer{get; set;}


        public FieldForm()
        {
            InitializeComponent();
        }




        private void FieldForm_Paint(object sender, PaintEventArgs e)
        {
            Renderer.PaintField(e.Graphics);
        }

        private void FieldForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(782, 360);
        }


    }
}
