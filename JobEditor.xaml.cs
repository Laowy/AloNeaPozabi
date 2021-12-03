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
using System.Windows.Shapes;

namespace AloNeaPozabi
{
    /// <summary>
    /// Interaction logic for JobEditor.xaml
    /// </summary>
    public partial class JobEditor : Window
    {
        public JobEditor(bool isdone, DateTime deadline, string name)
        {
            InitializeComponent();
            DatePickerDueDate.DisplayDate = deadline;
            CheckboxIsCompleted.IsChecked = isdone;
            TextBoxJobName.Text = name;
        }

        public JobEditor()
        {
            InitializeComponent();
        }

        public string TaskName {
            get { return TextBoxJobName.Text; }
            set { TextBoxJobName.Text = value; }
        }

        public bool IsCompleted {
            get { return (bool)CheckboxIsCompleted.IsChecked; }
            set { CheckboxIsCompleted.IsChecked = value; }
        }

        public DateTime Deadline {
            get { return DatePickerDueDate.DisplayDate; }
            set { DatePickerDueDate.DisplayDate = value; }
        }

        private void ButtonUpdateTask_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}