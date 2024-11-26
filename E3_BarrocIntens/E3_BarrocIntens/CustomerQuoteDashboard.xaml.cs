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
    public sealed partial class CustomerQuoteDashboard : Page
    {
        Quote quote;

        public CustomerQuoteDashboard()
        {
            this.InitializeComponent();

            using (var db = new AppDbContext())
            {
                QuoteCustomerComboBox.ItemsSource = db.Users
                    .Where(user => user.Role.RoleName == "Customer")
                    .Select(p => p.Name).ToList(); // select all names of customers
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // parse the parameter to a Quote object
            quote = (Quote)e.Parameter;

            // fill fields with quote data
            QuoteCustomerComboBox.SelectedItem = quote.Customer.Name;
            QuoteDatePicker.Date = quote.QuoteDate;
            QuoteExpirationDatePicker.Date = quote.ExpirationDate;
            QuoteTotalAmountBox.Text = quote.TotalAmount.ToString();
            QuoteStatusBox.Text = quote.Status;
        }

        private void optionsMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HandleSelection();
        }

        private void optionsMenu_DropDownClosed(object sender, object e)
        {
            HandleSelection();
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
                    case "Customer":
                        this.Frame.Navigate(typeof(CustomerDashboard)); // Navigate to CustomerDashboard.
                        break;
                }
            }
        }

        private void QuoteSaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                User customer = db.Users
                    .Where(user => user.Name == QuoteCustomerComboBox.SelectedItem.ToString())
                    .FirstOrDefault();

                if (customer == null) { return; }

                // update quote with new data
                quote.CustomerId = customer.Id;
                quote.QuoteDate = QuoteDatePicker.Date.Date;
                quote.ExpirationDate = QuoteExpirationDatePicker.Date.Date;
                quote.TotalAmount = decimal.Parse(QuoteTotalAmountBox.Text);
                quote.Status = QuoteStatusBox.Text;

                quote.Customer = db.Users.Where(user => user.Id == quote.CustomerId).FirstOrDefault();

                // save changes to database
                db.Quotes.Update(quote);
                db.SaveChanges();
            }
        }

        private async void QuoteEmailButton_Click(object sender, RoutedEventArgs e)
        {
            if (quote == null) { return; }

            // parse quote to string
            string result = "";

            result += $"Quote #{quote.Id}\n";
            result += $"{quote.QuoteDate}\n\n";

            result += $"{quote.Customer.Name}\n";
            result += $"{quote.Customer.Email}\n\n";

            result += $"Total Amount: ${ Math.Round(quote.TotalAmount, 2) }\n";
            result += $"Expiration: {quote.ExpirationDate}\n\n";

            result += $"Status: {quote.Status}";

            string subject = $"Sales Quote #{quote.Id}";
            string body = result;

            // send email to customer
            QuoteGenerator generator = new QuoteGenerator();
            generator.SendEmail(quote.Customer.Email, subject, body);

            // notify user of success
            ContentDialog dialog = new()
            {
                Title = "Success",
                Content = "Quote has been successfully emailed to the customer!",
                CloseButtonText = "OK",
                XamlRoot = this.XamlRoot
            };
            await dialog.ShowAsync();
        }
    }
}
