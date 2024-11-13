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
        }

        public void ShowOrders()
        {
            using (var db = new AppDbContext())
            {
                // Query to filter orders by the specified status
                var filteredOrders = db.Orders
                                       .Where(o => o.IsDelivered == false)
                                       .ToList();
                OrderListview.ItemsSource = filteredOrders;
            }
        }

        public void ShowInvoices()
        {
            using (var db = new AppDbContext())
            {
                var invoices = db.Invoices.ToList();

                InvoiceListView.ItemsSource = invoices;
            }
        }

        public void ShowContracts()
        {
            using (var db = new AppDbContext())
            {
                var contracts = db.LeaseContracts.Include(leaseContract => leaseContract.Product).ToList();

                leaseContractLv.ItemsSource = contracts;
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
                }
            }
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
    }
}
