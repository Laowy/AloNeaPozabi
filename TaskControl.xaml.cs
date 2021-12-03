using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AloNeaPozabi
{
    /// <summary>
    /// Interaction logic for TaskControl.xaml
    /// </summary>
    public partial class TaskControl : UserControl
    {
        public TaskControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public TaskControl(string jName, DateTime dueDate, bool isdone)
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string JobName {
            get { return TextBlockJobName.Text; }
            set { TextBlockJobName.Text = value; }
        }

        public DateTime DueDate {
            get {
                string tmp = TextBlockDueDate.Text;
                return new DateTime(Convert.ToInt32(tmp.Substring(6, 4)), Convert.ToInt32(tmp.Substring(3, 2)), Convert.ToInt32(tmp.Substring(0, 2)));
            }//year month day input format
            set { TextBlockJobName.Text = value.ToString("dd.mm.yyyy"); }
        }

        public bool IsComplete {
            get { return (bool)CheckboxIsCompleted.IsChecked; }
            set { CheckboxIsCompleted.IsChecked = value; }
        }
    }
}