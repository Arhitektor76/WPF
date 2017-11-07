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
using System.Windows.Shapes;
//using Microsoft.Windows.Controls;


namespace WpWeek3
{
    /// <summary>
    /// Логика взаимодействия для Tuning.xaml
    /// </summary>
    public partial class Tuning : Window
    {
        public Tuning()
        {
            InitializeComponent();
        }

        private void Button_Click_Open(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
            }
        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = (DateTime)Calendar.SelectedDate;
            Cal_date.Text = selectedDate.ToString("d MMM yyyy");
        }

        private void Button_Click_Date(object sender, RoutedEventArgs e)
        {
            DateText.Text = "Сегодня: "+ System.DateTime.Now.ToShortDateString();
            Cal_date.Text = System.DateTime.Now.ToShortDateString();
        }
    }
}
