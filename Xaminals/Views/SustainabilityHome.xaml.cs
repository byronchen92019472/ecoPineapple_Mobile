using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xaminals.Views
{
    public partial class SustainabilityHome : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public SustainabilityHome()
        {
            InitializeComponent();
            BindingContext = this;

            SustainabilityHomeText1.Text = "Sustainability is a broad term that essentially means" +
                " the capacity to endure. In this app, we will be addressing sustainability in" +
                " terms of protecting the natural environment.";

            SustainabilityHomeText2.Text = "A large majority of people perceive" +
                " that the environment is self-sustaining, with its ability to rejuvenate itself." +
                " The natural cycle of a plant dying, decomposing, and then providing nutrients for" +
                " other plants has been taught to us at a young age.\n\nHowever, sustainability is now" +
                " necessary to help strive for a greener future. The main issues we address in this" +
                " app are the effects of climate change and our single-use plastics being littered" +
                " around our environment. We need to be able to confront these issues by avoiding the" +
                " exhaustion or degradation of our resources.";
        }
    }
}
