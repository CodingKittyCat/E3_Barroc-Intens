using E3_BarrocIntens.Model;
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
            double totalAmount;
            double paidAmount;
            double outstandingBalance;

            // validate fields
            if (string.IsNullOrEmpty(CustomerNameTextBox.Text))
            {
                Error("Please enter a customer name.");
                return;
            }
            else if (DueDatePicker.Date == null || DueDatePicker.Date < DateTime.Now)
            {
                Error("Please enter a valid due date.");
                return;
            }
            else if (!double.TryParse(TotalAmountTextBox.Text, out totalAmount))
            {
                Error("Please enter a valid total amount.");
                return;
            }
            else if (!double.TryParse(PaidAmountTextBox.Text, out paidAmount))
            {
                Error("Please enter a valid paid amount.");
                return;
            }
            else if (!double.TryParse(OutstandingBalanceTextBox.Text, out outstandingBalance))
            {
                Error("Please enter a valid outstanding balance.");
                return;
            }
            else if (string.IsNullOrEmpty(StatusTextBox.Text))
            {
                Error("Please enter a status.");
                return;
            }
            else if (string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                Error("Please enter a description.");
                return;
            }

            // create invoice
            Invoice createdInvoice = new()
            {
                CustomerName = CustomerNameTextBox.Text,
                InvoiceDate = DateTime.Now,
                DueDate = DueDatePicker.Date.DateTime,
                TotalAmount = totalAmount,
                PaidAmount = paidAmount,
                OutstandingBalance = outstandingBalance,
                Status = StatusTextBox.Text,
                Description = DescriptionTextBox.Text
            };

            // TO DO : save invoice to database
        }

        private void Error(string message)
        {
            ErrorTextblock.Text = message;
            ErrorTextblock.Visibility = Visibility.Visible;
        }
    }
}
