using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class BeeStateChangedEventArgs:EventArgs
    {
        public int ID;
        public string Message;

        public BeeStateChangedEventArgs(int ID, string Message)
        {
            this.ID = ID;
            this.Message = Message;
        }
    }
}
