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


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BasicPage1 : Page
    {

        public delegate void LoadCompletedEventHandler(object sender, NavigationEventArgs e);
        public BasicPage1()
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ring.IsActive = true;
            WebViewBrush b = new WebViewBrush();
            b.SourceName = "myWebView";
            b.Redraw();
            webViewImage.Fill = b; //This is my rectangle over WebView
            string navAddress = "http://" + address.Text;
            myWebView.Navigate(new Uri(navAddress));
            myWebView.Visibility = Visibility.Collapsed;
        }

        private void myWebView_LoadCompleted(object sender, NavigationEventArgs e)
        {
            ring.IsActive = false;
            myWebView.Visibility = Windows.UI.Xaml.Visibility.Visible;
            webViewImage.Fill = new SolidColorBrush(Windows.UI.Colors.Transparent);
        }
    }

}
