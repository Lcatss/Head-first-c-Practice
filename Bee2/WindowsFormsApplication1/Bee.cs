using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Bee
    {
        public Bee(double weight)
        {
            this.weight=weight;
        }

        
        private double weight;
        virtual public int ShiftsLeft { get { return 0; } }

        virtual public double GetHoneyConsumption()//计算需要多少蜂蜜
        {
            double honey = 0.0d;

            if (ShiftsLeft == 0)
                honey = 7.5d;
            else
                honey = ShiftsLeft + 9;
            if (weight > 150)
                honey *= 1.35;
            return honey;
        }



        
    }
}
