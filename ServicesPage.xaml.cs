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

namespace iUN_UWP10_UNAL
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            this.InitializeComponent();
        }

        private void WebViewNavigate(string URI)
        {
            Frame.Navigate(typeof(WebViewPage), URI);
        }

        private void OnButtonMainPageClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("unal.edu.co");
        }

        private void OnButtonLDGClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("divulgacion.unal.edu.co");
        }

        private void OnButtonLibreriaClick(object sender, RoutedEventArgs e)
        {
            WebViewNavigate("uneditorial.com");
        }
    }
}