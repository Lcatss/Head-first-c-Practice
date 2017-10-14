using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Worker
    {
        private string currentJob;
        public string CurrentJob { get { return currentJob; } }
        public int ShiftsLeft { get { return shiftsToWork-shiftsWorked; } }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job,int shiftsToWork)
        {
            if (string.IsNullOrEmpty(CurrentJob))
            {
                for (int i = 0; i < jobsICanDo.Length; i++)
                {
                    if (jobsICanDo[i] == job)
                    {
                        this.shiftsToWork=shiftsToWork;
                        currentJob=job;
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }

        public bool WorkOneShift()
        {
            if (!string.IsNullOrEmpty(currentJob))
            {
                shiftsWorked += 1;
                if (shiftsWorked > shiftsToWork)
                {
                    currentJob = "";
                    shiftsToWork = 0;
                    shiftsWorked = 0;
                    return true;
                }
                else
                    return false;

            }
            else
                return false;

        }

    }
}
		    
