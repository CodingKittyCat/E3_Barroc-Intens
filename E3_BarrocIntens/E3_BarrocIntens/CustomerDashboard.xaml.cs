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
using Microsoft.EntityFrameworkCore;
using Windows.System;
using System.Xml.Linq;

namespace E3_BarrocIntens
{
    public sealed partial class CustomerDashboard : Page
    {
        public CustomerDashboard()
        {
            this.InitializeComponent(); // Initialize the components on the page.
            ShowInvoices();
            ShowOrders();
            ShowContracts();
            ShowProducts();
            ShowMaterials();
            ShowQuotes();
        }

        public void ShowProducts()
        {
            using (var db = new AppDbContext())
            {
                var products = db.Products.ToList();
                ProductListView.ItemsSource = products;
            }
        }

        // Show orders in a listview
        public void ShowOrders()
        {
            using (var db = new AppDbContext())
            {
                // Query to filter orders by the specified status
                var filteredOrders = db.Orders
                                       .Where(o => o.IsDelivered == false)
                                       .ToList() ;
                OrderListview.ItemsSource = filteredOrders;
            }
        }

        // Show materials in a listview and put the visibility to visible if the logged in user is Maintenance.
        public void ShowMaterials()
        {
            if (Session.Instance.User.Role.RoleName == "Maintenance")
            {
                using (var db = new AppDbContext())
                {
                    var materials = db.Materials.ToList();
                    MaterialListView.ItemsSource = materials;
                    MaterialBorder.Visibility = Visibility.Visible;
                    MaterialHeader.Visibility = Visibility.Visible;
                }
            }

        }

        // Show invoices in a listview
        public void ShowInvoices()
        {
            if (Session.Instance.User == null)
                return;

            using (var db = new AppDbContext())
            {
                // Get all invoices for the logged in user
                var invoices = db.Invoices.Where(invoice => invoice.CustomerId == Session.Instance.User.Id).ToList();

                // Set the invoices listview to the invoices
                InvoiceListView.ItemsSource = invoices;
            }
        }

        // Show the contracts that a customer has
        public void ShowContracts()
        {
            using (var db = new AppDbContext())
            {
                if (Session.Instance.User != null)
                {
                    var userId = Session.Instance.User.Id;
                    var contracts = db.LeaseContracts.Include(leaseContract => leaseContract.Product).Where(leaseContract => leaseContract.UserId == userId).ToList();

                    leaseContractLv.ItemsSource = contracts;
                }
            }
        }

        // Show the quotes that a customer has
        public void ShowQuotes()
        {
            using (var db = new AppDbContext())
            {
                if (Session.Instance.User != null)
                {
                    // Get all quotes where the customer has not accepted the quote yet
                    var userId = Session.Instance.User.Id;
                    var contracts = db.Quotes.Where(quote => quote.CustomerId == userId && quote.CustomerAccepted == false).ToList();

                    QuotesListView.ItemsSource = contracts;
                }
            }
        }

        private void optionsMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox; // Get the ComboBox that triggered the event.
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
                    case "CreateRequest":
                        this.Frame.Navigate(typeof(MaintenanceCreate));
                        optionsMenu.Visibility = Visibility.Collapsed;
                        break;
                }
            }
        }

        private void UserProfileButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserProfileDashboard)); // Navigate to UserProfileDashboard.
        }

        private void createLeaseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateLease)); // Navigate to the CreateLease page.
        }

        private void showLeaseBtn_Click(object sender, RoutedEventArgs e)
        {
            LeaseContract leaseContract = (sender as Button).CommandParameter as LeaseContract;
            this.Frame.Navigate(typeof(ViewLease), leaseContract.Id);
        }

        private void QuoteAcceptButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the quote from command parameter
            Quote quote = (sender as Button).CommandParameter as Quote;
            if (quote == null)
                return;

            //  Update the quote to be accepted by the customer
            using (var db = new AppDbContext())
            {
                // update the quote to be accepted by the customer
                quote.CustomerAccepted = true;

                // Update the quote in the database
                db.Quotes.Update(quote);

                // Create new invoice with quote details
                Invoice invoice = new()
                {
                    CustomerId = quote.CustomerId,
                    InvoiceDate = quote.QuoteDate,
                    DueDate = quote.ExpirationDate,
                    TotalAmount = float.Parse(quote.TotalAmount.ToString()),
                    IsPayed = false
                };
                // Add the invoice to the database
                db.Invoices.Add(invoice);

                // Save the changes to the database
                db.SaveChanges();
            }

            // Refresh the quotes & invoices listview
            ShowQuotes();
            ShowInvoices();
        }
    }
}
