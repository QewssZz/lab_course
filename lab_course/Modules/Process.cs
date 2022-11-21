using System;
using System.Collections.Generic;
using System.Text;

namespace lab_course
{
    enum ProcessStatus { ready, running, waiting, terminated }
    class Process : IComparable<Process>// IComparable
    {
        private long id;
        private string name;
        public readonly int Priority;
        private long workTime;
        private Random rand = new Random();

        public event EventHandler FreeingAResource;

        private void OnFreeResource(object sender, EventArgs e)
        {
            if (FreeingAResource != null)
            {
                FreeingAResource(sender, e);
            }
        }
        public long BurstTime { get; set; }
        public ProcessStatus Status { get; set; }
        public long AddrSpace { get; }
        public Process(long pId, long addrSpace, int priority)
        {
            id = pId;
            name = "p" + id;
            AddrSpace = addrSpace;
            Status = ProcessStatus.ready;
            Priority = priority;
        }

        public void IncreaseWorkTime()
        {
            if (workTime < BurstTime)
            {
                workTime++;
                //return;
            }
            else
            {
                if (Status == ProcessStatus.running)
                {
                    Status = rand.Next(0, 2) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
                }
                else
                {
                    Status = ProcessStatus.ready;
                }
                OnFreeResource(this, null);
            }

        }
        public void ResetWorkTime()
        {
            workTime = 0;
        }
        public override string ToString()
        {
            return "ID: " + id +
                " Status: " + Status + 
                " Burst time: " + BurstTime +
                " Work time: " + workTime + 
                " Addr space: " + AddrSpace +  " ;";            
        }

       
        public int CompareTo(Process otherProc)
        {
            if (otherProc == null)
            {
                return 1;
            }
            return otherProc.Priority.CompareTo(Priority);
        }
    }
}
