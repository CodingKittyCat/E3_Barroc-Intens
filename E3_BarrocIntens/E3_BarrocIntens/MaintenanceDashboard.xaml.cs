using System;
using System.Linq;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using E3_BarrocIntens.Data;
using Microsoft.EntityFrameworkCore;

using E3_BarrocIntens.Data.Classes;
using System.ComponentModel;
using Windows.Storage;

namespace E3_BarrocIntens
{
    public sealed partial class MaintenanceDashboard : Page
    {
        public MaintenanceDashboard()
        {
            this.InitializeComponent(); // Initialize the page components.
            this.DataContext = this;
            ShowOpenRequests();
        }

        private void ShowOpenRequests()
        {
            using (var db = new AppDbContext())
            {
                // Load maintenance requests with the associated User
                var requests = db.maintenanceRequests
                    .Where(MR => MR.IsClosed == false)
                    .Include(m => m.User)
                    .OrderBy(MR => MR.Id)
                    .ToList();

                RequestListView.ItemsSource = requests;
            }
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

        private async void BindWorker_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                // Load maintenance workers to select from
                var users = db.Users
                    .OrderBy(u => u.Name)
                    .Where(u => u.Role.RoleName == "Maintenance")
                    .ToList();

                WorkerNameTextBox.ItemsSource = users;
                WorkerNameTextBox.DisplayMemberPath = "Name"; // Display user name in ListBox
                WorkerNameTextBox.SelectedValuePath = "Id"; // Use user ID as selected value
            }

            MaintenanceRequest selectedMaintenance = (sender as Button).CommandParameter as MaintenanceRequest;

            // Set DataContext for AddWorkerDialog
            AddWorkerDialog.DataContext = selectedMaintenance;

            // Show AddWorkerDialog
            var result = await AddWorkerDialog.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                // Get selected worker ID
                int selectedWorkerId = (int)WorkerNameTextBox.SelectedValue;

                using (var db = new AppDbContext())
                {
                    // Load the selected user
                    var selectedUser = db.Users.FirstOrDefault(u => u.Id == selectedWorkerId);

                    if (selectedUser != null)
                    {
                        // Update the MaintenanceRequest with the selected user
                        selectedMaintenance.UserId = selectedWorkerId;
                        selectedMaintenance.User = selectedUser; // Update the navigation property

                        db.maintenanceRequests.Attach(selectedMaintenance);
                        db.Entry(selectedMaintenance).Property(m => m.UserId).IsModified = true;
                        db.Entry(selectedMaintenance).Reference(m => m.User).IsModified = true;

                        await db.SaveChangesAsync();
                    }
                }

                // Refresh the list to display updated data
                ShowOpenRequests();
            }
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

