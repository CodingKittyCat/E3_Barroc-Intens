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

            if (!int.TryParse(priceTb.Text, out int pricePerPeriod) || pricePerPeriod <= 0)
            {
                ShowError("Please enter a valid price.");
                return;
            }


            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate;

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


            int totalPrice = pricePerPeriod * repeatCount;

            Lease_Contracts leaseContract = new Lease_Contracts
            {
                Product = product,
                Company_Id = companyId,
                Type_Of_Time = typeOfTime,
                End_Date = endDate,
                Total_Price = totalPrice,
                Price_Per_Period = pricePerPeriod,
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

        private async void ShowError(string message)
        {
            var errorDialog = new ContentDialog
            {
                Title = "Invalid Value",
                Content = message,
                CloseButtonText = "Ok",
                XamlRoot = this.XamlRoot 
            };

            await errorDialog.ShowAsync(); 
        }
    }
}
