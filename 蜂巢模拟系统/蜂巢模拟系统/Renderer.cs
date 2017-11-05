using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class Renderer
    {
        private World world;
        private HiveForm hiveForm;
        private FieldForm fieldForm;

        private int cell =0;
        private int frame=0;

        public Bitmap HiveInside;
        public Bitmap HiveOutside;
        public Bitmap Flower;

        public Bitmap[] BeeAnimationLarge=new Bitmap[4];
        public Bitmap[] BeeAnimationSmall=new Bitmap[4];
        
        public Renderer(World world, HiveForm hiveForm, FieldForm fieldForm)
        {
            this.world = world;
            this.hiveForm = hiveForm;
            this.fieldForm = fieldForm;
            hiveForm.Renderer = this;
            fieldForm.Renderer = this;
            InitializeImages();
        }

        private void InitializeImages()
        {
            HiveInside = new Bitmap(Properties.Resources.Hive__inside_, hiveForm.ClientSize);
            HiveOutside = new Bitmap(Properties.Resources.Hive__outside_, 105,123);
            Flower = new Bitmap(Properties.Resources.Flower, 45, 55);

            BeeAnimationLarge[0]=ResizeImage(Properties.Resources.Bee_animation_1,40,40);
            BeeAnimationLarge[1]=ResizeImage(Properties.Resources.Bee_animation_2,40,40);
            BeeAnimationLarge[2]=ResizeImage(Properties.Resources.Bee_animation_3,40,40);
            BeeAnimationLarge[3]=ResizeImage(Properties.Resources.Bee_animation_4,40,40);

            BeeAnimationSmall[0]=ResizeImage(Properties.Resources.Bee_animation_1,20,20);
            BeeAnimationSmall[1]=ResizeImage(Properties.Resources.Bee_animation_2,20,20);
            BeeAnimationSmall[2]=ResizeImage(Properties.Resources.Bee_animation_3,20,20);
            BeeAnimationSmall[3]=ResizeImage(Properties.Resources.Bee_animation_4,20,20);
        }

        public void PaintHive(Graphics g)
        {
            g.FillRectangle(Brushes.SkyBlue, hiveForm.ClientRectangle);
            g.DrawImageUnscaled(HiveInside, 0, 0);
            foreach (Bee bee in world.Bees)
                if(bee.InsideHive)  
                    g.DrawImageUnscaled(BeeAnimationLarge[cell], bee.Location);

        }

        public void PaintField(Graphics g)
        {
            g.FillRectangle(Brushes.SkyBlue,0,0, fieldForm.ClientSize.Width, fieldForm.ClientSize.Height / 2);
            g.FillRectangle(Brushes.Green, 0, fieldForm.ClientSize.Height / 2, fieldForm.ClientSize.Width, fieldForm.ClientSize.Height);
            g.FillEllipse(Brushes.Yellow, 20, 20, 80, 80);
            using (Pen pen = new Pen(Brushes.Black, 5))
            {
                g.DrawLine(pen, 700, 12, 700, 0);
            }
            foreach (Flower flower in world.Flowers)
                g.DrawImageUnscaled(Flower, flower.Location);
            g.DrawImageUnscaled(HiveOutside, 649, 12);
            foreach (Bee bee in world.Bees)
                if(!bee.InsideHive)
                    g.DrawImageUnscaled(BeeAnimationSmall[cell], bee.Location);
        }

        public static Bitmap ResizeImage(Bitmap picture,int width,int height)
        {
            Bitmap resizedPicture = new Bitmap(width,height);
            using(Graphics graphics = Graphics.FromImage(resizedPicture))
                graphics.DrawImage(picture,0,0,width,height);
            return resizedPicture;
        }

        public void AnimatedBees()
        {
             frame++;
            if(frame>=6)
                frame=0;
            switch (frame)
            {
                case 0: cell=0; break;
                case 1: cell=1; break;
                case 2: cell=2; break;
                case 3: cell=3; break;
                case 4: cell=2; break;
                case 5: cell=1; break;
                default : cell=0; break;
            }
            hiveForm.Invalidate();
            fieldForm.Invalidate();
        }



                    
    }
}
