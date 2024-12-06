using E3_BarrocIntens.Data;
using E3_BarrocIntens.Data.Classes;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace E3_BarrocIntens
{
    public sealed partial class PurchasingDashboard : Page
    {
        public PurchasingDashboard()
        {
            this.InitializeComponent(); // Initialize the page components.

            using (var db = new AppDbContext())
            {
                ProductListView.ItemsSource = db.Products
                    .ToList(); // Set the product list view items source to the product ids.
            }
        }
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchResult = searchBar.Text; // Get text from the search bar.
            Debug.WriteLine(searchResult); // Log the search result.
        }
        private void searchButton2_Click(object sender, RoutedEventArgs e)
        {
            string searchResult = searchBar.Text; // Get text from the search bar.
            Debug.WriteLine(searchResult); // Log the search result.
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
                    case "Sales":
                        this.Frame.Navigate(typeof(SalesDashboard)); // Navigate to SalesDashboard.
                        break;
                    case "Customer":
                        this.Frame.Navigate(typeof(CustomerDashboard)); // Navigate to CustomerDashboard.
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

        private void searchButton3_Click(object sender, RoutedEventArgs e)
        {
            // Placeholder for future search button functionality.
        }

        private void ProductListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // navigate to CreateProductDashboard with selected product id
            if (ProductListView.SelectedItem is Product product)
            {
                this.Frame.Navigate(typeof(CreateProductDashboard), product.Id); // Navigate to CreateProductDashboard with selected product id.
            }
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateProductDashboard)); // Navigate to CreateProductDashboard.
        }
    }
}
