using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Othello
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        int points = 1500;
        public BlankPage2()
        {
            this.InitializeComponent();
            if (points >= 0)
            {
                pts.Text = points.ToString();
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage1));
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            points -= 300;
            pts.Text = points.ToString();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            points -= 550;
            pts.Text = points.ToString();
        }

        private void checkBox_Copy_Checked(object sender, RoutedEventArgs e)
        {
            points -= 150;
            pts.Text = points.ToString();
        }

        private void checkBox1_Copy_Checked(object sender, RoutedEventArgs e)
        {
            points -= 100;
            pts.Text = points.ToString();
        }

        private void checkBox_Copy1_Checked(object sender, RoutedEventArgs e)
        {
            points -= 30;
            pts.Text = points.ToString();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            checkBox.IsChecked = false;
            checkBox1.IsChecked = false;
            if (points >= 0)
            {
                MessageDialog msgbox = new MessageDialog("New Board(s) successfully unlocked");
                await msgbox.ShowAsync();
            }
        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            checkBox_Copy.IsChecked = false;
            checkBox1_Copy.IsChecked = false;
            if (points >= 0)
            {
                MessageDialog msgbox = new MessageDialog("New Coin(s) successfully unlocked");
                await msgbox.ShowAsync();
            }
        }

        private async void button2_Click(object sender, RoutedEventArgs e)
        {
            checkBox_Copy1.IsChecked = false;
            if (points >= 0)
            {
                MessageDialog msgbox = new MessageDialog("Clean-Up Coin successfully bought");
                await msgbox.ShowAsync();
            }
        }
    }
}
