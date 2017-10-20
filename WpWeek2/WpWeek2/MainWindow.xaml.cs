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

namespace WpWeek2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentList SL;
        public MainWindow()
        {
            SL = new StudentList();
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.Closing += MainWindow_Closing;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }
        private void ListBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            Student st = new Student();
            st.FirstName = FName.Text;
            st.LastName = LName.Text;
            st.Patronymic = Patr.Text;
            st.Marital_status = MSatus.Text;
            st.Age = Age.Text;
            st.Address = Address.Text;
            st.Email = Email.Text;

            st.Hi_education = (bool)HiEd.IsChecked;
            st.PC_skills = (bool)PcSkills.IsChecked;
            st.Language_skills = (bool)LangSkills.IsChecked;
            st.Inform_technologies = (bool)Inform.IsChecked;

            ListStud.Items.Add(FName.Text + " " + LName.Text);
            SL.Stud_List.Add(st);

            LoopVisualTree(this);
        }
        private void LoopVisualTree(DependencyObject obj)//обнуление текст боксов
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {

                if (obj is TextBox)
                {
                    ((TextBox)obj).Text = null;
                }
                // РЕКУРСИЯ
                LoopVisualTree(VisualTreeHelper.GetChild(obj, i));
            }

        }
    }
}
