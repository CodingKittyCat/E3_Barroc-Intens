using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using E3_BarrocIntens.Data;
using E3_BarrocIntens.Data.Classes;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_BarrocIntens
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateProductDashboard : Page
    {
        Product _selectedProduct;

        public CreateProductDashboard()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is int productId)
            {
                using (var db = new AppDbContext())
                {
                    _selectedProduct = db.Products.Find(productId);
                }

                if (_selectedProduct != null)
                {
                    // toggle buttons
                    AddButton.Visibility = Visibility.Collapsed;
                    EditButton.Visibility = Visibility.Visible;
                    DeleteButton.Visibility = Visibility.Visible;

                    // Fill fields
                    productTitle.Text = _selectedProduct.Title;
                    productDescription.Text = _selectedProduct.Description;
                    productStock.Text = _selectedProduct.Stock.ToString();
                    productStatus.SelectedValue = _selectedProduct.Status;
                }
                else
                {
                    // toggle buttons
                    AddButton.Visibility = Visibility.Visible;
                    EditButton.Visibility = Visibility.Collapsed;
                    DeleteButton.Visibility = Visibility.Collapsed;
                }
            }
        }

        private bool ValidateFields()
        {
            int stockAmount;

            // validate fields
            if (string.IsNullOrWhiteSpace(productTitle.Text))
            {
                Error("Product name is required!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(productDescription.Text))
            {
                Error("Product description is required!");
                return false;
            }
            else if (!int.TryParse(productStock.Text, out stockAmount))
            {
                Error("Enter a valid stock amount!");
                return false;
            }
            else if (productStatus.SelectedItem == null)
            {
                Error("Select a status!");
                return false;
            }

            return true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            // create product
            Product product = new Product
            {
                Title = productTitle.Text,
                Description = productDescription.Text,
                Stock = int.Parse(productStock.Text),
            };

            if (product.Stock >= 5000)
            {
                ShowNotification("This order will have to be approved by an administrator\nfor having more than 5000 orders.");
                product.Status = "Pending Approval";
            }
            else
            {
                product.Status = productStatus.SelectionBoxItem.ToString();
            }

            // save product
            using (var db = new AppDbContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }

            RedirectToPurchasingDashboard();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateFields() || _selectedProduct == null)
            {
                return;
            }

            // update product
            _selectedProduct.Title = productTitle.Text;
            _selectedProduct.Description = productDescription.Text;
            _selectedProduct.Stock = int.Parse(productStock.Text);


            if (_selectedProduct.Stock >= 5000)
            {
                ShowNotification("This order will have to be approved by an administrator\nfor having more than 5000 orders.");
                _selectedProduct.Status = "Pending Approval";
            }
            else
            {
                _selectedProduct.Status = productStatus.SelectionBoxItem.ToString();
            }

            // save product
            using (var db = new AppDbContext())
            {
                db.Products.Update(_selectedProduct);
                db.SaveChanges();
            }

            RedirectToPurchasingDashboard();
        }

        private void Error(string message)
        {
            ErrorTextblock.Text = message;
            ErrorTextblock.Visibility = Visibility.Visible;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedProduct == null)
            {
                return;
            }

            // delete product
            using (var db = new AppDbContext())
            {
                db.Products.Remove(_selectedProduct);
                db.SaveChanges();
            }

            RedirectToPurchasingDashboard();
        }

        private void RedirectToPurchasingDashboard()
        {
            this.Frame.Navigate(typeof(PurchasingDashboard), 3); // Navigate to PurchasingDashboard.
        }

        private async void ShowNotification(string message)
        {
            var errorDialog = new ContentDialog
            {
                Title = "Attention",
                Content = message,
                CloseButtonText = "Ok",
                XamlRoot = this.XamlRoot
            };

            await errorDialog.ShowAsync();
        }
    }
}
