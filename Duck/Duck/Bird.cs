using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bird
    {
        public string Name { get; set; }
        public void Fly()
        {
            Console.WriteLine("Flap,flap");
        }

        public override string ToString()
        {
            return "A bird named " + Name;
        }
    }
}
