﻿using System;
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

namespace iUN_UWP10_UNAL
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WebViewPage : Page
    {
        private bool _isLoading;

        public WebViewPage()
        {
            this.InitializeComponent();
            WebViewFrame.ContentLoading += ContentLoading;
            WebViewFrame.NavigationCompleted += NavigationCompleted;
            _isLoading = false;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string URI = e.Parameter as string;
            if (URI != null)
            {
                WebViewFrame.Navigate(new Uri("http://" + URI));
            }
        }

        private void ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            TextBoxURI.Text = WebViewFrame.Source.AbsoluteUri;
            _isLoading = true;
        }

        private void NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            _isLoading = false;
        }

        private void OnButtonBackClick(object sender, RoutedEventArgs e)
        {
            if (WebViewFrame.CanGoBack)
                WebViewFrame.GoBack();
        }

        private void OnButtonRefreshClick(object sender, RoutedEventArgs e)
        {
            if (_isLoading)
                WebViewFrame.Stop();
            else
                WebViewFrame.Refresh();
        }

        private void OnButtonForwardClick(object sender, RoutedEventArgs e)
        {
            if (WebViewFrame.CanGoForward)
                WebViewFrame.GoForward();
        }
    }
}