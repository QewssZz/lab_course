using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;
using System.ComponentModel;

namespace lab_course
{
    class SystemClock : INotifyPropertyChanged
    {
        private long clock;
        public event PropertyChangedEventHandler PropertyChanged;
        public long Clock
        {
            get
            {
                return clock;
            }
            private set
            {
                clock = value; OnPropertyChanged();
            }
        }

        private void OnPropertyChanged()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Clock"));
            }
        }

        public void WorkingCycle()
        {
            Clock++;
        }
        public void Clear()
        {
            Clock = 0;
        }
    }
}
