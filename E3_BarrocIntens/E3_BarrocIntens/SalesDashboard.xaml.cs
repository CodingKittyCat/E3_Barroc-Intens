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
using System.Diagnostics;
using E3_BarrocIntens.Data;
using E3_BarrocIntens.Data.Classes;
using System.Collections;
using System.Threading.Tasks;

namespace E3_BarrocIntens
{
    public sealed partial class SalesDashboard : Page
    {
        public SalesDashboard()
        {
            this.InitializeComponent(); // Initialize the page components.

            using (var db = new AppDbContext())
            {
                customerLv.ItemsSource = db.Users.Where(user => user.Role.RoleName == "Customer").ToList();
                quotesLv.ItemsSource = db.Quotes.ToList();
            }
        }


        private async void AddQuoteButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                // Load customer to select from
                var users = db.Users
                    .OrderBy(u => u.Name)
                    .Where(u => u.Role.RoleName == "Customer")
                    .ToList();

                CustomerListbox.ItemsSource = users;
                CustomerListbox.DisplayMemberPath = "Name"; // Display user name in ListBox
                CustomerListbox.SelectedValuePath = "Id"; // Use user ID as selected value
            }

            var result = await AddQuoteDialog.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                int selectedCustomerId = (int)CustomerListbox.SelectedValue;

                using (var db = new AppDbContext())
                {
                    Quote quote = new Quote();
                    quote.CustomerId = selectedCustomerId;
                    quote.QuoteDate = QuoteDatePicker.Date.Date;
                    quote.ExpirationDate = QuoteExpirationDatePicker.Date.Date;
                    quote.TotalAmount = decimal.Parse(QuoteTotalAmountBox.Text);
                    quote.Status = QuoteStatusBox.Text;

                    db.Add(quote);
                    await db.SaveChangesAsync();

                    customerLv.ItemsSource = db.Users.Where(user => user.Role.RoleName == "Customer").ToList();
                    quotesLv.ItemsSource = db.Quotes.ToList();
                }
            }
        }

        private void optionsMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox; // Cast sender to ComboBox.
            HandleSelection(); // Handle the selection change.
        }

        private void optionsMenu_DropDownClosed(object sender, object e)
        {
            HandleSelection(); // Handle selection when dropdown closes.
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

        private void addNotesButton_Click(object sender, RoutedEventArgs e)
        {
            User selectedUser = (sender as Button).CommandParameter as User;
            this.Frame.Navigate(typeof(AddNotesDashboard), selectedUser);
        }

        private void quotesLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Quote quote = quotesLv.SelectedItem as Quote;
            if (quote == null)
            {
                return;
            }

            this.Frame.Navigate(typeof(CustomerQuoteDashboard), quote);
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateCustomerDashboard));
        }

        private async void RemoveQuoteButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected Quote using the sender button's CommandParameter.
            Button button = sender as Button;
            if (button?.DataContext is Quote selectedQuote)
            {
                ContentDialog deleteDialog = new ContentDialog
                {
                    Title = "Delete Quote",
                    Content = "Are you sure you want to delete this quote?",
                    PrimaryButtonText = "Delete",
                    CloseButtonText = "Cancel",
                    XamlRoot = this.XamlRoot
                };

                var result = await deleteDialog.ShowAsync();

                if (result == ContentDialogResult.Primary)
                {
                    using (var db = new AppDbContext())
                    {
                        // Remove the selected quote from the database.
                        var quoteToDelete = db.Quotes.Find(selectedQuote.Id);
                        if (quoteToDelete != null)
                        {
                            db.Quotes.Remove(quoteToDelete);
                            await db.SaveChangesAsync();

                            // Refresh all of the sales lists
                            RefreshLists();
                        }
                    }
                }
            }
            else
            {
                Debug.WriteLine("No quote selected or CommandParameter is missing.");
            }
        }

        private async void deleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog deleteDialog = new ContentDialog
            {
                Title = "Delete User",
                Content = "Are you sure you want to delete this user?",
                PrimaryButtonText = "Delete",
                CloseButtonText = "Cancel",
                XamlRoot = this.XamlRoot
            };

            // Await the result of the dialog
            var result = await deleteDialog.ShowAsync();
            if (result != ContentDialogResult.Primary)
                return;

            // Parse user from the sender as Button
            Button button = sender as Button;
            if (button?.DataContext is User selectedUser)
            {
                using (var db = new AppDbContext())
                {
                    // Find the user to delete
                    var userToDelete = db.Users.Find(selectedUser.Id);
                    if (userToDelete != null)
                    {
                        // Remove the user from the database
                        db.Users.Remove(userToDelete);
                        await db.SaveChangesAsync();

                        // Refresh the sales lists
                        RefreshLists();
                    }
                }
            }
        }

        private void RefreshLists()
        {
            // Refresh the customers & quotes list by querying the database
            using (var db = new AppDbContext())
            {
                customerLv.ItemsSource = db.Users.Where(user => user.Role.RoleName == "Customer").ToList();
                quotesLv.ItemsSource = db.Quotes.ToList();
            }
        }
    }
}
