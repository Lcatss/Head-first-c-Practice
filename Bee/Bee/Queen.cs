using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber=0;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }
        public bool AssignWork(string job,int shiftsToWork)
        {
            for (int i = 0; i < workers.Length; i++)
			{
			    if(workers[i].DoThisJob(job,shiftsToWork))
                    return true;
			}
            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber += 1;
            string report = "Report for shift #" + shiftNumber.ToString() + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1).ToString() + " finished the job\r\n";
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                {                 
                    report += "Worker #" + (i+1).ToString() + " is not working\r\n";
                }

                else if (workers[i].ShiftsLeft == 1)
                    report += "Worker #" + (i+1).ToString() + " will be done wtih \"" + workers[i].CurrentJob + "\" after this shift\r\n";
                else
                    report += "Worker #" + (i+1).ToString() + " is doing \"" + workers[i].CurrentJob + "\" for " + workers[i].ShiftsLeft.ToString() + " more shifts\r\n";
                workers[i].WorkOneShift();
            }
            return report;
        }
    }
}
