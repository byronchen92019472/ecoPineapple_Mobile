using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xaminals.Views
{
    public partial class ProductHome : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public ProductHome()
        {
            InitializeComponent();
            BindingContext = this;

            ProductHomeText.Text =
                "We here at ecoPineapple are fully committed to promote sustainability.\n\nBy " +
                "purchasing" +
                " from our store, you will be able to share your sustainability journey with " +
                "your friends and family. Hopefully, this helps inspire them to be become more" +
                " sustainable. You will also be doing your small part in purchasing an eco-" +
                "friendly product.\n\nOur goal is to expand the markets where recyclables are sold" +
                " and to provide more resources to educate customers on the rights and wrongs of" +
                " recycling.\n\nOur products are all made from recycled materials and have a " +
                "minimal environmental burden. Each item strives to have a second life to avoid" +
                " being sent to the landfill.\n\nUse the top-navigational bar to browse our " +
                "product categories on offer.";
        }
    }
}
