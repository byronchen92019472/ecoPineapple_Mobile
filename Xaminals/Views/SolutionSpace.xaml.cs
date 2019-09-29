using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xaminals.Views
{
    public partial class SolutionSpace : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public SolutionSpace()
        {
            InitializeComponent();
            BindingContext = this;

            SolutionSpaceText1.Text = 
                "Paraphrasing the late Stephen Hawking, the only thing that may save us from " +
                "ourselves is to spread out into space. As of now, the possibility of us living" +
                " off-world is just a fantasy.With that in mind, people should definitely be" +
                " worried with how we treat our planet.";

            SolutionSpaceText2.Text =
                 "Humanity is already facing a catastrophe and this would result in our " +
                 "extinction if we do not act now. If we do not have the capacity to achieve " +
                 "sustainability, then we will not be able to coexist with the planet. If you " +
                 "think it is more convenient and cost-efficient to just ignore sustainability," +
                 " then compare this to the alternative: to abandon Earth and find another " +
                 "location for us to inhabit.";
        }
    }
}
