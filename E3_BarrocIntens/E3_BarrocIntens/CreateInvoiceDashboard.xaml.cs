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
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_BarrocIntens
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateInvoiceDashboard : Page
    {
        public CreateInvoiceDashboard()
        {
            this.InitializeComponent();
        }

        private void CreateInvoiceButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Parse total amount
                if (!float.TryParse(TotalAmountTextBox.Text, out float totalAmount))
                {
                    ErrorTextblock.Text = "Invalid total amount. Please enter a valid number.";
                    return;
                }

                // Determine if the invoice is paid
                bool isPayed = IsPayedCheckBox.IsChecked ?? false; // Use a CheckBox for simplicity

                // Create the invoice
                using (var db = new AppDbContext())
                {
                    // Get customer by name
                    User customer = db.Users.FirstOrDefault(u => u.Username.ToLower() == CustomerNameTextBox.Text.ToLower());

                    // Check if customer exists
                    Invoice createdInvoice = new(
                        customer.Id, // Make use of Customer Id, instead of Name
                        DateTime.Now,
                        DueDatePicker.Date.DateTime,
                        totalAmount,
                        isPayed
                    );

                    db.Add(createdInvoice);
                    db.SaveChanges();

                    // Navigate back
                    this.Frame.Navigate(typeof(FinanceDashboard));
                }

                // Save the created invoice to the database (code for database save goes here)

                ErrorTextblock.Text = "Invoice created successfully!";
            }
            catch (Exception ex)
            {
                ErrorTextblock.Text = $"Error creating invoice: {ex.Message}";
            }
        }

        private void Error(string message)
        {
            ErrorTextblock.Text = message;
            ErrorTextblock.Visibility = Visibility.Visible;
        }
    }
}
