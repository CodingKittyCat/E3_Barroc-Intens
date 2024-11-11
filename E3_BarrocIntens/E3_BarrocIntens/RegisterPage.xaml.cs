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
            // Clear the alert text and make errors list
            alertText.Text = "";
            List<string> errors = new List<string>();

            // Check if the username and password are not empty
            if (string.IsNullOrEmpty(usernameTb.Text))
            {
                errors.Add("Invalid username. Make sure it's not empty.");
            }
            if (string.IsNullOrEmpty(passwordTb.Text))
            {
                errors.Add("Invalid password. Make sure it's not empty.");
            }
            // Check if the password and repeat password are the same
            if (passwordTb.Text != repeatPasswordTb.Text)
            {
                errors.Add("Passwords do not match. (It's case sensitive!)");
            }
            // Check if there are any errors
            if (errors.Count > 0)
            {
                // for each error in the errors list, add it to the alert text
                foreach (string error in errors)
                {
                    alertText.Text = alertText.Text + $"{error}\n";
                }
                // return to stop the function
                return;
            }
            // Create a new user object
            User newUser = new User
            {
                Username = usernameTb.Text,
                Password = Helper.HashPassword(passwordTb.Text),
                RoleId = 4,
                Name = usernameTb.Text
            };
            // Add the user to the database
            using (AppDbContext db = new AppDbContext())
            {
                db.Add(newUser);
                db.SaveChanges();
            }
        }
    }
}
