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
using E3_BarrocIntens.Data.Classes;
using E3_BarrocIntens.Data;
using Microsoft.EntityFrameworkCore;
using Windows.Security.ExchangeActiveSyncProvisioning;

namespace E3_BarrocIntens
{
    public sealed partial class FinanceDashboard : Page
    {
        public FinanceDashboard()
        {
            this.InitializeComponent(); // Initialize the page components.
            ShowContracts();
        }

        public void ShowContracts()
        {
            using (var db = new AppDbContext())
            {
                if (Session.Instance.User != null)
                {
                    var userId = Session.Instance.User.Id;

                    var contracts = db.LeaseContracts.Include(leaseContract => leaseContract.Product).ToList();

                    leaseContractLv.ItemsSource = contracts;
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
