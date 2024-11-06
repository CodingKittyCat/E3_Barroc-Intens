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
        private void invoiceTypeCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // check if the combobox and the stackpanel are not null
            if (invoiceTypeCb != null && selectLengthSp != null)
            {
                // get the selected item from the combobox and cast it to a ComboBoxItem
                ComboBoxItem comboBoxItem = (ComboBoxItem)invoiceTypeCb.SelectedItem;
                // check if the content of the combobox item is not null or empty and if the content is equal to "Periodic"
                if (!string.IsNullOrEmpty(comboBoxItem.Content.ToString()) && comboBoxItem.Content.ToString() == "Periodic")
                {
                    // set the visibility of the stackpanel to visible
                    selectLengthSp.Visibility = Visibility.Visible;
                }
                else
                {
                    // set the visibility of the stackpanel to collapsed
                    selectLengthSp.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            int companyId = companyCb.SelectedIndex;

        }
    }
}
