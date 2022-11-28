namespace lab_course
{
    class MemoryManager
    {
        private Memory memory;

        public void Save(Memory memory)
        {
            this.memory = memory;
        }

        public Memory Allocate(Process process)
        {
            if (memory.FreeSize >= process.AddrSpace)
            {
                memory.OccupiedSize += process.AddrSpace;
                return memory;
            }
            return null;
        }
        public Memory Free(Process process)
        {
            memory.OccupiedSize -= process.AddrSpace;
            return memory;
        }
    }
}
