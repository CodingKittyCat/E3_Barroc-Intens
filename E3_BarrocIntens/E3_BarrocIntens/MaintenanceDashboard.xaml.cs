using System;
using System.Linq;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using E3_BarrocIntens.Data.Classes;
using E3_BarrocIntens.Data;
using Microsoft.UI;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.UI.Xaml.Media;
using E3_BarrocIntens.Modules;

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
                        .ToList() // Fetch all MaintenanceRequests from the database to the client
                        .Where(mr => mr.PlannedDateTimes != null) // Ensure PlannedDateTimes is not null
                        .SelectMany(mr => mr.PlannedDateTimes, (mr, date) => date.Date) // Flatten the collection and select only the date
                        .GroupBy(date => date) // Group by date (ignoring time)
                        .ToDictionary(
                            group => group.Key,                         // Use the date as the key
                            group => new SolidColorBrush(Colors.Yellow) // Assign a color to the date
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

        private async void setToClosed_Click(object sender, RoutedEventArgs e)
        {
            //return;
            using (var db = new AppDbContext())
            {
                // Load maintenance workers to select from
                var requests = db.maintenanceRequests
                    .Where(mr => mr.IsClosed == false)
                    .ToList();

                AppointmentNameTextBox.ItemsSource = requests;
                AppointmentNameTextBox.DisplayMemberPath = "Description"; // Display user name in ListBox
                AppointmentNameTextBox.SelectedValuePath = "Id"; // Use user ID as selected value
            }

      

                var result = await SetAppointmentToClosedDialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                // Get selected worker ID
                int selectedRequestId = (int)AppointmentNameTextBox.SelectedValue;

                using (var db = new AppDbContext())
                {
                    // Load the selected user
                    var selectedRequest = db.maintenanceRequests.FirstOrDefault(mr => mr.Id == selectedRequestId);

                    if (selectedRequest != null)
                    {
                        // Update the MaintenanceRequest with the selected user
                        selectedRequest.IsClosed = true;

                        db.maintenanceRequests.Attach(selectedRequest);
                        db.Entry(selectedRequest).Property(mr => mr.IsClosed).IsModified = true;

                        await db.SaveChangesAsync();
                    }
                }

                // Refresh the list to display updated data
                ShowOpenRequests();
                ShowClosedRequests();
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
                            // Check if there is enough stock
                            var materialInDb = db.Materials.FirstOrDefault(m => m.Id == material.Id); // get the material for easy modifying
                            if (materialInDb != null && materialInDb.Stock >= quantity)
                            {
                                // Deduct the quantity from the stock
                                materialInDb.Stock -= quantity;

                                ReceiptMaterial receiptMaterial = new ReceiptMaterial
                                {
                                    ReceiptId = workReceipt.Id, // Use the newly created WorkReceipt's ID
                                    MaterialId = material.Id,   // Use the Material's ID
                                    Quantity = quantity         // Save the entered quantity
                                };
                                db.ReceiptMaterials.Add(receiptMaterial);
                            }
                            else
                            {
                                return; // Exit early to prevent partial updates
                            }
                        }
                    }

                    // Update the MaintenanceRequest with the new WorkReceiptId
                    selectedMaintenance.WorkReceiptId = workReceipt.Id;
                    db.Entry(selectedMaintenance).Property(m => m.WorkReceiptId).IsModified = true;

                    await db.SaveChangesAsync(); // Save all changes to the database

                    // Email head of maintenance with the work receipt
                    string email = db.Users.FirstOrDefault(u => u.Username == "headmaintenance").Email;
                    if (email != null)
                    {
                        // Get the email subject
                        string emailSubject = $"Maintenance Work Receipt #{workReceipt.Id}";

                        // Create the email body
                        string emailBody = $"The work receipt for the maintenance request #{selectedMaintenance.Id} has been created.\n\n";
                        emailBody += $"Description: {workReceipt.Description}\n\n";
                        emailBody += "Materials used:\n";

                        // Get the materials used in the work receipt
                        foreach (var receiptMaterial in db.ReceiptMaterials.Where(rm => rm.ReceiptId == workReceipt.Id).Include(rm => rm.Material))
                        {
                            emailBody += $"- {receiptMaterial.Material.Name}: {receiptMaterial.Quantity}x\n";
                        }

                        // send email to head of maintenance
                        new QuoteGenerator().SendEmail(email, emailSubject, emailBody);
                    }
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