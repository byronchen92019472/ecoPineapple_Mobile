using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xaminals.Data;
using Xaminals.Views;

namespace Xaminals
{
    public partial class AppShell : Shell
    {
        readonly Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        void RegisterRoutes()
        {
            routes.Add("productdetails", typeof(ProductDetailPage));
            routes.Add("spacedetails", typeof(ProductSpaceDetailPage));
            Routing.RegisterRoute("sustainability", typeof(SustainabilityHome));
            Routing.RegisterRoute("solution", typeof(SolutionHome));
            Routing.RegisterRoute("product", typeof(ProductHome));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}
