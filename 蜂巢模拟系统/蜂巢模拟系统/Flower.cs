using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    [Serializable] public class Flower
    {
        public Point Location { get;private set; }
        public int Age { get;private  set; }
        public bool Alive { get;private set; }
        public double Nectar { get;private set; }
        public double NectarHarVested { get; set; }
        private int lifespan;

        private const int LifeSpanMin=15000;
        private const int LifespanMax = 30000;
        private const double InitialNectar = 1.5;
        private const double MaxNectar = 5;
        private const double NectarAddedPerTurn = 0.01;
        private const double NectarGatheredPerTurn = 0.3;

        public Flower(Point location, Random random)
        {
            this.Location = location;
            this.Age = 0;
            this.Alive = true;
            this.Nectar = InitialNectar;
            this.NectarHarVested = 0;
            this.lifespan = random.Next(LifeSpanMin, LifespanMax + 1);
        }

        public double HarvestNectar()
        {
            if (NectarGatheredPerTurn > Nectar)
                return 0;
            else
            {
                Nectar-=NectarGatheredPerTurn;
                NectarHarVested+=NectarGatheredPerTurn;
                return NectarGatheredPerTurn;
            }

        }

        public void Go()
        {
            Age += 1;
            if (Age > lifespan)
                Alive = false;
            else if (Nectar + NectarAddedPerTurn <= MaxNectar)
            {
                Nectar += NectarAddedPerTurn;
            }
        }

    }
}
