using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using MimeKit;
using E3_BarrocIntens.Data.Classes;
using E3_BarrocIntens.Data;
using E3_BarrocIntens.Modules;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_BarrocIntens
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserProfileDashboard : Page
    {
        public UserProfileDashboard()
        {
            this.InitializeComponent();

            // Fill fields with user data
            User user = Session.Instance.User;
            if (user != null){
                UsernameTextBox.Text = user.Username;
            }
        }

        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            // Edge cases
            User user = Session.Instance.User;
            if (user == null)
                return;

            string password = PasswordBox.Password;
            if (string.IsNullOrEmpty(password))
                return;

            // Update user password
            user.Password = PasswordHasher.HashPassword(password);

            // Save user
            using (var db = new AppDbContext())
            {
                db.Users.Update(user);
                db.SaveChanges();
            }

            // Notify user of change
            Notify("Password changed", "Your password has been successfully updated!");
        }

        private void ChangeUsernameButton_Click(object sender, RoutedEventArgs e)
        {
            // Edge cases
            User user = Session.Instance.User;
            if (user == null)
                return;

            string username = UsernameTextBox.Text;
            if (string.IsNullOrEmpty(username))
                return;

            // Update user name
            user.Username = username;

            // Save user
            using (var db = new AppDbContext())
            {
                db.Users.Update(user);
                db.SaveChanges();
            }

            // Notify user of change
            Notify("Username changed", "Your display name has been successfully updated!");
        }

        private async void Notify(string title, string message)
        {
            ContentDialog dialog = new()
            {
                Title = title,
                Content = message,
                CloseButtonText = "OK",
                XamlRoot = this.XamlRoot
            };
            await dialog.ShowAsync();
        }

        private void optionsMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HandleSelection(); // Process the selected item.
        }

        private void optionsMenu_DropDownClosed(object sender, object e)
        {
            HandleSelection(); // Process the selection when the drop-down closes.
        }

        private void HandleSelection()
        {
            // Check if the selected item is a ComboBoxItem.
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
                    case "Finance":
                        this.Frame.Navigate(typeof(FinanceDashboard)); // Navigate to FinanceDashboard.
                        break;
                    case "Sales":
                        this.Frame.Navigate(typeof(SalesDashboard)); // Navigate to SalesDashboard.
                        break;
                    case "Purchasing":
                        this.Frame.Navigate(typeof(PurchasingDashboard)); // Navigate to PurchasingDashboard.
                        break;
                    case "Maintenance":
                        this.Frame.Navigate(typeof(MaintenanceDashboard)); // Navigate to MaintenanceDashboard.
                        break;
                }
            }
        }
    }
}
