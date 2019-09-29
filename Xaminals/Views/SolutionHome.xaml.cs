using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xaminals.Views
{
    public partial class SolutionHome : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));

        public SolutionHome()
        {
            InitializeComponent();
            BindingContext = this;

            SolutionHomeText1.Text =
                "There is no single solution to solve sustainability issues. It is not possible" +
                " to just live our lives and buy eco-friendly products to solve this problem. " +
                "However, by increasing everybody’s awareness in how we are damaging our " +
                "environment is a great starting point to tackle these issues.";

            SolutionHomeText2.Text =
                "Solving these" +
                " issues will require a comprehensive and global approach, where we as a society" +
                " needs to rethink about topics such as manufacturing materials, recycling" +
                " procedures, national policies, and consumer preferences. We must be able to " +
                "implement all the best practices, whilst still look for better solutions at the" +
                " same time. The EPA has recognised that the key to sustainability is to develop" +
                " technology and biotechnology. There also needs to be a dynamic and competitive" +
                " industry that helps push innovation for sustainability, either by providing" +
                " incentives for customers or businesses.\n\nAn effective way of reducing the " +
                "climate crisis would be in the form of taxation. By taxing aspects involved " +
                "with manufacturing offending products, companies would likely pursue " +
                "alternatives to avoid these taxes. This is a quick and drastic solution to " +
                "change our spending habits.";

        }
    }
}
