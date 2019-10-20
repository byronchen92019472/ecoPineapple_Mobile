using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using Xaminals.Models;

namespace Xaminals.Views
{
    public partial class ProductPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public ProductPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string producttitle = (e.CurrentSelection.FirstOrDefault() as Product).Name;
            await Shell.Current.GoToAsync($"productdetails?name={producttitle}");
        }
    }
}
