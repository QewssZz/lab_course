using System;
using System.Collections.Generic;
using System.Text;
using Queues;

namespace lab_course
{
    class CPUScheduler
    {
        private Resource resource;
        private HPFArray queue;

        public CPUScheduler(Resource resource, HPFArray queue)//IQueueable<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }
        public HPFArray Session()
        {
            // только для епустой очереди
            Process newActiveProcess = queue.Item();
            newActiveProcess.Status = ProcessStatus.running;
            queue.Remove();
            resource.ActiveProcess = newActiveProcess;
            return queue;
        }
    }
}
