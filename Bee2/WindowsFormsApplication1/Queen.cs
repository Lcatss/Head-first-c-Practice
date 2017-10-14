using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Queen:Bee
    {
        private Worker[] workers;
        private int shiftNumber=0;

        public Queen(Worker[] workers,double weight):base(weight)
        {
            this.workers = workers;
        }
        public bool AssignWork(string job,int shiftsToWork)//发布任务
        {
            for (int i = 0; i < workers.Length; i++)
			{
			    if(workers[i].DoThisJob(job,shiftsToWork))
                    return true;
			}
            return false;
        }

        public string WorkTheNextShift()//工作一轮并生成报告
        {
            double totalCost = 0d;
            shiftNumber += 1;
            string report = "Report for shift #" + shiftNumber.ToString() + "\r\n";
            report += "The Queen costs " + GetHoneyConsumption() + " honey\r\n";
            totalCost += GetHoneyConsumption();
            for (int i = 0; i < workers.Length; i++)
            {
                report += "Worker #" + (i + 1).ToString() + " costs " + workers[i].GetHoneyConsumption() + " honey\r\n";
                totalCost += workers[i].GetHoneyConsumption();
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1).ToString() + " finished the job\r\n";
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                {                 
                    report += "Worker #" + (i+1).ToString() + " is not working\r\n";
                }

                else if (workers[i].ShiftsLeft == 0)
                    report += "Worker #" + (i+1).ToString() + " will be done wtih \"" + workers[i].CurrentJob + "\" after this shift\r\n";
                else
                    report += "Worker #" + (i+1).ToString() + " is doing \"" + workers[i].CurrentJob + "\" for " + workers[i].ShiftsLeft.ToString() + " more shifts\r\n";
            }
            report += "Total honey cost:" + totalCost+"\r\n";
           
            return report;
        }

        public override double GetHoneyConsumption()//计算蜂王的蜂蜜消耗量
        {
            double honey = 0;
            double number = 0;//工作的工蜂数量
            for (int i = 0; i < workers.Length; i++)
            {
                if (honey < workers[i].GetHoneyConsumption())
                    honey = workers[i].GetHoneyConsumption();
                if (workers[i].ShiftsLeft > 0)
                    number += 1;
            }
            if (number <= 2)
                honey += 20;
            else
                honey += 30;
            return honey;
        }


    }
}
