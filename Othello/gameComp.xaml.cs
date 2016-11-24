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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Othello
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage3 : Page
    {
        public MainPage3()
        {
            this.InitializeComponent();
        }
        private void button_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            button.Content = "G";
        }

        private void button_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            button.Content = "H";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void button_Copy28_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/blue.png"));
            button_Copy28.Background = brush;
            button_Copy27.Background = brush;
            result1.Text = "Yellow's Turn";
            ptsB.Text = "Blue: 40";
            ptsY.Text = "Yellow: 10";
            
        }

        private void button_Copy44_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button_Copy27_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button_Copy26_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Copy20_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/yellow.png"));
            button_Copy20.Background = brush;
            button_Copy27.Background = brush;
            result1.Text = "red's Turn";
            ptsB.Text = "red: 30";
            ptsY.Text = "Yellow: 30";

        }

        private void button_Copy33_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/red.png"));
            button_Copy33.Background = brush;
            button_Copy34.Background = brush;
            result1.Text = "Yellow's Turn";
            ptsB.Text = "red: 50";
            ptsY.Text = "Yellow: 20";
        }

        private void button_Copy42_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button_Copy25_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Yellow.png"));
            button_Copy25.Background = brush;
            button_Copy26.Background = brush;
            result1.Text = "red's Turn";
            ptsB.Text = "red: 40";
            ptsY.Text = "Yellow: 40";
        }
        private void button_Copy17_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/red.png"));
            button_Copy17.Background = brush;
            button_Copy26.Background = brush;
            result1.Text = "Yellow's Turn";
            ptsB.Text = "red: 60";
            ptsY.Text = "Yellow: 30";
        }

        private void button_Copy9_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Yellow.png"));
            button_Copy17.Background = brush;
            button_Copy9.Background = brush;
            result1.Text = "red's Turn";
            ptsB.Text = "red: 50";
            ptsY.Text = "Yellow: 50";

        }
        private void button_Copy8_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/red.png"));
            button_Copy17.Background = brush;
            button_Copy8.Background = brush;
            result1.Text = "Yellow's Turn";
            ptsB.Text = "red: 70";
            ptsY.Text = "Yellow: 40";
        }

        private void button_Copy7_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Yellow.png"));
            button_Copy7.Background = brush;
            button_Copy8.Background = brush;
            result1.Text = "red's Turn";
            ptsB.Text = "red: 60";
            ptsY.Text = "Yellow: 60";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/red.png"));
            button_Copy8.Background = brush;
            button.Background = brush;
            result1.Text = "Yellow's Turn";
            ptsB.Text = "red: 80";
            ptsY.Text = "Yellow: 50";

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void button_Copy43_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/yellow.png"));
            button_Copy43.Background = brush;
            button_Copy34.Background = brush;
            result1.Text = "red's Turn";
            ptsB.Text = "red: 70";
            ptsY.Text = "Yellow: 70";

        }

        private void button_Copy51_Click(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/red.png"));
            button_Copy43.Background = brush;
            button_Copy51.Background = brush;
            result1.Text = "Yellow's Turn";
            ptsB.Text = "red: 90";
            ptsY.Text = "Yellow: 60";
        }

        private void ptsB_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
