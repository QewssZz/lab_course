using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;
using Structures;

namespace lab_course
{
    class HPFArray
    {
        IQueueable<Process>[] Queues;
        private int FirstNotEmpty;
        private int QueuesCount;
        public int Count
        {
            get;
            private set;
        }
        public HPFArray() { }
        public void Save(int quantity)
        {
            QueuesCount = quantity;
            Queues = new IQueueable<Process>[QueuesCount];
            for (int i = 0; i < QueuesCount; i++)
            {
                Queues[i] = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            }
        }

        public HPFArray Put(Process p)
        {
            if (p.Priority < FirstNotEmpty)
            {
                FirstNotEmpty = p.Priority;
            }
            Queues[p.Priority].Put(p);
            Count++;
            return this;
        }
        public HPFArray Remove()
        {
            Queues[FirstNotEmpty].Remove();
            if (Queues[FirstNotEmpty].Count == 0)
            {
                //FirstNotEmpty++;
                for (; FirstNotEmpty < QueuesCount && Queues[FirstNotEmpty].Count == 0; FirstNotEmpty++) ;
            }
            Count--;
            return this;
        }
        public Process Item()
        {
            return Queues[FirstNotEmpty].Item();
        }
        public HPFArray Clear()
        {
            for (int i = 0; i < QueuesCount; i++)
            {
                Queues[i].Clear();
            }
            return this;
        }
        //public string[] ToArray()
        //{

        //}
    }
}

