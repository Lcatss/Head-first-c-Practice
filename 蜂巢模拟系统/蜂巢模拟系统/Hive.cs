using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    [Serializable] public class Hive
    {
        //constant declarations
        private const int InitialBeeNumber = 6;
        private const double InitialHoney = 3.2;
        private const double MaxHoney = 30;
        private const double HoneyPerNectar = 0.25;
        public  int MaxBeeNumber = 38;
        private const double BreedHoney = 0.7;

        //variable declrations
        public double Honey { get;private set; }
        private Dictionary<string, Point> locations;
        private int beeCount;
        private World world;
        [NonSerialized] public StateChanged Changed;

        public Hive(World world,StateChanged Changed)
        {
            Honey=InitialHoney;
            InitializeLocations();
            Random random=new Random();
            this.world = world;
            this.Changed = Changed;
            for (int i = 0; i < InitialBeeNumber; i++)
			{
                AddBee(random); 
			}
            
        }


        public void InitializeLocations()
        {
            locations=new Dictionary<string,Point>()
            {
                {"Entrance",new Point(729,113)},
                {"Nursery",new Point(112,236)},
                {"HoneyFactory",new Point(221,122)},
                {"Exit",new Point(245,289)},
            };
        }

        

        public bool AddHoney(double nectar)
        {
            double honeyToAdd = nectar * HoneyPerNectar;
            if (honeyToAdd + Honey > MaxHoney)
                return false;
            else
            {
               Honey  += honeyToAdd;
                return true;
            }
        }

        public bool ConsumeHoney(double amount)
        {
            if (amount > Honey)
                return false;
            else
            {
                Honey -= amount;
                return true;
            }
        }
         

        public void AddBee(Random random)
        {
            if (world.Bees.Count < MaxBeeNumber)
            {
                beeCount++;
                int r1 = random.Next(100) - 50;
                int r2 = random.Next(100) - 50;
                Point startPoint = new Point(locations["Nursery"].X + r1,
                    locations["Nursery"].Y + r2);
                Bee newBee = new Bee(beeCount, startPoint,this,world,random);
                world.Bees.Add(newBee);
                newBee.Changed += Changed;
            }
        }

        public void Go(Random random)
        {
            if (random.Next(30) == 1)
                if(ConsumeHoney(BreedHoney))
                    AddBee(random);
            
        }

        public Point GetLocation(string location)
        {
            Point place = locations[location];
            if (place == null)
                throw new ArgumentException("It's a wrong location: "+location);
            else
                return place;
        }
        


    }
}
