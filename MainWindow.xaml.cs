using System;
using System.Collections;
using System.Windows;

namespace WpfApp8
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

        ArrayList people = new ArrayList();

        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = tbName.Text,
                   secondName = tbSecondName.Text;
                int age = int.Parse(tbAge.Text);
                int numberOfChildren = int.Parse(tbNumberOfChildren.Text);

                if (numberOfChildren > 0)
                {
                    StudentFather studenFather = new StudentFather(name, age, secondName, numberOfChildren);
                    people.Add(studenFather);
                }
                else
                {
                    Student student = new Student(name, age, secondName);
                    people.Add(student);
                }

                tbResult.Text = string.Empty;

                foreach (var item in people)
                {
                    if (item is Student)
                    {
                        tbResult.Text += ((Student)item).ShowInfo();
                    }
                    else
                    {
                        tbResult.Text += ((StudentFather)item).ShowInfo();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не указаны все данные или неверный формат данных");
            }
        }

        private void ButtonCompare(object sender, RoutedEventArgs e)
        {
            try
            {
                int firstStudent = int.Parse(tbFirstStudent.Text);
                int secondStudent = int.Parse(tbSecondStudent.Text);

                if (people[firstStudent - 1] is Student student) //проверка студент или нет
                {
                    if (student.CompareTo(people[secondStudent - 1]) == 1)
                    {
                        tbResult.Text += "Первый cтудент круче второго\n";
                    }
                    else if (student.CompareTo(people[secondStudent - 1]) == -1)
                    {
                        tbResult.Text += "Второй студент круче первого\n";
                    }
                    else
                    {
                        tbResult.Text += "Студенты равны по крутости\n";
                    }
                }
                else
                {
                    StudentFather studentFather = (StudentFather)people[firstStudent - 1];
                    if (studentFather.CompareTo(people[secondStudent - 1]) == 1)
                    {
                        tbResult.Text += "Первый cтудент круче второго\n";
                    }
                    else if (studentFather.CompareTo(people[secondStudent - 1]) == -1)
                    {
                        tbResult.Text += "Второй студент круче первого\n";
                    }
                    else
                    {
                        tbResult.Text += "Студенты равны по крутости\n";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные указаны не верно или объект не создан");
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Крутолапов Валерий Исп-31 Вариант - 1");
        }
    }
}
