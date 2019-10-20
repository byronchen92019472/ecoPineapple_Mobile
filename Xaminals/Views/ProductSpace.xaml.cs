using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using Xaminals.Models;

namespace Xaminals.Views
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
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"spacedetails?name={spacetitle}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/bears/beardetails?name={bearName}");
        }
    }
}
