using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloNeaPozabi
{
    internal class Checklist
    {
        private List<Job> tasklist;

        public List<Job> TaskList {
            get {
                return tasklist;
            }
            set {
                tasklist = value;
                OnPropertyChanged("TaskList");
            }
        }

        public void AddTask(Job job)
        {
            tasklist.Add(job);
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