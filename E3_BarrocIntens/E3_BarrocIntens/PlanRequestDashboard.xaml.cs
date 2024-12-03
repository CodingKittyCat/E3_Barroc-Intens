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
    public sealed partial class PlanRequestDashboard : Page
    {
        private DateTime requestDate;
        public PlanRequestDashboard()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            requestDate = (DateTime)e.Parameter;
            dateTbl.Text = "Planning date: " + requestDate.ToString("dd/MM/yyyy");
            using (var db = new AppDbContext())
            {
                maintenanceCb.ItemsSource = db.maintenanceRequests.ToList();
            }
        }

        private void planDateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (maintenanceCb.SelectedItem != null)
            {
                MaintenanceRequest maintenanceRequest = (MaintenanceRequest)maintenanceCb.SelectedItem;
                using (var db = new AppDbContext())
                {
                    db.maintenanceRequests.Attach(maintenanceRequest);
                    maintenanceRequest.PlannedDateTime = requestDate;
                    db.SaveChanges();
                }
                this.Frame.Navigate(typeof(ViewDateDashboard), requestDate);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewDateDashboard), requestDate);
        }
    }
}
