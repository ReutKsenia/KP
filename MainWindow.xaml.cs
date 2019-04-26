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

namespace senia1._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DateTime aDate = DateTime.Now;
            TodayNumber.Content = aDate.ToString("dd");
        }

        private void MainWindow1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow1.Close();
        }

        private void MaximizedState_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow1.WindowState == WindowState.Maximized)
            {
                MainWindow1.WindowState = WindowState.Normal;
            }
            else if(MainWindow1.WindowState == WindowState.Normal)
            {
                MainWindow1.WindowState = WindowState.Maximized;
            }
        }

        private void Rollup_Click(object sender, RoutedEventArgs e)
        {
            MainWindow1.WindowState = WindowState.Minimized;
        }

        private void NextSevenDays_Click(object sender, RoutedEventArgs e)
        {
            NextDays.Visibility = Visibility.Visible;
            TodayControl.Visibility = Visibility.Hidden;
        }

        private void Today_Click_1(object sender, RoutedEventArgs e)
        {
            TodayControl.Visibility = Visibility.Visible;
            NextDays.Visibility = Visibility.Hidden;
        }

    }
}
