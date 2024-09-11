using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Task_Maneger
{
    public partial class BlackListWindow : Window
    {
        private ObservableCollection<Process> blackList;

        ObservableCollection<Process> BlackList { get => blackList; set { blackList = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public BlackListWindow(ObservableCollection<Process> blackList)
        {
            InitializeComponent();
            this.BlackList = blackList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ProcessDetailsDataGrid.SelectedItem != null)
            {
                BlackList.Remove(ProcessDetailsDataGrid.SelectedItem as Process);
            }
        }
    }
}
