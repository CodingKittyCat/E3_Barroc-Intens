using E3_BarrocIntens.Data.Classes;
using E3_BarrocIntens.Data;

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
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_BarrocIntens
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MaintenanceCreate : Page
    {
        private readonly AppDbContext _context = new AppDbContext();

        public MaintenanceCreate()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            using (var db = new AppDbContext())
            {
                var products = db.Products.ToList();

                ProductList.ItemsSource = products;
                ProductList.DisplayMemberPath = "Title";
                ProductList.SelectedValuePath = "Id";
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchResult = searchBar.Text; // Get text from search bar.
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
                      product.Title.ToLower().Contains(lowerFilter))
                    .OrderBy(product => product.Title)
                    .ToList();

                ProductList.ItemsSource = filteredProducts;
            }
        }

        private async void SendButton_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = ProductList.SelectedItem as Product;
            if (selectedProduct != null)
            {
                MaintenanceRequest NewRequest = new MaintenanceRequest()
                {
                    ProductId = selectedProduct.Id,
                    Description = DescriptionBox.Text,
                    RequestedDateTime = DateTime.Now,
                    RequestUserId = Session.Instance.User.Id
                };

                _context.Add(NewRequest);
                _context.SaveChanges();

                DescriptionBox.Text = string.Empty;
                ProductList.SelectedItem = null;

                var contentDialog = new ContentDialog
                {
                    Title = "Request has been Sent!",
                    Content = "We'll try to make contact within 2 workdays",
                    CloseButtonText = "OK"
                };
                contentDialog.XamlRoot = this.XamlRoot;

                await contentDialog.ShowAsync();

                this.Frame.Navigate(typeof(CustomerDashboard));
            }



        }
    }
}
