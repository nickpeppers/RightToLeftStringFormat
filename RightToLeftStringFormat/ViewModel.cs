using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace RightToLeftStringFormat
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string _stringFormat1 = string.Format("{0} | {1}", nameof(StringFormat1), DateTime.Today.ToString("dd MMM yyyy", CultureInfo.CurrentCulture)).ToUpper();

        public string StringFormat1
        {
            get { return _stringFormat1; }
            set 
            {
                _stringFormat1 = value;
                OnPropertyChanged(nameof(StringFormat1));
            }
        }

        string _stringFormat2 = string.Format("{0} | {1}", nameof(StringFormat2), DateTime.Now.ToString("dd MMM yyyy", CultureInfo.CurrentCulture)).ToUpper();

        public string StringFormat2
        {
            get { return _stringFormat2; }
            set
            {
                _stringFormat2 = value;
                OnPropertyChanged(nameof(StringFormat2));
            }
        }

        string _stringFormat3 = string.Format("{0} | {1}", nameof(StringFormat3), DateTime.UtcNow.ToString("dd MMM yyyy", CultureInfo.CurrentCulture)).ToUpper();

        public string StringFormat3
        {
            get { return _stringFormat3; }
            set
            {
                _stringFormat3 = value;
                OnPropertyChanged(nameof(StringFormat3));
            }
        }


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
