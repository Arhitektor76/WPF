using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;

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
            try
            {
                FileStream fs = new FileStream("Students.bin", FileMode.Open, FileAccess.Read);
                // Создаем двоичный поток для чтения
                BinaryReader br = new BinaryReader(fs, Encoding.Default);

                // Читаем данные                        
                SL = StudentList.Read(br);
                // Закрываем потоки
                br.Close();
                fs.Close();
                foreach (Student st in SL.Stud_List)
                {
                    ListStud.Items.Add(st.FirstName + " " + st.LastName);
                }
            }
            catch { }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("Students.bin",
                        FileMode.Create, FileAccess.Write);
                // Создаем двоичный поток для записи
                BinaryWriter bw = new BinaryWriter(fs, Encoding.Default);
                // Пишем данные                   
                SL.Write(bw);
                // Закрываем потоки
                bw.Close();
                fs.Close();
            }
            catch { }
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
            if (FName.Text != "" && LName.Text != "")
            {
                ListStud.Items.Add(FName.Text + " " + LName.Text);
                SL.Stud_List.Add(st);
                LoopVisualTree(this);
            }
            else
                MessageBox.Show("Введены неполные данные.");

        }
        private void LoopVisualTree(DependencyObject obj)//обнуление текст боксов
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {

                if (obj is TextBox)
                {
                    ((TextBox)obj).Text = null;
                }
                else if (obj is CheckBox)
                {
                    ((CheckBox)obj).IsChecked = false;
                }
                // РЕКУРСИЯ
                LoopVisualTree(VisualTreeHelper.GetChild(obj, i));
            }
        }

        private void Button_Click_CANCEL(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_IGNORE(object sender, RoutedEventArgs e)
        {
            LoopVisualTree(this);
        }

        private void ListStud_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListStud.SelectedItem != null)
            {
                int index = ListStud.SelectedIndex;

                Student st = SL.Stud_List[index];
                FName.Text = st.FirstName;
                LName.Text = st.LastName;
                Patr.Text = st.Patronymic;
                MSatus.Text = st.Marital_status;
                Age.Text = st.Age;
                Address.Text = st.Address;
                Email.Text = st.Email;

                HiEd.IsChecked = st.Hi_education;
                PcSkills.IsChecked = st.PC_skills;
                LangSkills.IsChecked = st.Language_skills;
                Inform.IsChecked = st.Inform_technologies;
            }
        }
    }
}
