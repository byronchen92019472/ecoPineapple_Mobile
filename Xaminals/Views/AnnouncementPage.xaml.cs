using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using Xaminals.Models;

namespace Xaminals.Views
{
    public partial class AnnouncementPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public AnnouncementPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string announcetitle = (e.CurrentSelection.FirstOrDefault() as Announcement).Title;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"announcementdetails?name={announcetitle}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/bears/beardetails?name={bearName}");
        }
    }
}
