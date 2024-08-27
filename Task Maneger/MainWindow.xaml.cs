using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Task_Maneger
{

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private DispatcherTimer _timer;
        private ObservableCollection<Process> programs;

        public Process process { get; set; } = new();

        public ObservableCollection<Process> Programs { get => programs; set { programs = value; OnPropertyChanged(); } }

        #region OnPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion



        private void StartAutoRefresh()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(5);
            _timer.Tick += (sender, e) => Programs = new(Process.GetProcesses().ToList());
            _timer.Start();
        }
        public MainWindow()
        {

            InitializeComponent();
            DataContext = this;
            StartAutoRefresh();
            Programs = new(Process.GetProcesses().ToList());

            DispatcherTimer timer = new DispatcherTimer();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ProcessDetailsDataGrid.SelectedItem != null)
            {
                int id = -1;
                var a = ProcessDetailsDataGrid.SelectedItem as Process;
                foreach (var item in Programs)
                {
                    if(item == a)
                    {
                       id = item.Id;
                    }
                }
                Process.GetProcessById(id).Kill();
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = new RunNewTaskWindow();
            a.ShowDialog();
        }
    }
}