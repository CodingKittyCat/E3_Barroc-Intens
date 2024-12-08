using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using E3_BarrocIntens.Data;
using E3_BarrocIntens.Data.Classes;
using System.Linq;

namespace E3_BarrocIntens
{
    public sealed partial class CreateProductDashboard : Page
    {
        private object _selectedItem;

        public CreateProductDashboard()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            using (var db = new AppDbContext())
            {
                if (e.Parameter is Tuple<int, string> param)
                {
                    int itemId = param.Item1;
                    string type = param.Item2;

                    if (type == "Product")
                    {
                        var product = db.Products.Find(itemId);
                        if (product != null)
                        {
                            HandleProduct(product);
                            _selectedItem = product;
                        }
                    }
                    else if (type == "Material")
                    {
                        var material = db.Materials.Find(itemId);
                        if (material != null)
                        {
                            HandleMaterial(material);
                            _selectedItem = material;
                        }
                    }
                    else
                    {
                        ShowAddMode();
                    }
                }
                else
                {
                    ShowAddMode();
                }
            }
        }



        private void HandleProduct(Product product)
        {
            ShowEditMode();

            // Fill fields
            productTitle.Text = product.Title;
            productDescription.Text = product.Description;
            productStock.Text = product.Stock.ToString();
        }

        private void HandleMaterial(Material material)
        {
            productStockLabel.Text = "Quantity:";
            AddButton.Content = "Order Material";
            ShowAddMode();

            // Fill fields (adjust based on Material properties)
            productTitle.Text = material.Name;
            productDescription.Text = material.Description;
            productStock.Text = material.TotalQuantity.ToString();
        }

        private void ShowAddMode()
        {
            // Toggle buttons for adding new items
            AddButton.Visibility = Visibility.Visible;
            EditButton.Visibility = Visibility.Collapsed;

            // Clear fields
            productTitle.Text = string.Empty;
            productDescription.Text = string.Empty;
            productStock.Text = string.Empty;
        }

        private void ShowEditMode()
        {
            // Toggle buttons for editing existing items
            AddButton.Visibility = Visibility.Collapsed;
            EditButton.Visibility = Visibility.Visible;
        }

        private bool ValidateFields()
        {
            int stockAmount;

            // Validate fields
            if (string.IsNullOrWhiteSpace(productTitle.Text))
            {
                ShowError("Product name is required!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(productDescription.Text))
            {
                ShowError("Product description is required!");
                return false;
            }
            if (!int.TryParse(productStock.Text, out stockAmount))
            {
                ShowError("Enter a valid stock amount!");
                return false;
            }
            
            return true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateFields())
                return;

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

            // save product
            using (var db = new AppDbContext())
            {
                if (_selectedItem is Product)
                {
                    // Add a new product
                    var product = new Product
                    {
                        Title = productTitle.Text,
                        Description = productDescription.Text,
                        Stock = int.Parse(productStock.Text),
                        Status = ProductStatus.InStock
                    };
                    db.Products.Add(product);
                }
                else if (_selectedItem is Material material)
                {
                    var newQuantity = int.Parse(productStock.Text);

                    // Add the new quantity to the existing material's stock
                    material.Stock += newQuantity;

                    // Update the material in the database
                    db.Materials.Update(material);
                }

                // Save changes to the database
                db.SaveChanges();
            }

            RedirectToPurchasingDashboard();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateFields())
                return;

            using (var db = new AppDbContext())
            {
                if (_selectedItem is Product product)
                {
                    // Update product
                    product.Title = productTitle.Text;
                    product.Description = productDescription.Text;
                    product.Stock = int.Parse(productStock.Text);
                    db.Products.Update(product);
                }
                else if (_selectedItem is Material material)
                {
                    // Update material
                    material.Name = productTitle.Text;
                    material.Description = productDescription.Text;
                    productStock.Text = material.TotalQuantity.ToString();
                    db.Materials.Update(material);
                }

                db.SaveChanges();
            }

            RedirectToPurchasingDashboard();
        }

        private void ShowError(string message)
        {
            ErrorTextblock.Text = message;
            ErrorTextblock.Visibility = Visibility.Visible;
        }

        private void RedirectToPurchasingDashboard()
        {
            Frame.Navigate(typeof(PurchasingDashboard), 3);
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

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            RedirectToPurchasingDashboard();
        }
    }
}
