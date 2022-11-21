using System;
using System.Collections.Generic;
using System.Text;

namespace lab_course
{
    class Settings
    {
        public double Intensity { get; set; }
        public int MinValueOfBurstTime { get; set; }
        public int MaxValueOfBurstTime { get; set; }
        public int MinValueOfAddrSpace { get; set; }
        public int MaxValueOfAddrSpace { get; set; }
        public int ValueOfRAMSize { get; set; }
        public int LowPriority { get; set; }
    }
}
