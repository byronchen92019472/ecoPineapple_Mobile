using System;
using System.Linq;
using Xamarin.Forms;
using Sustainability.Data;

namespace Sustainability.Views
{
    [QueryProperty("Name", "name")]
    public partial class ProductSpaceDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = SpaceData.Sp.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public ProductSpaceDetailPage()
        {
            InitializeComponent();
        }
    }
}
