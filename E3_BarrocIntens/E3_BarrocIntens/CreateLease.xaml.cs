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
using E3_BarrocIntens.Data;
using E3_BarrocIntens.Data.Classes;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_BarrocIntens
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateLease : Page
    {
        public CreateLease()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                productCb.ItemsSource = db.Products.ToList();
            }
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
            int productId = productCb.SelectedIndex + 1;
            Product product = null;
            using (var db = new AppDbContext())
            {
                product = db.Products.FirstOrDefault(p => p.Id == productId);
            }
            if (product == null)
            {
                ShowError("Please select a valid product.");
                return;
            }


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
            LeaseContract leaseContract = new LeaseContract
            {
                ProductId = productId,
                UserId = 1,
                Type_Of_Time = typeOfTime,
                Amount_Of_Periods = repeatCount,
                End_Date = endDate,
                Total_Price = totalPrice,
                Price_Per_Period = pricePerPeriod,
                Time_Per_Period = timePerPeriod,
                Date_Created = startDate,
                Bkr_Check = (bool)bkrCheck,
                Payment_Status = "Unpaid"
            };

            using (var db = new AppDbContext())
            {
                db.LeaseContracts.Add(leaseContract);
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
