using System;
using System.Linq;
using Xamarin.Forms;
using Xaminals.Data;

namespace Xaminals.Views
{
    [QueryProperty("Name", "name")]
    public partial class AnnouncementDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = AnnouncementData.Announce.FirstOrDefault(m => m.Title == Uri.UnescapeDataString(value));
            }
        }

        public AnnouncementDetailPage()
        {
            InitializeComponent();
        }
    }
}
