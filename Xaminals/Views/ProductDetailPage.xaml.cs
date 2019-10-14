using System;
using System.Linq;
using Xamarin.Forms;
using Xaminals.Data;

namespace Xaminals.Views
{
    [QueryProperty("Name", "name")]
    public partial class ProductDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = ProductData.Product.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public ProductDetailPage()
        {
            InitializeComponent();
        }
    }
}
