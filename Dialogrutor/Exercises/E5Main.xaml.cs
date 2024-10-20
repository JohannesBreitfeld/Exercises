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

namespace Dialogrutor.Exercises
{
    /// <summary>
    /// Interaction logic for E5Main.xaml
    /// </summary>
    public partial class E5Main : Window
    {
        public SolidColorBrush Color { get; set; }
        public E5Main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            E5Dialog dialogWindow = new(Color);  
           
            if (dialogWindow.ShowDialog() == true)
            {
                Color = dialogWindow.Color;
            }
        }
    }
}
