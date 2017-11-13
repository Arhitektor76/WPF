using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


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
                Fulfill.Text  = dlg.FileName;
            }
        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Cal_date.Text = ((DateTime)Calendar.SelectedDate).ToString("d MMM yyyy");
        }

        private void Button_Click_Date(object sender, RoutedEventArgs e)
        {
            DateText.Text = "Сегодня: "+ System.DateTime.Now.ToShortDateString();
            Cal_date.Text = System.DateTime.Now.ToShortDateString();
            Calendar.SelectedDate = DateTime.Now;
        }

        private void DropDownClosedTime(object sender, EventArgs e)
        {
            ComboTime.Text = ((DateTime)Time.DateTimeValue).ToString("T");
        }

        private void DropDownClosedCalendar(object sender, EventArgs e)
        {
            Cal_date.Text = ((DateTime)Calendar.SelectedDate).ToString("dd MMMM yyyy");
        }

        private void Period_DropDownClosed(object sender, EventArgs e)
        {

            CheckBoxWeek.IsEnabled = Period.Text == "Еженедельно"? true: false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if(Fulfill.Text !="")
            {
                MessageBox.Show("Задание добавлено");
            }
            else
            {
                MessageBox.Show("Задание не добавлено. Требуется заполнить все поля");
            }
            
            this.Close();
        }
    }
}
