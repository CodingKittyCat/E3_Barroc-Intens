using E3_BarrocIntens.Data;
using E3_BarrocIntens.Data.Classes;
using E3_BarrocIntens.Modules;
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
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_BarrocIntens
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var username = UsernameInput.Text;
            var password = PasswordInput.Password;

            var user = await AuthenticateUserAsync(username, password);

            if (user != null)
            {
                Session.Instance.User = user;

                // Check if user is logging in for the first time
                if (user.IsFirstLogin)
                {
                    // Update first login
                    user.IsFirstLogin = false;

                    using (var db = new AppDbContext())
                    {
                        db.Users.Update(user);
                        await db.SaveChangesAsync();
                    }

                    // Show first login change password notice
                    ContentDialog dialog = new()
                    {
                        Title = "Notice",
                        Content = "This is your first time logging in! It is advised to change your password.",
                        PrimaryButtonText = "OK",
                        CloseButtonText = "Later",
                        XamlRoot = this.XamlRoot
                    };

                    ContentDialogResult result = await dialog.ShowAsync();

                    // Navigate to user profile dashboard.
                    if (result == ContentDialogResult.Primary)
                    {
                        this.Frame.Navigate(typeof(UserProfileDashboard));
                        return;
                    }
                }


                // Route to the appropriate dashboard based on the user's role
                Frame.Navigate(user.Role.RoleName switch
                {
                    "Customer" => typeof(CustomerDashboard),
                    "Finance" => typeof(FinanceDashboard),
                    "Sales" => typeof(SalesDashboard),
                    "Maintenance" => typeof(MaintenanceDashboard),
                    "Admin" => typeof(AdminDashboard),
                    _ => throw new InvalidOperationException("Role not recognized.")
                });
            }
            else
            {
                ContentDialog dialog = new ContentDialog
                {
                    Title = "Login Failed",
                    Content = "Invalid username or password.",
                    CloseButtonText = "OK",
                    XamlRoot = this.XamlRoot
                };
                await dialog.ShowAsync();
            }
        }

        private async Task<User> AuthenticateUserAsync(string username, string password)
        {
            using (var context = new AppDbContext())
            {
                var user = await context.Users.Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Username == username);

                if (user != null && PasswordHasher.VerifyPassword(password, user.Password))
                {
                    return user;
                }
            }
            return null;
        }
    }
}
