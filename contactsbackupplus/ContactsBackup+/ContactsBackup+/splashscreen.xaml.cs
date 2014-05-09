using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading;

namespace ContactsBackup_
{
    public partial class splashscreen : PhoneApplicationPage
    {
        public splashscreen()
        {
            InitializeComponent();
            //Thread.Sleep(3000);
     
            this.Loaded += webbrowser1_Loaded;
        }

        private void webbrowser1_Loaded (object sender, RoutedEventArgs e)
        {
           
        }

        private void Login_Checked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Login_Unchecked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/user_login.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}