using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    [Serializable] public class World
    {
        private const double NectarHarvestedPerNewFlower = 50;
        private const int FieldMinX = 5;
        private const int FieldMinY = 190;
        private const int FieldMaxX = 725;
        private const int FieldMaxY = 268;
        private const int InitialFlowerNumber = 10;
        public int MaxFlower = 60;

        public Hive hive { get;private set; }
        public List<Bee> Bees { get;set; }
        public List<Flower> Flowers { get;private set; }
        [NonSerialized] public StateChanged Changed;

        public World(StateChanged Changed)
        {
            this.Changed = Changed;
            Bees = new List<Bee>();
            Flowers = new List<Flower>();
            Random random = new Random();
            for (int i = 0; i < InitialFlowerNumber; i++)
                AddFlower(random);
            hive = new Hive(this,Changed);
        }

        public void Go(Random random)
        {

            hive.Go(random);

            for (int i = Bees.Count - 1; i >= 0; i--)
            {
                Bee bee = Bees[i];
                bee.Go(random);
                if (bee.CurrentState == BeeState.退休)
                {
                    Changed("蜜蜂 #" + bee.ID + ": 死亡，享年" + bee.Age + "回合");
                    Bees.Remove(bee);
                }
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
            if (totalNectarHarvested > NectarHarvestedPerNewFlower&&Flowers.Count<=MaxFlower)
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


        public IEnumerable<int> BeesWorkInfo()
        {
            int[] beeWorks = new int[6];
            foreach (Bee bee in Bees)
                beeWorks[(int)bee.CurrentState] += 1;
            return beeWorks;
        }
            



    }
}
