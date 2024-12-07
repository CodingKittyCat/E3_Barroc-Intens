using E3_BarrocIntens.Data;
using E3_BarrocIntens.Data.Classes;
using Microsoft.EntityFrameworkCore;
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
                ProductListView.ItemsSource = db.Products.ToList(); // Set the product list view items source to the product ids.
            }
            LoadWorkReceipts();
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


        private void LoadWorkReceipts()
        {
            using (var db = new AppDbContext())
            {
                var usedMaterials = db.Materials
                .Include(m => m.ReceiptMaterials)
                .ThenInclude(m => m.WorkReceipt)
                .ToList();

                DateTime fifteenDaysAgo = DateTime.Now.AddDays(-15);

                var recentlyUsedMaterials = usedMaterials
                .Where(m => m.TotalQuantity > 0 && m.Stock < 100)
                .Where(m => m.ReceiptMaterials
                .Any(rm => rm.WorkReceipt.ReceiptDate >= fifteenDaysAgo))
                .ToList();

                UsedProductsListView.ItemsSource = recentlyUsedMaterials;
            }
        }

        private void searchButton4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrderProductButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            var selectedItem = clickedButton?.Tag as Material;

            // Pass both the Material Id and the type (either "Product" or "Material")
            this.Frame.Navigate(typeof(CreateProductDashboard), new Tuple<int, string>(selectedItem?.Id ?? 0, "Material"));
        }


        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filter = FilterBox.Text;

            FilterProducts(filter);
        }

        private void FilterProducts(string filter)
        {
            using (var db = new AppDbContext())
            {
                string lowerFilter = filter.ToLower();

                var products = db.Products.ToList();

                var filteredProducts = products
                    .Where(product =>
                      product.Title.ToLower().Contains(lowerFilter) ||
                      product.Status.ToString().ToLower().Contains(lowerFilter))
                    .OrderBy(product => product.Title)
                    .ToList();

                ProductListView.ItemsSource = filteredProducts;
            }
        }
    }
}
