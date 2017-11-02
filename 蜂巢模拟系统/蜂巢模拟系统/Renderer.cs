using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Renderer
    {
        private World world;
        private HiveForm hiveForm;
        private FieldForm fieldForm;
        
        private Dictionary<Bee, BeeControl> beeLookUp = new Dictionary<Bee, BeeControl>();
        private List<Bee> retiredBees = new List<Bee>();

        private Dictionary<Flower, PictureBox> flowerLookUp = new Dictionary<Flower, PictureBox>();
        private List<Flower> deadFlowers = new List<Flower>();

        public Renderer(World world, HiveForm hiveForm, FieldForm fieldForm)
        {
            this.world = world;
            this.hiveForm = hiveForm;
            this.fieldForm = fieldForm;
        }

        public void Render()
        {
            DrawBees();
            DrawFlowers();
            RemoveRetiredBeesAndDeadFlowers();
        }

        public void Reset()
        {
            foreach (PictureBox flower in flowerLookUp.Values)
            {
                fieldForm.Controls.Remove(flower);
                flower.Dispose();
            }
            foreach (BeeControl bee in beeLookUp.Values)
            {
                hiveForm.Controls.Remove(bee);
                fieldForm.Controls.Remove(bee);
                bee.Dispose();
            }
            flowerLookUp.Clear();
            beeLookUp.Clear();
        }

        private void DrawFlowers()
        {
            foreach (Flower flower in world.Flowers)
            {
                if (!flowerLookUp.ContainsKey(flower))
                {
                    PictureBox flowerControl = new PictureBox()
                    {
                        Width = 45,
                        Height = 55,
                        Image = Properties.Resources.Flower,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = flower.Location
                    };
                    flowerLookUp.Add(flower, flowerControl);
                    fieldForm.Controls.Add(flowerControl);
                }
            }

            foreach (Flower flower in flowerLookUp.Keys)
            {
                if (!world.Flowers.Contains(flower))
                {
                    PictureBox flowerControlToRemove = flowerLookUp[flower];
                    fieldForm.Controls.Remove(flowerControlToRemove);
                    flowerControlToRemove.Dispose();
                    deadFlowers.Add(flower);
                }
            }
        }

        private void DrawBees()
        {
            BeeControl beeControl;
            foreach(Bee bee in world.Bees)
            {
                beeControl=GetBeeControl(bee);
                if(bee.InsideHive)
                {
                    if(fieldForm.Controls.Contains(beeControl))
                        MoveBeeFromFieldToHive(beeControl);
                }
                else if(hiveForm.Controls.Contains(beeControl))
                    MoveBeeFromHiveToField(beeControl);

                beeControl.Location=bee.Location;
            }

            foreach(Bee bee in beeLookUp.Keys)
            {
                if(!world.Bees.Contains(bee))
                {
                    beeControl=beeLookUp[bee];
                    if(fieldForm.Controls.Contains(beeControl))
                        fieldForm.Controls.Remove(beeControl);
                    if(hiveForm.Controls.Contains(beeControl))
                        hiveForm.Controls.Remove(beeControl);
                    beeControl.Dispose();
                    retiredBees.Add(bee);
                }
            }
        }

        private BeeControl GetBeeControl(Bee bee)
        {
            BeeControl beeControl;
            if (!beeLookUp.ContainsKey(bee))
            {
                beeControl = new BeeControl() { Width = 40, Height = 40 };
                beeLookUp.Add(bee, beeControl);
                hiveForm.Controls.Add(beeControl);
                beeControl.BringToFront();
            }
            else
                beeControl = beeLookUp[bee];
            return beeControl;
        }

        private void MoveBeeFromHiveToField(BeeControl beeControl)
        {
            hiveForm.Controls.Remove(beeControl);
            beeControl.Size = new Size(20, 20);
            fieldForm.Controls.Add(beeControl);
            beeControl.BringToFront();
        }

        private void MoveBeeFromFieldToHive(BeeControl beeControl)
        {
            fieldForm.Controls.Remove(beeControl);
            beeControl.Size = new Size(40, 40);
            hiveForm.Controls.Add(beeControl);
            beeControl.BringToFront();
        }

        private void RemoveRetiredBeesAndDeadFlowers()
        {
            foreach (Bee bee in retiredBees)
                beeLookUp.Remove(bee);
            retiredBees.Clear();
            foreach (Flower flower in deadFlowers)
                flowerLookUp.Remove(flower);
            deadFlowers.Clear();
        }

                    
    }
}
