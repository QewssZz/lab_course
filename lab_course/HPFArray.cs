using System;
using System.Windows.Forms;
using Queues;
using Structures;

namespace lab_course
{
    class HPFArray
    {
        private IQueueable<Process>[] Queues;
        private int FirstNotEmpty;
        private int QueuesCount;
        public int Count
        {
            get;
            private set;
        }
        public void Save(int quantity)
        {
            QueuesCount = quantity;
            Queues = new IQueueable<Process>[QueuesCount];
            for (int i = 0; i < QueuesCount; i++)
            {
                Queues[i] = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            }
            FirstNotEmpty = Int32.MaxValue;
        }

        public HPFArray Put(Process p)
        {
            Queues[p.Priority - 1].Put(p);
            Count++;
            if (p.Priority - 1 < FirstNotEmpty)
            {
                FirstNotEmpty = p.Priority - 1;
            }
            return this;
        }
        public HPFArray Remove()
        {
            Queues[FirstNotEmpty].Remove();
            while (FirstNotEmpty + 1 < QueuesCount && Queues[FirstNotEmpty].Count == 0)
            {
                FirstNotEmpty++;
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
            Count = 0;
            FirstNotEmpty = Int32.MaxValue;
            return this;
        }

        public ListBox.ObjectCollection ToArray()
        {
            ListBox.ObjectCollection result = new ListBox.ObjectCollection(new ListBox());
            for (int i = 0; i < QueuesCount; i++)
            {
                result.AddRange(Queues[i].ToArray());
            }
            return result;
        }
    }
}

