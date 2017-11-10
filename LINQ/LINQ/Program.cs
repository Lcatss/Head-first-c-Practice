using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=|DataDirectory|\\ContactDB.sdf";
            ContactDB context = new ContactDB(connectionString);


            var peopleData =
                from person in context.People
                select new { person.Name, person.Company };
            foreach (var person in peopleData)
                Console.WriteLine("{0} work at {1}", person.Name, person.Company);
            Console.ReadKey();
        }
    }
}
