using System;
using System.Linq;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using E3_BarrocIntens.Data.Classes;
using E3_BarrocIntens.Data;
using Microsoft.UI;
using Microsoft.EntityFrameworkCore;

using E3_BarrocIntens.Data.Classes;
using System.ComponentModel;
using Windows.Storage;
using System.Xml.Linq;
using System.Collections.Generic;
using Microsoft.UI.Xaml.Media;

namespace E3_BarrocIntens
{
    public sealed partial class MaintenanceDashboard : Page
    {
        private Dictionary<DateTime, SolidColorBrush> plannedDates;
        public MaintenanceDashboard()
        {
            this.InitializeComponent(); // Initialize the page components.
            if (Session.Instance.User != null)
            {
                using (var db = new AppDbContext())
                {
                    plannedDates = db.maintenanceRequests
                        .Where(mr => mr.User.Id == Session.Instance.User.Id)
                        .GroupBy(mr => mr.PlannedDateTime.Value.Date) // Group by date to handle duplicates
                        .ToDictionary(
                            group => group.Key,                          // Use the date as the key
                            group => new SolidColorBrush(Colors.Yellow)  // Assign a color to the date
                        );
                }
            }

            this.DataContext = this;
            ShowOpenRequests();
            ShowClosedRequests();
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

        private void ShowClosedRequests()
        {
            using (var db = new AppDbContext())
            {
                // Load maintenance requests with the associated User
                var requests = db.maintenanceRequests
                    .Where(MR => MR.IsClosed == true)
                    .Include(m => m.User)
                    .Include(m => m.WorkReceipt)
                    .OrderBy(MR => MR.Id)
                    .ToList();

                ClosedRequestsListView.ItemsSource = requests;
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
        
        private async void BindWorkReceipt_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                // Load materials to select from
                var materials = db.Materials
                    .OrderBy(m => m.Name)
                    .ToList();

                MaterialList.ItemsSource = materials;
            }

            MaintenanceRequest selectedMaintenance = (sender as Button).CommandParameter as MaintenanceRequest;

            // Set DataContext for AddReceiptWorkDialog
            AddWorkReceiptDialog.DataContext = selectedMaintenance;

            // Show AddWorkReceiptDialog
            var result = await AddWorkReceiptDialog.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                // STEP 1: Create and save the WorkReceipt
                WorkReceipt workReceipt = new WorkReceipt
                (
                    DescriptionTextBox.Text,
                    DateTime.Now
                );
                using (var db = new AppDbContext())
                {
                    db.WorkReceipts.Add(workReceipt);
                    db.SaveChanges(); // Save to generate the ID

                    // STEP 2: Add selected materials to the pivot table
                    foreach (var material in MaterialList.SelectedItems.OfType<Material>())
                    {
                        var container = MaterialList.ContainerFromItem(material) as ListViewItem;
                        var quantityTextBox = (container.ContentTemplateRoot as StackPanel)?
                            .Children.OfType<TextBox>()
                            .FirstOrDefault(tb => tb.Name == "QuantityTextBox");


                        if (quantityTextBox != null && int.TryParse(quantityTextBox.Text, out int quantity) && quantity > 0)
                        {
                            ReceiptMaterial receiptMaterial = new ReceiptMaterial
                            {
                                ReceiptId = workReceipt.Id, // Use the newly created WorkReceipt's ID
                                MaterialId = material.Id,   // Use the Material's ID
                                Quantity = quantity         // Save the entered quantity
                            };
                            db.ReceiptMaterials.Add(receiptMaterial);
                        };
                    }

                    // Update the MaintenanceRequest with the new WorkReceiptId
                    selectedMaintenance.WorkReceiptId = workReceipt.Id;
                    db.Entry(selectedMaintenance).Property(m => m.WorkReceiptId).IsModified = true;

                    await db.SaveChangesAsync(); // Save all changes to the database
                }

                // Refresh the list to display updated data
                ShowClosedRequests();
            }
        }

        private void SendNotificationPurchasing()
        {

        }
        
        private DateTime selectedDate;
        private void CustomCalendar_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            if (args.AddedDates.Count > 0)
            {
                if (Session.Instance.User != null)
                {
                    selectedDate = args.AddedDates[0].DateTime;
                    this.Frame.Navigate(typeof(ViewDateDashboard), selectedDate);
                }
                else
                {
                    ShowError("Please log in to modify the calendar.");
                }
            }
            return;
        }

        private async void ShowError(string message)
        {
            var errorDialog = new ContentDialog
            {
                Title = "Attention",
                Content = message,
                CloseButtonText = "Ok",
                XamlRoot = this.XamlRoot
            };

            await errorDialog.ShowAsync();
        }

        private void CustomCalendar_CalendarViewDayItemChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs args)
        {
            if (Session.Instance.User != null)
            {
                if (args.Phase == 0)
                {
                    args.RegisterUpdateCallback(CustomCalendar_CalendarViewDayItemChanging);
                }
                else if (args.Phase == 1)
                {
                    if (plannedDates.ContainsKey(args.Item.Date.Date))
                    {
                        args.Item.Background = plannedDates[args.Item.Date.Date];
                    }
                }
                else
                {
                    args.Item.Background = null;
                }
            }
        }
    }
}