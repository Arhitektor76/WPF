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

namespace WpWeek1_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result.Content = (Convert.ToDouble(a1.Text) * Convert.ToDouble(b2.Text) * Convert.ToDouble(c3.Text)+
                Convert.ToDouble(a3.Text) * Convert.ToDouble(b1.Text) * Convert.ToDouble(c2.Text)+
                Convert.ToDouble(a2.Text) * Convert.ToDouble(b3.Text) * Convert.ToDouble(c1.Text)-
                Convert.ToDouble(a3.Text) * Convert.ToDouble(b2.Text) * Convert.ToDouble(c1.Text)-
                Convert.ToDouble(a1.Text) * Convert.ToDouble(b3.Text) * Convert.ToDouble(c2.Text)-
                Convert.ToDouble(a2.Text) * Convert.ToDouble(b1.Text) * Convert.ToDouble(c3.Text)).ToString();
            }
            catch
            {
                Result.Content = "Некоректные значения";
            }
        }
    }
}
