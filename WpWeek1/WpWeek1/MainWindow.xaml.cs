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

namespace WpWeek1
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
            Button but = e.Source as Button; 
            if (Shyfr.Text.Length <6)
            {

                Shyfr.Text += but.Content.ToString();
            }         
            else
            {
                MessageBox.Show("Code completion is complete!");
            }
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            Shyfr.Text = "";
        }

        private void Button_Click_ok(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Safe opened!");
        }
    }
}
