using E3_BarrocIntens.Data;
using E3_BarrocIntens.Data.Classes;
using E3_BarrocIntens.Modules;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_BarrocIntens
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateCustomerDashboard : Page
    {
        public CreateCustomerDashboard()
        {
            this.InitializeComponent();

            // populate roles combobox
            using (var db = new AppDbContext())
            {
                UserRoleComboBox.ItemsSource = db.Roles.ToList();
            }
        }

        private void optionsMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HandleSelection(); // Handle the selection change.
        }

        private void optionsMenu_DropDownClosed(object sender, object e)
        {
            HandleSelection(); // Handle the selection change.
        }

        private void CreateCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            // input validation
            if (string.IsNullOrEmpty(CustomerNameBox.Text))
            {
                Notice("Please enter a name for the customer.");
                return;
            }

            // check if username already exists
            using (var db = new AppDbContext())
            {
                if (db.Users.Any(u => u.Username.ToLower() == CustomerUsernameBox.Text.ToLower()))
                {
                    Notice("Username already exists.");
                    return;
                }
            }

            if (string.IsNullOrEmpty(CustomerUsernameBox.Text))
            {
                Notice("Please enter a username for the customer.");
                return;
            }
            if (string.IsNullOrEmpty(CustomerEmailBox.Text))
            {
                Notice("Please enter a password for the customer.");
                return;
            }
            if (UserRoleComboBox.SelectedItem == null)
            {
                Notice("Please select a role for the customer.");
                return;
            }

            // generate strong password
            string password = PasswordHasher.GenerateRandomString(8);

            // create new user
            User user = new()
            {
                Name = CustomerNameBox.Text,
                Username = CustomerUsernameBox.Text,
                Email = CustomerEmailBox.Text,
                Password = PasswordHasher.HashPassword(password),
                RoleId = UserRoleComboBox.SelectedIndex + 1
            };

            // save user to database
            using (var db = new AppDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }

            // email user email with login credentials
            new QuoteGenerator().SendEmail(
                user.Email,
                "Welcome to Barroc Intens",
                $"Welcome to Barroc Intens, {user.Name}!\n\nYour login credentials are:\nUsername: {user.Username}\nPassword: {password}"
            );

            // notify user
            Notice("Customer created successfully and emailed credentials.");
        }

        private async void Notice(string message)
        {
            // show notice pop up to user
            ContentDialog dialog = new()
            {
                Title = "Notice",
                Content = message,
                CloseButtonText = "OK",
                XamlRoot = this.Content.XamlRoot
            };
            await dialog.ShowAsync();
        }

        private void HandleSelection()
        {
            // Check if selected item is a ComboBoxItem.
            if (optionsMenu.SelectedItem is ComboBoxItem selectedItem)
            {
                switch (selectedItem.Content.ToString())
                {
                    case "Cancel":
                        optionsMenu.SelectedItem = null; // Clear selection.
                        break;
                    case "Welcome":
                        this.Frame.Navigate(typeof(WelcomeDashboard)); // Navigate to WelcomeDashboard.
                        break;
                    case "Sales":
                        this.Frame.Navigate(typeof(SalesDashboard)); // Navigate to SalesDashboard.
                        break;
                    case "Customer":
                        this.Frame.Navigate(typeof(CustomerDashboard)); // Navigate to CustomerDashboard.
                        break;
                    case "Purchasing":
                        this.Frame.Navigate(typeof(PurchasingDashboard)); // Navigate to PurchasingDashboard.
                        break;
                    case "Maintenance":
                        this.Frame.Navigate(typeof(MaintenanceDashboard)); // Navigate to MaintenanceDashboard.
                        break;
                    case "CreateRequest":
                        this.Frame.Navigate(typeof(MaintenanceCreate));
                        optionsMenu.Visibility = Visibility.Collapsed;
                        break;
                }
            }
        }
    }
}
