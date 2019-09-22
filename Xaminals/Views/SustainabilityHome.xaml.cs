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

            //SustainabilityTextBody.Text = 
            //    "Sustainability issues include a fast-expanding and resource-hungry human " +
            //    "population, fossil-fuel burning that accelerates global warming, the imminent peak" +
            //    " in cheap oil production (when total demand exceeds easily-affordable supply) and" +
            //    " persistent pollutant chemicals and plastics being spread globally in air and oceans." +
            //    " Humans are displacing other life on the planet, speeding extinction of many species," +
            //    " including here in New Zealand.";
        }
    }
}
