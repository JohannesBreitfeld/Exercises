using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFKontroller.Exercises
{
    /// <summary>
    /// Interaction logic for E7.xaml
    /// </summary>
    public partial class E7 : Window
    {
        private ObservableCollection<Student> students;

        public E7()
        {
            InitializeComponent();

            students = new ObservableCollection<Student>
            {
                new Student("Kalle", "Andersson"),
                new Student("Anders", "Karlsson"),
                new Student("Camilla", "Johansson"),
                new Student("Johan", "Svensson"),
                new Student("Mia", "Karlsson")
            };

            listBox.ItemsSource = students;
            listBox.DisplayMemberPath = "FullName";
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem is Student student)
            {
                textBoxFirstname.Text = student.FirstName;
                textBoxLastname.Text = student.LastName;
                textBoxEmail.Text = student.Email;
            }
            else
            {
                textBoxFirstname.Text = string.Empty;
                textBoxLastname.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
            }
            
            buttonRemove.IsEnabled = listBox.SelectedItems.Count > 0;
        }

        private void textBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (listBox.SelectedItem is Student student)
            {
                student.Email = textBoxEmail.Text;
            }
        }
        private void textBoxLastname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (listBox.SelectedItem is Student student)
            {
                student.LastName = textBoxLastname.Text;
            }
        }

        private void textBoxFirstname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (listBox.SelectedItem is Student student)
            {
                student.FirstName = textBoxFirstname.Text;
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new Student());
        }

        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem is Student student)
            {
                students.Remove(student);
            }
        }
    }
}
