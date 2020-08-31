using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Beehive
{
    class Queen
    {
        
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobToDo, int shiftsToWork)
        {
            foreach(Worker worker in workers)
            {
                if(worker.DoThisJob(jobToDo, shiftsToWork))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkNextShift()
        {
            shiftNumber++;
            string shiftReport = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                {
                    shiftReport += String.Format("Worker #{0} is not working\r\n", i + 1);
                }
                else
                {
                    if (workers[i].ShiftsLeft == 0)
                    {
                        shiftReport += String.Format("Worker #{0} finished the job\r\n", i+1);
                    }
                    else if(workers[i].ShiftsLeft == 1)
                    {
                        shiftReport += String.Format("Worker #{0} will be done with \"{1}\" after this shift\r\n", i+1, workers[i].CurrentJob);
                    }
                    else
                    {
                        shiftReport += String.Format("Worker #{0} is doing {1} for {2} more shifts\r\n",
                                                    i+1, workers[i].CurrentJob, workers[i].ShiftsLeft);
                    }
                }
            }
            shiftReport += "\r\n";
            return shiftReport;
        }

    }
}
