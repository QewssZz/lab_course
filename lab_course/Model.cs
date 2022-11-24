using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Queues;
using Structures;

namespace lab_course
{
    class Model : INotifyPropertyChanged
    {
        public readonly Statistics statistics;
        /*private*/
        public readonly SystemClock clock;
        //времено public для теста
        /*private*/
        public readonly Resource cpu;
        /*private*/
        public readonly Resource firstDevice;
        public readonly Resource secondDevice;
        public readonly Memory ram;
        private IdGenerator idGen;
        //времено public для теста 
        /*private*/
        //public IQueueable<Process> readyQueue; 
        public HPFArray readyQueue;
        public HPFArray ReadyQueue
        {
            get { return readyQueue; }
            set { readyQueue = value; OnPropertyChanged(); }
        }
        /*private*/
        public IQueueable<Process> firstDeviceQueue;
        public IQueueable<Process> FirstDeviceQueue
        {
            get { return firstDeviceQueue; }
            set { firstDeviceQueue = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> secondDeviceQueue;
        public IQueueable<Process> SecondDeviceQueue
        {
            get { return secondDeviceQueue; }
            set { secondDeviceQueue = value; OnPropertyChanged(); }
        }
        private CPUScheduler cpuScheduler;
        private MemoryManager memoryManager;
        private DeviceScheduler firstDeviceScheduler;
        private DeviceScheduler secondDeviceScheduler;
        private Random processRand;
        public Settings modelSettings;
        private Random rand = new Random();

        public Model()
        {
            statistics = new Statistics(clock);
            clock = new SystemClock();
            cpu = new Resource();
            firstDevice = new Resource();
            secondDevice = new Resource();
            ram = new Memory();
            idGen = new IdGenerator();
            readyQueue = new HPFArray();
            firstDeviceQueue = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            secondDeviceQueue = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            cpuScheduler = new CPUScheduler(cpu, readyQueue);
            memoryManager = new MemoryManager();
            firstDeviceScheduler = new DeviceScheduler(firstDevice, firstDeviceQueue);
            secondDeviceScheduler = new DeviceScheduler(secondDevice, secondDeviceQueue);
            processRand = new Random();
            modelSettings = new Settings();
        }

        public void SaveSettings()
        {
            ram.Save(modelSettings.ValueOfRAMSize);
            memoryManager.Save(ram);
            readyQueue.Save(modelSettings.LowPriority);
        }

        public void WorkingCycle()
        {
            clock.WorkingCycle();
            if (processRand.NextDouble() <= modelSettings.Intensity)
            {
                Process proc = new Process(idGen.Id,
                    processRand.Next(modelSettings.MinValueOfAddrSpace, modelSettings.MaxValueOfAddrSpace + 1),
                    processRand.Next(1, modelSettings.LowPriority + 1));
                if (memoryManager.Allocate(proc) != null)
                {
                    proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
                        modelSettings.MaxValueOfBurstTime + 1);
                    Subscribe(proc);
                    ReadyQueue = readyQueue.Put(proc);
                    if (cpu.IsFree())
                    {
                        ReadyQueue = cpuScheduler.Session();
                    }
                }
            }
            if (cpu.IsFree())
            {
                statistics.IncCPUFreeTime();
            }
            statistics.IncArrivalProcCount();
            cpu.WorkingCycle();
            firstDevice.WorkingCycle();
            secondDevice.WorkingCycle();
        }

        public void Clear()
        {
            clock.Clear();
            cpu.Clear();
            firstDevice.Clear();
            secondDevice.Clear();
            ram.Clear();
            ReadyQueue = readyQueue.Clear();
            FirstDeviceQueue = firstDeviceQueue.Clear();
            SecondDeviceQueue = secondDeviceQueue.Clear();
        }

        private void FreeingAResourceEventHandler(object sender, EventArgs e)
        {
            Process resourceFreeingProcess = sender as Process;

            switch (resourceFreeingProcess.Status)//p.Status) 
            {
                case ProcessStatus.terminated:
                    Unsubscribe(resourceFreeingProcess);
                    cpu.Clear();
                    memoryManager.Free(resourceFreeingProcess);
                    if (readyQueue.Count != 0)
                    {
                        putProcessOnResource(cpu);
                    }
                    statistics.IncTerminatedProcCount();
                    break;
                case ProcessStatus.waiting:
                    cpu.Clear();
                    if (readyQueue.Count != 0)
                    {
                        putProcessOnResource(cpu);
                    }
                    resourceFreeingProcess.ResetWorkTime();
                    resourceFreeingProcess.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                    //resourceFreeingProcess.BurstTime *= 10;
                    PutOnDeviceQueue(resourceFreeingProcess);
                    if (firstDevice.IsFree())
                    {
                        putProcessOnResource(firstDevice);
                    }
                    if (secondDevice.IsFree())
                    {
                        putProcessOnResource(secondDevice);
                    }
                    break;
                case ProcessStatus.ready:
                    if (resourceFreeingProcess == firstDevice.ActiveProcess)
                    {
                        firstDevice.Clear();
                        putProcessOnResource(firstDevice);
                    }
                    else
                    {
                        secondDevice.Clear();
                        putProcessOnResource(secondDevice);
                    }
                    resourceFreeingProcess.ResetWorkTime();
                    resourceFreeingProcess.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                    ReadyQueue = readyQueue.Put(resourceFreeingProcess);
                    if (cpu.IsFree())
                    {
                        putProcessOnResource(cpu);
                    }
                    break;
                default:
                    throw new Exception("Unknown process status.");
            }
        }

        private void PutOnDeviceQueue(Process resourceFreeingProcess)
        {
            if (Cost(firstDeviceQueue) <= Cost(secondDeviceQueue))
                FirstDeviceQueue = FirstDeviceQueue.Put(resourceFreeingProcess);
            else
                SecondDeviceQueue = SecondDeviceQueue.Put(resourceFreeingProcess);
        }

        private int Cost(IQueueable<Process> deviceQueue)
        {
            int[] priority = new int[modelSettings.LowPriority];
            foreach (var process in deviceQueue.ToArray())
            {
                priority[process.Priority - 1]++;
            }
            int result = 0;
            for (int i = 0; i < priority.Length; i++)
            {
                result += priority[i] * (int)Math.Pow(10, i);
            }
            return result;
        }

        private void putProcessOnResource(Resource resource)
        {
            if (resource == cpu)
            {
                ReadyQueue = cpuScheduler.Session();
            }
            else if (resource == firstDevice)
            {
                FirstDeviceQueue = firstDeviceScheduler.Session();
            }
            else
            {
                SecondDeviceQueue = secondDeviceScheduler.Session();
            }
        }
        private void Subscribe(Process p)
        {
            if (p != null)
            {
                p.FreeingAResource += FreeingAResourceEventHandler;
            }
        }
        private void Unsubscribe(Process p)
        {
            if (p != null)
            {
                p.FreeingAResource -= FreeingAResourceEventHandler;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
