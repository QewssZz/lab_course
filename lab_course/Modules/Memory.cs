using System.ComponentModel;

namespace lab_course
{
    class Memory : INotifyPropertyChanged
    {

        public long Size { get; private set; }
        private long occupiedSize;
        public long OccupiedSize
        {
            get { return occupiedSize; }
            set { occupiedSize = value; OnPropertyChanged(); }
        }
        public long FreeSize
        {
            get { return Size - OccupiedSize; }
            private set { Size = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("OccupiedSize"));
            }
        }
        public void Save(long size)
        {
            FreeSize = Size = size;
            OccupiedSize = 0;
        }
        public void Clear()
        {
            OccupiedSize = 0;
        }
    }
}
