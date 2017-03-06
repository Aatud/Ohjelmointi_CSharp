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

namespace teht_02
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Car truck = new Car("Sisu");
        Car car = new Car("Lada");
        public MainPage()
        {
            this.InitializeComponent();
            truckButton.Content = truck.Name;
            carButton.Content = car.Name;
        }
        private void truckButton_Click(object sender, RoutedEventArgs e)
        {
            truck.Add();
            truckTextBlock.Text = truck.Count.ToString();
        }

        private void carButton_Click(object sender, RoutedEventArgs e)
        {
            car.Add();
            carTextBlock.Text = car.Count.ToString();
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            truck.Reset();
            car.Reset();
            truckTextBlock.Text = truck.Count.ToString();
            carTextBlock.Text = car.Count.ToString();
        }
    }
}
