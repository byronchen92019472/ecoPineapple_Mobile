using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using Sustainability.Models;

namespace Sustainability.Views
{
    public partial class ProductSpace : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public ProductSpace()
        {
            InitializeComponent();
            BindingContext = this;
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string spacetitle = (e.CurrentSelection.FirstOrDefault() as Space).Name;
            await Shell.Current.GoToAsync($"spacedetails?name={spacetitle}");
        }
    }
}
