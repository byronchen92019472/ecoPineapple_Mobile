using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sustainability.Views
{
    public partial class SustainabilityClimate : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public SustainabilityClimate()
        {
            InitializeComponent();
            BindingContext = this;

            SustainabilityClimateText1.Text =
                "The climate is being affected by the amount of greenhouse gas emissions we" +
                " produce.\n\nOur emission levels are now the highest it has ever been in " +
                "history. Weather patterns are now rapidly changing, where weather events are" +
                " becoming more severe and the sea levels are rising. These will have " +
                "environmental impacts that will disrupt people’s livelihoods and also disrupt" +
                " the economy.This is now, and in the future, a detriment to all people," +
                " communities and the entire world.\n\nNowadays, with the alarming data that " +
                "scientists have gathered regarding climate change, it has already convinced " +
                "the average individual to reflect on their own footprint and their capacity " +
                "to make a change.";

            SustainabilityClimateText2.Text =
                "While most people believe in climate change, a large majority still does not" +
                " worry about the effects. One of the many reasons for this discrepancy is that" +
                " climate science usually discusses notable temperature shifts for more extreme" +
                " environments.Most climate change reports often regard the Arctic, or other " +
                "places far away, that have no real impact in most people’s lives.";
        }
    }
}
