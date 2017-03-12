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

namespace Teht_03
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            Lotto uusi = new Lotto();
            for (int i = 0; i < int.Parse(numDrawtextBox.Text); i++)
            {
                List<int> rivi = uusi.Gen();
                lottorivitextBox.Text += "Rivi "+(i+1).ToString()+": ";
                foreach (int n in rivi)
                {
                    lottorivitextBox.Text += n.ToString() + " ";
                }
                lottorivitextBox.Text += Environment.NewLine;
                Scroll.Content = (lottorivitextBox);
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            numDrawtextBox.Text = "";
            lottorivitextBox.Text = "";
        }
    }
}
