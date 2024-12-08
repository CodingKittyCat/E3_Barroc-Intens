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
    public sealed partial class AdminDashboard : Page
    {
        public AdminDashboard()
        {
            this.InitializeComponent();
            LoadItems();
        }

        private void approveBtn_Click(object sender, RoutedEventArgs e)
        {
            Product product = (sender as Button).CommandParameter as Product;
            product.Status = ProductStatus.PendingApproval;
            using (var db = new AppDbContext())
            {
                db.Products.Update(product);
                db.SaveChanges();
            }
            LoadItems();
        }

        private void LoadItems()
        {
            using (var db = new AppDbContext())
            {
                productsLv.ItemsSource = db.Products
                    .Where(product => product.Status == ProductStatus.PendingApproval)
                    .ToList();
            }
        }
    }
}
