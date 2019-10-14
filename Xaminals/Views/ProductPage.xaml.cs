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
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"productdetails?name={producttitle}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/bears/beardetails?name={bearName}");
        }
    }
}
