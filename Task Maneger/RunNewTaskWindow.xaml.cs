﻿using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Task_Maneger
{
    /// <summary>
    /// Interaction logic for RunNewTaskWindow.xaml
    /// </summary>
    public partial class RunNewTaskWindow : Window
    {
        public RunNewTaskWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(OpenTextBox.Text != string.Empty)
            {
                try
                {
                    Process.Start(OpenTextBox.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new();
            fileDialog.ShowDialog();
            OpenTextBox.Text = fileDialog.FileName;
        }
    }
}
