using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xaminals.Views
{
    public partial class PrivacyPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public PrivacyPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
