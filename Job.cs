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
        private bool isDone;
        private DateTime deadline;

        public bool IsDone {
            get => isDone;
            set {
                isDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        public Job(string jobName, DateTime deadline, bool isDone)
        {
            JobName = jobName;
            Deadline = deadline;
            IsDone = isDone;
        }

        public DateTime Deadline {
            get => deadline;
            set {
                deadline = value;
                OnPropertyChanged("Deadline");
            }
        }

        public string JobName {
            get {
                return imeOpravila;
            }
            set {
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