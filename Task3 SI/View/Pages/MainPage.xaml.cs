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
using Task3_SI.View.Pages.TaskPages;
using static Task3_SI.Core.Core;

namespace Task3_SI.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BTN1_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task1());
        }

        private void BTN2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN11_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Randomaiser());
        }
    }
}
