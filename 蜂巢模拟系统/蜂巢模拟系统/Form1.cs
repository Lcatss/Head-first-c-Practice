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
using System.Runtime.Serialization;
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        World world;
        private Random random = new Random();
        private DateTime start = DateTime.Now;
        private DateTime end;
        private int framesRun = 0;
        public delegate void getBee_OnStateChanged(int ID, string message);

        private HiveForm hiveForm = new HiveForm();
        private FieldForm fieldForm = new FieldForm();
        private Menu menu;
        private Renderer renderer;
        

        public Form1()
        {
            InitializeComponent();

            ResetSimulator();
            menu = new Menu(world,this,hiveForm,fieldForm);
            MoveChildForms();
            menu.Show(this);
            hiveForm.Show(this);
            fieldForm.Show(this);
            

            timer1.Interval = 1;
            timer2.Interval = 3 * timer1.Interval;
            timer1.Tick+=new EventHandler(RunFrame);
            timer1.Enabled = false;
            UpdateStats(new TimeSpan());
   
        }

        public void ChangeFPS(int fps)
        {
            int interval = 1000 / fps;
            timer1.Interval = interval;
            timer2.Interval = interval * 3;
        }

        private void ResetSimulator()
        {
            framesRun = 0;
            world = new World(new BeeStateChanged(SendMessage));
            renderer = new Renderer(world, hiveForm, fieldForm);
        }

        private void MoveChildForms()
        {
            hiveForm.Location = new Point(Location.X + Width + 10, Location.Y);
            fieldForm.Location = new Point(Location.X, Location.Y + Math.Max(Height, hiveForm.Height) + 10);
            menu.Location = new Point(Location.X + Width + 10 + hiveForm.Width + 10, Location.Y);
        }

        private void UpdateStats(TimeSpan frameDuration)
        {
            Bees.Text = world.Bees.Count.ToString();
            Flowers.Text = world.Flowers.Count.ToString();
            HoneyInHive.Text = String.Format("{0:f3}", world.hive.Honey);
            double nectar = 0;
            foreach (Flower flower in world.Flowers)
                nectar += flower.Nectar;
            NectarInFlowers.Text = String.Format("{0:f3}", nectar);
            FramesRun.Text = framesRun.ToString();
            double milliSeconds = frameDuration.TotalMilliseconds;
            if (milliSeconds != 0.0)
                FrameRate.Text = String.Format("{0:f0} ({1:f1}ms)", 1000 / milliSeconds, milliSeconds);
            else
                FrameRate.Text = "N/A";

            //self-written listbox code

            int[] beeWorks = (int[])world.BeesWorkInfo();
            listBox1.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                if (beeWorks[i] == 1)
                    listBox1.Items.Add(((BeeState)i).ToString() + ": " + beeWorks[i] + " bee");
                else if (beeWorks[i] != 0)
                    listBox1.Items.Add(((BeeState)i).ToString() + ": " + beeWorks[i] + " bees");
            }
        }

        public void RunFrame(object sender, EventArgs e)
        {
            framesRun++;
            world.Go(random);
            end = DateTime.Now;
            TimeSpan frameDuration = end - start;
            start = end;
            
            UpdateStats(frameDuration);

            hiveForm.Invalidate();
            fieldForm.Invalidate();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                toolStripButton1.Text = "Pause Simulation";
                timer1.Start();
            }
            else
            {
                toolStripButton1.Text = "Resume Simulation";
                timer1.Stop();
                
            }
            menu.InitializeFinish();
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ResetSimulator();

            timer1.Enabled = false;
            toolStripButton1.Text = "Start simulation";
           
            UpdateStats(new TimeSpan());
            listBox1.Items.Clear();
        }

        private void SendMessage(int ID, string Message)
        {
            toolStripStatusLabel1.Text = "Bee #" + ID + ": " + Message;

            //Linq实现的一个更新listbox的代码
            //var beeGroups =
            //    from bee in world.Bees
            //    group bee by bee.CurrentState into beeGroup
            //    orderby beeGroup.Key
            //    select beeGroup;
            //listBox1.Items.Clear();
            //foreach (var group in beeGroups)
            //{
            //    string s;
            //    if (group.Count() == 1)
            //        s = "";
            //    else
            //        s = "s";
            //    listBox1.Items.Add(group.Key.ToString() + ": " + group.Count() + " bee" + s);
            //    if (group.Key == BeeState.Idle && group.Count() == world.Bees.Count && framesRun > 0)
            //    {
            //        listBox1.Items.Add("Simulation ended: all bees are idle");
            //        toolStripButton1.Text = "Simulation ended";
            //        toolStripStatusLabel1.Text = "Simulation ended";
            //        timer1.Enabled = false;
            //    }
            //}
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            World currentWorld=world;
            int currentFrames=framesRun;

            timer1.Stop();
            openFileDialog1.Filter = "Bee Files|*.bee";
            openFileDialog1.FileName = "BeeData";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream input = File.OpenRead(openFileDialog1.FileName))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        world = (World)bf.Deserialize(input);
                        framesRun = (int)bf.Deserialize(input);
                    }
                    world.stateChanged = new BeeStateChanged(SendMessage);
                    world.hive.stateChanged = new BeeStateChanged(SendMessage);
                    foreach (Bee bee in world.Bees)
                        bee.StateChanged = new BeeStateChanged(SendMessage);
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show("Unable to read the file.\r\n" + ex.Message, "Bee Simulator Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    world = currentWorld;
                    framesRun = currentFrames;
                }
            }
            UpdateStats(new TimeSpan());

            renderer = new Renderer(world, hiveForm, fieldForm);
            menu.InitializeFinish();

        }

        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            bool state=timer1.Enabled;
            timer1.Stop();
            saveFileDialog1.Filter = "Bee Files|*.bee";
            saveFileDialog1.FileName = "BeeData";
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream output = File.Create(saveFileDialog1.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(output, world);
                    bf.Serialize(output, framesRun);
                }
            }
            if (state)
                timer1.Start();

        }

        private void Form1_Move(object sender, EventArgs e)
        {
            MoveChildForms();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect=Screen.GetWorkingArea(this);
            this.Top=rect.Size.Height/2-380;
            this.Left = rect.Size.Width / 2 - 391;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            renderer.AnimatedBees();
        }
    }
}
