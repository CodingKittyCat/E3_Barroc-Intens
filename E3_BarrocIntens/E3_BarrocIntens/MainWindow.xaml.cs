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

namespace E3_BarrocIntens
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent(); // Initialize the window components.
            window.Navigate(typeof(CreateLease));
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

        internal void HandleSelection()
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
                        window.Navigate(typeof(WelcomeDashboard)); // Navigate to WelcomeDashboard.
                        optionsMenu.Visibility = Visibility.Collapsed; // Hide the options menu.
                        break;
                    case "Finance":
                        window.Navigate(typeof(FinanceDashboard)); // Navigate to FinanceDashboard.
                        optionsMenu.Visibility = Visibility.Collapsed; // Hide the options menu.
                        break;
                    case "Sales":
                        window.Navigate(typeof(SalesDashboard)); // Navigate to SalesDashboard.
                        optionsMenu.Visibility = Visibility.Collapsed; // Hide the options menu.
                        break;
                    case "Customer":
                        window.Navigate(typeof(CustomerDashboard)); // Navigate to CustomerDashboard.
                        optionsMenu.Visibility = Visibility.Collapsed; // Hide the options menu.
                        break;
                    case "Purchasing":
                        window.Navigate(typeof(PurchasingDashboard)); // Navigate to PurchasingDashboard.
                        optionsMenu.Visibility = Visibility.Collapsed; // Hide the options menu.
                        break;
                    case "Maintenance":
                        window.Navigate(typeof(MaintenanceDashboard)); // Navigate to MaintenanceDashboard.
                        optionsMenu.Visibility = Visibility.Collapsed; // Hide the options menu.
                        break;
                }
            }
        }
    }
}
