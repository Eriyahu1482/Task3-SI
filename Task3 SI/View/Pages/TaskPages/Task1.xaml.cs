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
using static Task3_SI.Core.Core;

namespace Task3_SI.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Page
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new MainPage());
        }

        private void BTN_Answer_Click(object sender, RoutedEventArgs e)
        {
            bool A = true, B = false, C = false, R= (A && !A || B) && C, D = !A&&A||(B&&C), V = (A&&B||!C)||C ;
            int r = 0, d = 0, v = 0;
            try
            {
                if (R == true) { r = 1; }
                if (R == false) { r = 0; }
                if (D == true) { d = 1; }
                if (D == false) { d = 0; }
                if (V == true) { v = 1; }
                if (V == false) { v = 0; }
                MessageBox.Show($"а) {r} б) {d} в) {v} ", "задание 1",
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
}
