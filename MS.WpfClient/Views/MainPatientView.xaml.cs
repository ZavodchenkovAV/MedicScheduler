﻿using System;
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
using MS.WpfClient.Models;

namespace MS.WpfClient.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainPatientView : Window
    {
        public MainPatientView()
        {
            InitializeComponent();
        }

        private void MainPatientView_OnLoaded(object sender, RoutedEventArgs e)
        {
            var model = DataContext as MainPatientViewModel;
            model.InitRunTime();
        }
    }
}