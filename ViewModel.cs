using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AloNeaPozabi
{
    internal class ViewModel
    {
        public List<Checklist> ListList {
            get => listList;
            set {
                listList = value; OnPropertyChanged("ListList");
            }
        }

        public Job ActiveTask {
            get => activeTask;
            set {
                activeTask = value; OnPropertyChanged("ActiveTask");
            }
        }

        public List<Job> ActiveList {
            get => activeList;
            set {
                activeList = value; OnPropertyChanged("ActiveList");
            }
        }

        private Job activeTask;
        private List<Job> activeList;
        private List<Job> taskList;
        private List<Checklist> listList;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private class Updater : ICommand
        {
            #region ICommand Members

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
            }

            #endregion ICommand Members
        }
    }
}