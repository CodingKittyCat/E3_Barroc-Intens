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
using E3_BarrocIntens.Data.Classes;
using E3_BarrocIntens.Data;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_BarrocIntens
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddNotesDashboard : Page
    {
        List<UserNote> notes;
        User user;
        public AddNotesDashboard()
        {
            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            user = (User)e.Parameter;
            headerTbl.Text = "Notes for " + user.Name;

            RefreshNotes();
        }

        private void RefreshNotes()
        {
            using (var db = new AppDbContext())
            {
                notes = db.UserNotes.Where(note => note.UserId == user.Id).ToList();
            }
            noteLv.ItemsSource = notes;
        }


        private void noteAddBtn_Click(object sender, RoutedEventArgs e)
        {
            string noteText = noteTb.Text;
            if (string.IsNullOrEmpty(noteText))
            {
                return;
            }
            UserNote note = new UserNote
            {
                Note = noteText,
                UserId = user.Id
            };
            using (var db = new AppDbContext())
            {
                db.UserNotes.Add(note);
                db.SaveChanges();
            }
            RefreshNotes();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            UserNote userNote = (sender as Button).CommandParameter as UserNote;
            using (var db = new AppDbContext())
            {
                db.UserNotes.Remove(userNote);
                db.SaveChanges();
            }
            RefreshNotes();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SalesDashboard));
        }
    }
}
