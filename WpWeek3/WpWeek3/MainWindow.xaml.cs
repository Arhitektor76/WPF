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

namespace WpWeek3
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

        private void MenuItem_Click_add(object sender, RoutedEventArgs e)
        {
            Tuning tuning = new Tuning();
            tuning.ShowDialog();
        }

        private void MenuItem_Click_delete(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_update(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_clear(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_exit(object sender, RoutedEventArgs e)
        {

        }
    }
}
