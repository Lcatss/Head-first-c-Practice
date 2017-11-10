using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    [Serializable] class Clone:IDisposable
    {
        public int Id { get; private set; }

        public Clone(int Id)
        {
            this.Id = Id;
        }

        public void Dispose()
        {
            string fileName = @"D:\z\技术\电脑\C#\Head first c# practice\Clone\Clone\Properties\Clone.dat";
            string dirName = @"D:\z\技术\电脑\C#\Head first c# practice\Clone\Clone\Properties";
            if (!File.Exists(fileName))
                Directory.CreateDirectory(dirName);
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.OpenWrite(fileName))
            {
                bf.Serialize(output, this);
            }

            MessageBox.Show("Must serialize...object!", "Clone #" + Id + "Says...");
        }

        ~Clone()
        {
            MessageBox.Show("Aaargh!You got me!", "Clone #" + Id + "Says...");
        }
    }
}
