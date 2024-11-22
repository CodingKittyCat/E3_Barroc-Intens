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
    public sealed partial class RescheduleRequestDashboard : Page
    {
        MaintenanceRequest maintenanceRequest;
        DateTime previousDateTime;
        public RescheduleRequestDashboard()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            maintenanceRequest = (MaintenanceRequest)e.Parameter;
            previousDateTime = maintenanceRequest.PlannedDateTime.Value;

            requestProduct.Text = maintenanceRequest.Product.Title;
            requestDescription.Text = maintenanceRequest.Description;
            requestDate.Date = maintenanceRequest.PlannedDateTime.Value;

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewDateDashboard), previousDateTime);
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                maintenanceRequest.PlannedDateTime = requestDate.Date.DateTime;
                db.maintenanceRequests.Update(maintenanceRequest);
                db.SaveChanges();
            }
            this.Frame.Navigate(typeof(ViewDateDashboard), previousDateTime);
        }
    }
}
