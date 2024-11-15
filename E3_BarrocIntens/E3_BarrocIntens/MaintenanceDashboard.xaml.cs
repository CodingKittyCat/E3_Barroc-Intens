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

namespace E3_BarrocIntens
{
    public sealed partial class MaintenanceDashboard : Page
    {
        public MaintenanceDashboard()
        {
            this.InitializeComponent(); // Initialize the page components.
        }



        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchResult = searchBar.Text; // Get text from search bar.
            Debug.WriteLine(searchResult); // Log the search result.
        }

        private void searchButton_Click1(object sender, RoutedEventArgs e)
        {
            string searchResult = searchBar.Text; // Get text from search bar.
            Debug.WriteLine(searchResult); // Log the search result (duplicate).
        }

        private void searchButton_Click2(object sender, RoutedEventArgs e)
        {
            string searchResult = searchBar.Text; // Get text from search bar.
            Debug.WriteLine(searchResult); // Log the search result (duplicate).
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
                    case "Finance":
                        this.Frame.Navigate(typeof(FinanceDashboard)); // Navigate to FinanceDashboard.
                        break;
                    case "Sales":
                        this.Frame.Navigate(typeof(SalesDashboard)); // Navigate to SalesDashboard.
                        break;
                    case "Customer":
                        this.Frame.Navigate(typeof(CustomerDashboard)); // Navigate to CustomerDashboard.
                        break;
                    case "Purchasing":
                        this.Frame.Navigate(typeof(PurchasingDashboard)); // Navigate to CustomerDashboard.
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

