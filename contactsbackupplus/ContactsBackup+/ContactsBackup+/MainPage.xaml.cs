using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ContactsBackup_.Resources;
using System.Threading;

namespace ContactsBackup_
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            try
            {
                InitializeComponent();
                Thread.Sleep(2000);
            }
            catch { }
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Backup_Contacts(object sender, RoutedEventArgs e)
        {
           
        }

        private void Restore_Contacts(object sender, RoutedEventArgs e)
        {

        }

        private void View_Contacts_Online(object sender, RoutedEventArgs e)
        {
            string navto = string.Format("/Page1.xaml");
            NavigationService.Navigate(new Uri(navto, UriKind.RelativeOrAbsolute));
            
        }

       
        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}