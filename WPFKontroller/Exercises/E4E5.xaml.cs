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

namespace WPFKontroller.Excercises
{
    /// <summary>
    /// Interaction logic for E4E5.xaml
    /// </summary>
    public partial class E4E5 : Window
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public E4E5()
        {
            InitializeComponent();
            labelXY.Content = $"X: {X}, Y: {Y}";
            Update();
        }

        private void Update()
        {
            Canvas.SetLeft(labelXY, X);
            Canvas.SetBottom(labelXY, Y);
        }

        private void sliderPosition_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (checkBoxXLock.IsChecked == true)
            {
                X = (int)sliderPosition.Value;
            }
            else if (checkBoxYLock.IsChecked == true)
            {
                Y = (int)sliderPosition.Value;
            }
            labelXY.Content = $"X: {X}, Y: {Y}";
            Update();
        }

        private void checkBoxXLock_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBoxYLock?.IsChecked == true)
            {
                checkBoxYLock.IsChecked = false;
            }
            sliderPosition.Value = X;
            labelPosition.Content = "X-position";
        }

        private void checkBoxYLock_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBoxXLock?.IsChecked == true)
            {
                checkBoxXLock.IsChecked = false;
            }
            labelPosition.Content = "Y-position";
            sliderPosition.Value = Y;
        }




        //X = (int)sliderXPosition.Value;
        //Y = (int)sliderYPosition.Value;
        //private void sliderXPosition_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    X = (int)sliderXPosition.Value;
        //    labelXY.Content = $" X: {X}, Y: {Y}";
        //    Canvas.SetLeft(labelXY, X);
        //}

        //private void sliderYPosition_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    Y = (int)sliderYPosition.Value;
        //    labelXY.Content = $" X: {X}, Y: {Y}";
        //    Canvas.SetBottom(labelXY, Y);
        //}
    }
}
