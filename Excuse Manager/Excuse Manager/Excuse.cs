using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    [Serializable]
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
            string[] fileNames = Directory.GetFiles(folder, "*.excuse");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }


        public void OpenFile(string excusePath)
        {
            using (Stream input = File.OpenRead(excusePath))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Excuse temp=(Excuse)bf.Deserialize(input);
                this.Description = temp.Description;
                this.LastUsed = temp.LastUsed;
                this.Results = temp.Results;
            }
        }

        public void Save(string excusePath)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.Create(excusePath))
            {
                bf.Serialize(output, this);
            }

        }


    }
}
