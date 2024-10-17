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

namespace WPFKontroller.Excercises
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public int ClickCounter { get; set; } = 5;

        public UserControl2()
        {
            InitializeComponent();
            labelCounter.Content = ClickCounter;
            sliderCounter.Value = ClickCounter;
        }


        private void buttonDecrease_Click(object sender, RoutedEventArgs e)
        {
            if (ClickCounter > 0)
            {
                --ClickCounter;
            }
            Update();
        }

        private void buttonIncrease_Click(object sender, RoutedEventArgs e)
        {
            if (ClickCounter < 9)
            {
                ++ClickCounter;
            }
            Update();
        }

        private void sliderCounter_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ClickCounter = (int)sliderCounter.Value;
            Update();
        }

        private void Update()
        {
            labelCounter.Content = ClickCounter;
            sliderCounter.Value = ClickCounter;
        }

    }
}
