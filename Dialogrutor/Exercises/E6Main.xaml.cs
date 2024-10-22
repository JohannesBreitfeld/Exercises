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
    /// Interaction logic for E6.xaml
    /// </summary>
    public partial class E6Main : Window
    {
        public SolidColorBrush Color { get; set; }
        public E6Main()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Sender = sender as Rectangle;
            E6Dialog dialogWindow = new(Sender.Fill);

            if (dialogWindow.ShowDialog() == true)
            {
                Sender.Fill = dialogWindow.Color;
            }
        }
    }
}
