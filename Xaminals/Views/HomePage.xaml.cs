using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xaminals.Views
{
    public partial class HomePage : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public HomePage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void AnnouncementButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnnouncementPage());
        }

        private async void AccessibilityButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccessibilityPage());
        }

        private async void PrivacyButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrivacyPage());
        }

        private async void ContactButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactPage());
        }
    }
}
