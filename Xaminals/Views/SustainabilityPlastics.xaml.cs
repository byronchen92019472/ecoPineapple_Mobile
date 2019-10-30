using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sustainability.Views
{
    public partial class SustainabilityPlastic : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public SustainabilityPlastic()
        {
            InitializeComponent();
            BindingContext = this;

            SustainabilityPlasticText1.Text =
                "Plastic can take hundreds and even thousands of years to decompose. Once it" +
                " does break down, it only breaks down to smaller toxic fragments where it " +
                "pollutes the environment even further.";

            SustainabilityPlasticText2.Text =
                "A 2017 study from the peer-review journal Science Advances showed analysis of " +
                "all the plastics ever made.The study showed that since the rapid production of " +
                "plastics, there has been 8.3 billion metric tons of plastic produced. The " +
                "shocking part is that 76 % of that has become plastic waste. 79 % of that " +
                "waste is currently in landfills or is littered around the environment. A 2015" +
                " study from Sciences Advances estimated that there was 8 million tons of " +
                "plastic ending up in the oceans every year. Plastic is currently the most " +
                "man-made material, whilst also being the most thrown away.The study showed " +
                "that HALF of all plastic manufactured becomes trash in less than a year.\n\nAs " +
                "a society, we need to accept that our convenience may be hindered when we find" +
                " a better solution for managing our plastic use.";
        }
    }
}
