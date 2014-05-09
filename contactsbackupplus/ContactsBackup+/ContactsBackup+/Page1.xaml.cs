using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Data;
using System.Data.Common;

namespace ContactsBackup_
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            webbrowser1.Loaded += webbrowser1_Loaded;
        }

        private void webbrowser1_Loaded (object sender, RoutedEventArgs e)
        {
            webbrowser1.Navigate(new Uri("localhost/contacts backup/", UriKind.RelativeOrAbsolute));
        }

   
    }
}