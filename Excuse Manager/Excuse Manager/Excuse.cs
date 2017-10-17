using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get;  set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            ExcusePath="";
        }
        public Excuse(string excusePath)
        {
            this.ExcusePath = excusePath;
            OpenFile(ExcusePath);
        }
        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }


        public void OpenFile(string excusePath)
        {
            using (StreamReader reader = new StreamReader(excusePath))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

        public void Save(string excusePath)
        {
            using (StreamWriter writer = new StreamWriter(excusePath))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed.ToString());
            }
        }


    }
}
