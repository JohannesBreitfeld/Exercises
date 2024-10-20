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
    /// Interaction logic for E5Dialog.xaml
    /// </summary>
    public partial class E5Dialog : Window
    {
        public SolidColorBrush Color { get; set; }
        public E5Dialog(SolidColorBrush color)
        {
            InitializeComponent();
            if (color != null)
            {
                sliderRed.Value = color.Color.R;
                sliderGreen.Value = color.Color.G;
                sliderBlue.Value = color.Color.B;
                UpdateColorDisplay();
            }
        }

        private void colorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateColorDisplay();
           
        }

        private void UpdateColorDisplay()
        {
            Color color = new Color { A = 255, R = (byte)sliderRed.Value, G = (byte)sliderGreen.Value, B = (byte)sliderBlue.Value };
            Color = new SolidColorBrush(color);
            colorRectangel.Fill = Color;
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            Dialog.DialogResult = true;
            Close();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            Dialog.DialogResult = false;
            Close();
        }
    }
}
