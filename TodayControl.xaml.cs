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
using System.Globalization;

namespace senia1._0
{
    /// <summary>
    /// Логика взаимодействия для TodayControl.xaml
    /// </summary>
    public partial class TodayControl : UserControl
    {
        public TodayControl()
        {
            InitializeComponent();
        }

        private void L2_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime aDate = DateTime.Now;
            l2.Content = aDate.ToString("dddd, d MMMM yyyy г.", CultureInfo.GetCultureInfo("ru-ru"));
        }
    }
}
