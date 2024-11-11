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
using Windows.Security.ExchangeActiveSyncProvisioning;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_BarrocIntens
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditLease : Page
    {
        int LeaseId { get; set; }
        Lease_Contracts LeaseContract;
        private readonly BarrocIntensDataContext _context = new BarrocIntensDataContext();

        public EditLease()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is int leaseId)
            {
                LeaseId = leaseId;
            }
            using (BarrocIntensDataContext dataContext = new BarrocIntensDataContext())
            {
                LeaseContract = dataContext.Lease_Contracts.FirstOrDefault(lc => lc.Id == LeaseId);
            }

            productTb.Text = LeaseContract.Product;
            companyCb.SelectedIndex = LeaseContract.Company_Id - 1; // -1 because database id is 1 indexed
            durationSelectTb.Text = LeaseContract.Time_Per_Period.ToString();
            durationSelectCb.SelectedIndex = LeaseContract.Type_Of_Time == "Periodic (Days)"
                                            ? 0
                                            : LeaseContract.Type_Of_Time == "Periodic (Weeks)"
                                            ? 1
                                            : 2;

            repeatTb.Text = LeaseContract.Amount_Of_Periods.ToString();
            invoiceTypeCb.SelectedIndex = LeaseContract.Type_Of_Time == "Monthly"
                                         ? 0
                                         : 1;

            bkrChb.IsChecked = LeaseContract.Bkr_Check;
            priceTb.Text = LeaseContract.Price_Per_Period.ToString();

        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            string product = productTb.Text;
            if (string.IsNullOrWhiteSpace(product))
            {
                ShowError("Please enter a valid product name.");
                return;
            }

            int companyId = companyCb.SelectedIndex + 1;

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
            bool? bkrCheck = bkrChb.IsChecked;
            if (bkrCheck == null)
            {
                ShowError("Please select a BKR check status.");
                return;
            }

            LeaseContract.Product = product;
            LeaseContract.Company_Id = companyId;
            LeaseContract.Type_Of_Time = typeOfTime;
            LeaseContract.Amount_Of_Periods = repeatCount;
            LeaseContract.End_Date = endDate;
            LeaseContract.Total_Price = totalPrice;
            LeaseContract.Price_Per_Period = pricePerPeriod;
            LeaseContract.Time_Per_Period = timePerPeriod;
            LeaseContract.Date_Created = startDate;
            LeaseContract.Bkr_Check = (bool)bkrCheck;
            LeaseContract.Payment_Status = "Unpaid";

            using (BarrocIntensDataContext db = new BarrocIntensDataContext())
            {
                db.Lease_Contracts.Update(LeaseContract);
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
    }
}
