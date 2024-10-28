using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using E3_BarrocIntens.Data;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_BarrocIntens
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            this.InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            alertText.Text = "";
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(usernameTb.Text))
            {
                errors.Add("Invalid username. Make sure it's not empty.");
            }
            if (string.IsNullOrEmpty(passwordTb.Text))
            {
                errors.Add("Invalid password. Make sure it's not empty.");
            }
            if (passwordTb.Text != repeatPasswordTb.Text)
            {
                errors.Add("Passwords do not match. (It's case sensitive!)");
            }

            if (errors.Count > 0)
            {
                foreach (string error in errors)
                {
                    alertText.Text = alertText.Text + $"{error}\n";
                }
                return;
            }

            User newUser = new User
            {
                Username = usernameTb.Text,
                Password = Helper.HashPassword(passwordTb.Text)
            };

            using (BarrocIntensDataContext db = new BarrocIntensDataContext())
            {
                db.Add(newUser);
                db.SaveChanges();
            }
        }
    }
}
