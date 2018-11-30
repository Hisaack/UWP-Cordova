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

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Uri uri = new Uri ("http://www.aljazeera.com/");
            wvPage.Navigate(uri);
           
        }

       

       

       

      
       

        private void wvPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void wvPage_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            myProgressRing.IsActive = false;
        }

        private void wvPage_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            myProgressRing.IsActive = true;
        }
    }
}
