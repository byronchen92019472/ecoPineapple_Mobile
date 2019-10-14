using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class ProductData
    {
        public static IList<Product> Product { get; private set; }

        static ProductData()
        {
            Product = new List<Product>();

            Product.Add(new Product
            {
                Name = "Eco Cup",
                Details = "Cup made of recyclable materials",
                ImageSource = "sustain2.png",
                Cost = "$5.00",
                Supplier = "Eco Supplier"
            });
        }
    }
}
