using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ContactsBackup_
{
    public partial class user_login : PhoneApplicationPage
    {
        public user_login()
        {
            InitializeComponent();
        }

        private void Facebook_Login(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/facebook_login_folder/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Twitter_Login(object sender, RoutedEventArgs e)
        {

        }

        private void Google_Login(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void ContactsBackup(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/contactsusername.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}