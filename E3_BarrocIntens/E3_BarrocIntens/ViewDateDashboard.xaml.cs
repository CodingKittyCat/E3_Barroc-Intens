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
    public sealed partial class ViewDateDashboard : Page
    {
        private DateTime selectedDate;
        public ViewDateDashboard()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            selectedDate = (DateTime)e.Parameter;
            dateTbl.Text = "Date: " + selectedDate.ToString("dd/MM/yyyy");
            refreshItems();
        }

        private void refreshItems()
        {
            using (var db = new AppDbContext())
            {
                planningLv.ItemsSource = db.maintenanceRequests
                    .Include(mr => mr.Product)
                    .Where(mr => mr.PlannedDateTime.Value.Date == selectedDate.Date && mr.UserId == Session.Instance.User.Id);
            }
        }
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            MaintenanceRequest maintenanceRequest = (sender as Button).CommandParameter as MaintenanceRequest;
            this.Frame.Navigate(typeof(RescheduleRequestDashboard), maintenanceRequest);
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            MaintenanceRequest maintenanceRequest = (sender as Button).CommandParameter as MaintenanceRequest;
            using (var db = new AppDbContext())
            {
                maintenanceRequest.UserId = null;
                maintenanceRequest.User = null;
                maintenanceRequest.PlannedDateTime = null;
                db.Update(maintenanceRequest);
                db.SaveChanges();
            }
            refreshItems();
        }

        private void createPlanningBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PlanRequestDashboard), selectedDate);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MaintenanceDashboard));
        }
    }
}
