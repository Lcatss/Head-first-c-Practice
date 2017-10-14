using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount{get{return meal.Count;}}
        public void TakeFlapjacks(Flapjack Food, int HowMany)
        {
            for (int i = 0; i < HowMany; i++)
            {
                meal.Push(Food);
            }
        }

        public void EatFlapJacks()
        {
            Console.WriteLine(name + "'s eating flapjacks");
            while (meal.Count > 0)
            {
                Console.WriteLine(name + " ate a " + meal.Pop().ToString().ToLower() + " flapjack");
            }
        }
    }
}
