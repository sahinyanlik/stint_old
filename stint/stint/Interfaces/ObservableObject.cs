using System;
using System.Collections.Generic;
using System.Text;

namespace stint.Interfaces
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    

    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
