using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht_04
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            button0.Click += button;
            button1.Click += button;
            button2.Click += button;
            button3.Click += button;
            button4.Click += button;
            button5.Click += button;
            button6.Click += button;
            button7.Click += button;
            button8.Click += button;
            button9.Click += button;
        }
        

        bool i = false;
                    
        private void button(object sender, RoutedEventArgs e)
        {
            if (i == false)
            {
                lukutextBox.Text = "";
            }
            string buttonString = (((Button)sender).Content).ToString();
            lukutextBox.Text += buttonString;
            i = true;
        }

        private void buttonremove_Click(object sender, RoutedEventArgs e)
        {
            string line = lukutextBox.Text;
            if (line.Length > 1)
            {
                line = line.Substring(0, line.Length - 1);
                lukutextBox.Text = line;
            }
            else
            {
                lukutextBox.Text = "0";
                i = false;
            }
        }

        private void buttonok_Click(object sender, RoutedEventArgs e)
        {            
            kiuas setting = new kiuas();
            if ((bool)radioButtonTemp.IsChecked)
            {
                try
                {
                    setting.Temperature = double.Parse(lukutextBox.Text);
                    textBlock2.Text = setting.Temperature.ToString();
                    if (setting.Temperature == 0)
                    {
                        textBlock4.Text = "Info: Syöttämäsi arvo on liian suuri.";
                    }
                }
                catch
                {
                    textBlock4.Text = "Info: Arvo ei ole numero!";
                }
                finally
                {                    
                }                            
            }

            if ((bool)radioButtonHum.IsChecked)
            {
                try
                {
                    setting.Humidity = double.Parse(lukutextBox.Text);
                    textBlock3.Text = setting.Humidity.ToString();
                    if (setting.Humidity == 0) textBlock4.Text = "Info: Syöttämäsi arvo on liian suuri.";
                }
                catch
                {
                    textBlock4.Text = "Info: Arvo ei ole numero!";
                }
                finally
                {
                }                
            }
            lukutextBox.Text = "0";
            i = false;

        }

        private void buttondot_Click(object sender, RoutedEventArgs e)
        {
            lukutextBox.Text += ".";
            i = true;
        }
    }
}
