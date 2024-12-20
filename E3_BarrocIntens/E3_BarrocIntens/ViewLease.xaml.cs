using E3_BarrocIntens.Data;
using E3_BarrocIntens.Data.Classes;
using Microsoft.EntityFrameworkCore;
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
    public sealed partial class ViewLease : Page
    {
        int LeaseId;
        LeaseContract leaseContract;
        public ViewLease()
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
            using (var dataContext = new AppDbContext())
            {
                leaseContract = dataContext.LeaseContracts.Include(leaseContract => leaseContract.Product).FirstOrDefault(lc => lc.Id == LeaseId);
            }
            Product product = leaseContract.Product;
            headerTbl.Text = $"#{leaseContract.Id} - {leaseContract.Product.Title}";

            if (leaseContract.Type_Of_Time == "Monthly")
            {
                leaseTypeTbl.Text = leaseContract.Type_Of_Time;
            }
            else
            {
                string timeType = leaseContract.Type_Of_Time.Replace("Periodic (", "");
                leaseTypeTbl.Text = $"Periodic (Every {leaseContract.Time_Per_Period} {timeType}";
            }

            pricePerPeriodTbl.Text = $"{leaseContract.Price_Per_Period} EUR (Total {leaseContract.Total_Price} EUR)";
            bkrCheckTbl.Text = leaseContract.Bkr_Check ? "BKR Check: Passed" : "BKR Check: Failed";
            startDateTbl.Text = $"Start: {leaseContract.Date_Created.Value.ToString("dd/MM/yyyy")}";
            endDateTbl.Text = $"End: {leaseContract.End_Date.Value.ToString("dd/MM/yyyy")}";
            paymentStatusTbl.Text = leaseContract.Payment_Status;
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EditLease), leaseContract.Id);
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            using (AppDbContext dataContext = new AppDbContext())
            {
                leaseContract.Product.Stock += 1; // Add 1 to product stock because its not being used anymore
                dataContext.Products.Update(leaseContract.Product);
                dataContext.LeaseContracts.Remove(leaseContract);
                dataContext.SaveChanges();
            }
            this.Frame.Navigate(typeof(CustomerDashboard));
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CustomerDashboard));
        }
    }
}
