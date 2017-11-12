using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    [Serializable] public class Bee
    {
        private  const double HoneyConsumed = 0.5;
        private const int MoveRate = 3;
        private const double MinimumFlowerNectar = 1.5;
        private const int CareerSpanMin = 1000;
        private const int CareerSpanMax = 2000;
        private int CareerSpan;

        public int Age { get;private set; }
        public bool InsideHive { get;private set; }
        public double NectarCollected { get;private set; }
        public BeeState CurrentState { get;private set; }
        private Hive hive;
        private World world;

        private Point location;
        public Point Location { get { return location; } }

        private int id;
        public int ID { get { return id; } }
        private Flower destinationFlower;

        [NonSerialized] public StateChanged Changed;

        

        public Bee(int id, Point location,Hive hive,World world,Random random)
        {
            this.id = id;
            this.Age = 0;
            this.location = location;
            this.InsideHive = true;
            this.destinationFlower = null;
            this.NectarCollected = 0;
            this.CurrentState = BeeState.空闲;
            this.hive = hive;
            this.world = world;
            this.CareerSpan = random.Next(1000, 2000);
        }

        public void Go(Random random)
        {
            BeeState oldState = CurrentState;

            Age++;
            switch (CurrentState)
            {
                case BeeState.空闲:
                    if (Age > CareerSpan)
                        CurrentState = BeeState.退休;
                    else if (world.Flowers.Count > 0 && hive.ConsumeHoney(HoneyConsumed))
                    {
                        Flower flower = world.Flowers[random.Next(world.Flowers.Count)];
                        if ((flower.Nectar >= MinimumFlowerNectar && flower.Alive))
                        {
                            destinationFlower = flower;
                            CurrentState = BeeState.飞向花朵;
                        }
                    }
                    break;
                case BeeState.飞向花朵:
                    if (!world.Flowers.Contains(destinationFlower))
                        CurrentState = BeeState.返回蜂巢;
                    else if (InsideHive)
                    {
                        if (MoveTowardsLocation(hive.GetLocation("Exit")))
                        {
                            InsideHive = false;
                            location = hive.GetLocation("Entrance");
                        }
                    }
                    else
                        if (MoveTowardsLocation(destinationFlower.Location))
                            CurrentState = BeeState.收集花蜜;
                 
                    break;
                case BeeState.收集花蜜:
                    double nectar = destinationFlower.HarvestNectar();
                    if (nectar > 0)
                        NectarCollected += nectar;
                    else
                        CurrentState = BeeState.返回蜂巢;
                    break;
                case BeeState.返回蜂巢:
                    if (!InsideHive)
                    {
                        if (MoveTowardsLocation(hive.GetLocation("Entrance")))
                        {
                            InsideHive = true;
                            location = hive.GetLocation("Exit");
                        }
                    }
                    else
                    {
                        if (MoveTowardsLocation(hive.GetLocation("HoneyFactory")))
                            CurrentState = BeeState.制造蜂蜜;
                    }
                    break;
                case BeeState.制造蜂蜜:
                    if (NectarCollected < 0.5)
                    {
                        NectarCollected = 0;
                        CurrentState = BeeState.空闲;
                    }
                    else
                    {
                        if (hive.AddHoney(0.5))
                            NectarCollected -= 0.5;
                        else
                            NectarCollected = 0;
                    }
                    break;
                case BeeState.退休:
                    //do nothing
                    break;
            }

            if (oldState != CurrentState && Changed != null)
            {
                Changed("蜜蜂 #"+ID+": "+ CurrentState.ToString());
            }
        

        }

        private bool MoveTowardsLocation(Point destination)
        {
            if (Math.Abs(destination.X - location.X) <= MoveRate && Math.Abs(destination.Y - location.Y) <= MoveRate)
                return true;

            if (destination.X > location.X)
                location.X += MoveRate;
            else if (destination.X < location.X)
                location.X -= MoveRate;
            if (destination.Y > location.Y)
                location.Y += MoveRate;
            else if (destination.Y < location.Y)
                location.Y -= MoveRate;

            return false;
        }

    }
}
