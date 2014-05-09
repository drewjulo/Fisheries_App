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
    public partial class contactsusername : PhoneApplicationPage
    {
        public contactsusername()
        {
            InitializeComponent();
        }

        private void username(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            this.user_name.ToString();
            

        }

        private void PasswordBox_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            
        }

        private void Submit(object sender, RoutedEventArgs e)
        {

        }
    }
}