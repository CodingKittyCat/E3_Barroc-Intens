using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using E3_BarrocIntens.Data;

namespace E3_BarrocIntens
{
    public sealed partial class CreateLease : Page
    {
        public CreateLease()
        {
            this.InitializeComponent();
        }

        private void invoiceTypeCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (invoiceTypeCb != null && selectLengthSp != null)
            {
                ComboBoxItem selectedComboBoxItem = (ComboBoxItem)invoiceTypeCb.SelectedItem;
                selectLengthSp.Visibility = selectedComboBoxItem.Content.ToString() == "Periodic"
                                            ? Visibility.Visible
                                            : Visibility.Collapsed;
            }
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            string product = productTb.Text;
            if (string.IsNullOrWhiteSpace(product))
            {
                ShowError("Please enter a valid product name.");
                return;
            }

            int companyId = companyCb.SelectedIndex;

            string typeOfTime = "Monthly";
            int timePerPeriod = 1;

            if (!int.TryParse(repeatTb.Text, out int repeatCount) || repeatCount <= 0)
            {
                ShowError("Please enter a valid repeat count.");
                return;
            }

            if (invoiceTypeCb.SelectedIndex != 0)
            {
                switch (durationSelectCb.SelectedIndex)
                {
                    case 0:
                        typeOfTime = "Periodic (Days)";
                        break;
                    case 1:
                        typeOfTime = "Periodic (Weeks)";
                        break;
                    case 2:
                        typeOfTime = "Periodic (Months)";
                        break;
                }

                if (!int.TryParse(durationSelectTb.Text, out timePerPeriod) || timePerPeriod <= 0)
                {
                    ShowError("Please enter a valid duration for the period.");
                    return;
                }
            }

            if (!int.TryParse(priceTb.Text, out int basePricePerPeriod) || basePricePerPeriod <= 0)
            {
                ShowError("Please enter a valid price.");
                return;
            }

            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate;
            int totalPeriods = repeatCount;

            // Calculate end date based on repeat count and type of time
            switch (typeOfTime)
            {
                case "Monthly":
                    endDate = startDate.AddMonths(repeatCount);
                    break;
                case "Periodic (Weeks)":
                    endDate = startDate.AddDays(7 * repeatCount);
                    break;
                case "Periodic (Days)":
                    endDate = startDate.AddDays(repeatCount);
                    break;
            }

            // Calculate effective price per period based on duration frequency within the time type
            double adjustedPricePerPeriod = basePricePerPeriod;
            if (typeOfTime == "Periodic (Days)")
            {
                adjustedPricePerPeriod = basePricePerPeriod / (double)timePerPeriod;
            }
            else if (typeOfTime == "Periodic (Weeks)")
            {
                adjustedPricePerPeriod = basePricePerPeriod / (7.0 / timePerPeriod);
            }
            else if (typeOfTime == "Monthly")
            {
                adjustedPricePerPeriod = basePricePerPeriod / (30.0 / timePerPeriod);
            }

            double totalPrice = adjustedPricePerPeriod * totalPeriods;

            Lease_Contracts leaseContract = new Lease_Contracts
            {
                Product = product,
                Company_Id = companyId,
                Type_Of_Time = typeOfTime,
                End_Date = endDate,
                Total_Price = Math.Round(totalPrice, 2),
                Price_Per_Period = Math.Round(adjustedPricePerPeriod, 2),
                Time_Per_Period = timePerPeriod,
                Date_Created = startDate,
                Payment_Status = "Unpaid"
            };

            using (BarrocIntensDataContext db = new BarrocIntensDataContext())
            {
                db.Lease_Contracts.Add(leaseContract);
                db.SaveChanges();
            }

            this.Frame.Navigate(typeof(CustomerDashboard));
        }

        private void ShowError(string message)
        {
            ContentDialog errorDialog = new ContentDialog
            {
                Title = "Error",
                Content = message,
                CloseButtonText = "Ok"
            };
            _ = errorDialog.ShowAsync();
        }
    }
}
