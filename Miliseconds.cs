using System.ComponentModel;

namespace pKami.SimpleTimer
{
    class Miliseconds : INotifyPropertyChanged
    {
        private double _miliseconds;
        public double Value
        {
            get { return _miliseconds; }
            set
            {
                if (value != _miliseconds)
                {
                    _miliseconds = value;
                    OnPropertyChanged("Value");
                }
            }
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
