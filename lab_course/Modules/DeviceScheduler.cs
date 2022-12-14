using Queues;

namespace lab_course
{
    class DeviceScheduler
    {
        private Resource resource;
        private IQueueable<Process> queue;

        public DeviceScheduler(Resource resource, IQueueable<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }
        public IQueueable<Process> Session()
        {
            if (queue.Count == 0)
            {
                return queue;
            }
            Process newActiveProcess = queue.Item();
            queue.Remove();
            resource.ActiveProcess = newActiveProcess;
            return queue;
        }
    }
}

