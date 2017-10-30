using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class World
    {
        private const double NectarHarvestedPerNewFlower = 50;
        private const int FieldMinX = 15;
        private const int FieldMinY = 177;
        private const int FieldMaxX = 690;
        private const int FieldMaxY = 290;

        public Hive hive { get;private set; }
        public List<Bee> Bees { get;set; }
        public List<Flower> Flowers { get;private set; }
        private BeeStateChanged stateChanged;

        public World(BeeStateChanged StateChanged)
        {
            this.stateChanged = StateChanged;
            Bees = new List<Bee>();
            Flowers = new List<Flower>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                AddFlower(random);
            hive = new Hive(this,StateChanged);
        }

        public void Go(Random random)
        {
            hive.Go(random);

            for (int i = Bees.Count - 1; i >= 0; i--)
            {
                Bee bee = Bees[i];
                bee.Go(random);
                if (bee.CurrentState == BeeState.Retired)
                    Bees.Remove(bee);
            }

            double totalNectarHarvested = 0;
            for (int i = Flowers.Count - 1; i >= 0; i--)
            {
                Flower flower = Flowers[i];
                flower.Go();
                totalNectarHarvested += flower.NectarHarVested;
                if (!flower.Alive)
                    Flowers.Remove(flower);
            }
            if (totalNectarHarvested > NectarHarvestedPerNewFlower)
            {
                foreach (Flower flower in Flowers)
                    flower.NectarHarVested = 0;
                AddFlower(random);
            }
        }

        private void AddFlower(Random random)
        {
            Point location = new Point(random.Next(FieldMinX, FieldMaxX), random.Next(FieldMinY, FieldMaxY));
            Flower newFlower = new Flower(location, random);
            Flowers.Add(newFlower);
        }


        //public IEnumerable<int> BeesWorkInfo()
        //{
        //    int[] beeWorks = new int[6];
        //    foreach (Bee bee in Bees)
        //        beeWorks[(int)bee.CurrentState] += 1;
        //    return beeWorks;
        //}
            



    }
}
