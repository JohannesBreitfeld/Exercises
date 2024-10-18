using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Dialogrutor.Exercises
{
    /// <summary>
    /// Interaction logic for E3.xaml
    /// </summary>
    public partial class E3 : Window
    {
        public E3()
        {
            InitializeComponent();
        }

        private void MenuClickOpen(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Textfiler (*.txt)|*.txt|Alla filer (*.*)|*.*"
            };
            var result = dialog.ShowDialog();
       
            if (result == true)
            {
                textBox.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void MenuClickExit(object sender, RoutedEventArgs e)
        {
            WindowE3.Close();
        }
    }
}
