namespace lab_course
{
    class CPUScheduler
    {
        private Resource resource;
        private HPFArray queue;

        public CPUScheduler(Resource resource, HPFArray queue)
        {
            this.resource = resource;
            this.queue = queue;
        }
        public HPFArray Session()
        {
            if (queue.Count == 0)
            {
                return queue;
            }
            Process newActiveProcess = queue.Item();
            newActiveProcess.Status = ProcessStatus.running;
            queue.Remove();
            resource.ActiveProcess = newActiveProcess;
            return queue;
        }
    }
}