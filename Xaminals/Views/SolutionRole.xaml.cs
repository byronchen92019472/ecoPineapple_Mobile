using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sustainability.Views
{
    public partial class SolutionRole : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public SolutionRole()
        {
            InitializeComponent();
            BindingContext = this;

            SolutionRoleText1.Text =
                "While being a single contributor for sustainability may feel insubstantial, we" +
                " all still have a role to play. We need to actively find solutions for " +
                "sustainability that helps people, the industry and the environment.\n\nWhen " +
                "dealing with climate change, a large majority of people have this feeling of " +
                "hopelessness. Every small gesture you make; such as not using a car to get to " +
                "work, using reusable shopping bags, consuming less meat may seem useless as an " +
                "individual.However, when this attitude spreads to a global scale, real changes " +
                "can be made."; 

             SolutionRoleText2.Text =
                "What we need to do is to coordinate at an international level to drive " +
                "countries towards a low-carbon economy. The only way to see this through is to" +
                " vote for a political party that strives to create an environmental sustainable" +
                " economy. If you want to voice your displeasure on how slow these changes are " +
                "being implemented, go and participate in your local climate protests.";
        }
    }
}
