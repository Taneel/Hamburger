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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hamburger
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

        private void hamburgerbutton1_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Button1.IsSelected)
            {
                MyFrame.Navigate(typeof(Page1));
            }
            else if (Button2.IsSelected)
            {
                MyFrame.Navigate(typeof(Page2));
            }
            else if (Button3.IsSelected)
            {
                MyFrame.Navigate(typeof(Page3));
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
