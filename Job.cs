using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AloNeaPozabi
{
    internal class Job : INotifyPropertyChanged
    {
        private string imeOpravila;

        public string JobName
        {
            get
            {
                return imeOpravila;
            }
            set
            {
                imeOpravila = value;
                OnPropertyChanged("JobName");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion INotifyPropertyChanged Members
    }
}