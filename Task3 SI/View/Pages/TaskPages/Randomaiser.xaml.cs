using System;
using System.Windows;
using System.Windows.Controls;
using static Task3_SI.Core.Core;

namespace Task3_SI.View.Pages.TaskPages
{
    public partial class Randomaiser : Page
    {
        public Randomaiser()
        {
            InitializeComponent();
        }

        private void BTNR_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int a = r.Next(1, 13);
            if (a == 1)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Алина", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 2)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Лаура", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 3)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Дима Н.", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 4)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Катя", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 5)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Дима П.", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 6)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Саша П.", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 7)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Илья", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 8)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Игорь", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 9)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Саша Ш.", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 10)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Женя", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 11)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Максим", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            if (a == 12)
            {
                try
                {
                    MessageBox.Show("Неудачник дня - Паша", "Неудачник",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new MainPage());
        }
    }
}
