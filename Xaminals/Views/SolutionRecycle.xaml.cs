using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sustainability.Views
{
    public partial class SolutionRecycle : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public SolutionRecycle()
        {
            InitializeComponent();
            BindingContext = this;

            SolutionRecycleText1.Text =
                "There are billions of units of packaging being produced every year. The biggest" +
                " offender to recycling is from the mass production of plastics and most of this" +
                " is not recyclable. Our fault is that big brands are persuading us to buy their" +
                " overly packaged products. You can help fight for sustainability by rejecting" +
                " products that are overly packaged, made from non-recyclable materials, plastic" +
                " bags, and bottled water.\n\nMost of the recycling industry does not have the " +
                "time or patience to mass recycle mixed component materials.People still tend to" +
                " agree that the cost of recycling is usually greater than creating a new product.";

            SolutionRecycleText2.Text =
                "However, the recycling industry is quickly changing with the help of product" +
                " design and materials science. Recycling is still extremely important to help " +
                "fight sustainability issues. It is a valuable tool to fight against climate" +
                " change, pollution and other environmental issues that the planet faces. It " +
                "helps reduce litter and helps repurpose materials whilst also reducing " +
                "greenhouse gas emissions and conserving more energy and water.";
        }
    }
}
