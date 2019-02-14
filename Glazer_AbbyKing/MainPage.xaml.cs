using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Glazer_AbbyKing
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            double width = 0;
            double height = 0;
            double slide;

            // checked if width is a number
            if(double.TryParse(txtWidth.Text, out double number)){
                width = double.Parse(txtWidth.Text);
            } else {
                txtWidth.BorderBrush = new SolidColorBrush(Colors.Red);
                txtWidth.Text = "Please enter a number.";
            };

            // checked if height is a number
            if (double.TryParse(txtHeight.Text, out double number2))
            {
                height = double.Parse(txtHeight.Text);
            }
            else
            {
                txtHeight.BorderBrush = new SolidColorBrush(Colors.Red);
                txtHeight.Text = "Please enter a number.";
            };

            slide = double.Parse(txtSlider.Text);

            // only calculate if values other than 0 are entered
            if (!(width == 0 && height == 0 && slide == 0))
            {
                txtLength.Text = (2 * (width + height) * 3.25 * slide).ToString();
                txtArea.Text = (2 * (width + height) * slide).ToString();
                txtDate.Text = (System.DateTime.Now).ToString();
            } else
            {
                txtWidth.BorderBrush = new SolidColorBrush(Colors.Red);
                txtHeight.BorderBrush = new SolidColorBrush(Colors.Red);
                txtSlider.BorderBrush = new SolidColorBrush(Colors.Red);
                txtError.Text = "All fields must have a value. Please try again.";
            }

        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            txtSlider.Text = ((Slider)sender).Value.ToString();
        }
    }
}
