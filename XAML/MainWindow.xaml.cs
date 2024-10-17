using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            listBox.Items.Add(new Student("Kalle", "Andersson"));
            listBox.Items.Add(new Student("Anders", "Karlsson"));
            listBox.Items.Add(new Student("Camilla", "Johansson"));
            listBox.Items.Add(new Student("Johan", "Svensson"));
            listBox.Items.Add(new Student("Mia", "Karlsson"));
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem is Student student)
            {
                textBoxFirstname.Text = student.FirstName;
                textBoxLastname.Text = student.LastName;
                textBoxEmail.Text = student.Email;
            }
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = $"{firstName}@gmail.com";
        }
        public override string ToString()
        {
            return $"{FirstName} { LastName}";
        }
    }
}