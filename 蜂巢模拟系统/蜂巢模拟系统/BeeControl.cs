using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class BeeControl:PictureBox
    {
        private Timer animationTimer = new Timer();
        private Bitmap[] cells = new Bitmap[4];

        public BeeControl()
        {
            animationTimer.Tick += new EventHandler(animationTimer_Tick);
            animationTimer.Interval = 150;
            animationTimer.Start();
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            ResizeCells();
        }

        private int cell = 0;

        void animationTimer_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1:
                    BackgroundImage = cells[0]; break;
                case 2:
                    BackgroundImage = cells[1]; break;
                case 3:
                    BackgroundImage = cells[2]; break;
                case 4:
                    BackgroundImage = cells[3]; break;
                case 5:
                    BackgroundImage = cells[2]; break;
                default:
                    BackgroundImage = cells[1];
                    cell = 0; break;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if(disposing)
                animationTimer.Dispose();
        }


        private void ResizeCells()
        {
            cells[0] = Renderer.ResizeImage(Properties.Resources.Bee_animation_1, Width, Height);
            cells[1] = Renderer.ResizeImage(Properties.Resources.Bee_animation_2, Width, Height);
            cells[2] = Renderer.ResizeImage(Properties.Resources.Bee_animation_3, Width, Height);
            cells[3] = Renderer.ResizeImage(Properties.Resources.Bee_animation_4, Width, Height);
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BeeControl
            // 
            this.Resize += new System.EventHandler(this.BeeControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void BeeControl_Resize(object sender, EventArgs e)
        {
            ResizeCells();
        }

    }
}
