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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel VM;

        public MainWindow()
        {
            InitializeComponent();
            VM = new ViewModel();
            this.DataContext = VM;
            Checklist seznam1 = new Checklist();
            seznam1.AddTask(new Job("ime1", new DateTime(), true));
            seznam1.AddTask(new Job("ime2", new DateTime(), false));
            seznam1.AddTask(new Job("ime3", new DateTime(), true));
            seznam1.AddTask(new Job("ime4", new DateTime(), false));

            Checklist seznam2 = new Checklist();
            seznam2.AddTask(new Job("ime5", new DateTime(), true));
            seznam2.AddTask(new Job("ime6", new DateTime(), false));
            seznam2.AddTask(new Job("ime7", new DateTime(), true));
            seznam2.AddTask(new Job("ime8", new DateTime(), false));

            Checklist seznam3 = new Checklist();
            seznam3.AddTask(new Job("ime9", new DateTime(), true));
            seznam3.AddTask(new Job("ime10", new DateTime(), false));
        }

        private void ButtonAddTask_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}