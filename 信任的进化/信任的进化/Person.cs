using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    abstract class Person//人类
    {
        private int money;
        public int Money { get { return money; } }
        protected Random random;

        private List<bool> enemyChioces;

        public Person(Random random)
        {
            this.money = 0;
            this.enemyChioces = new List<bool>();
            this.random = random;
        }

        public abstract bool Decide();

        public void Play(bool self,bool enemy)
        {



            if (self)
                money--;
            if (enemy)
                money += 3;

            enemyChioces.Add(enemy);
        }
    }
}
