using System;
using System.Linq;
using Xamarin.Forms;
using Sustainability.Data;

namespace Sustainability.Views
{
    [QueryProperty("Name", "name")]
    public partial class ProductDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = ProductData.Prod.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public ProductDetailPage()
        {
            InitializeComponent();
        }
    }
}
