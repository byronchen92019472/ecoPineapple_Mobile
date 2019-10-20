using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class ProductData
    {
        public static IList<Product> Prod { get; private set; }

        static ProductData()
        {
            Prod = new List<Product>();

            Prod.Add(new Product
            {
                Name = "EcoCup",
                Details = "Cup made of recyclable materials",
                ImageSource = "sustain2.png",
                Cost = "$5.00",
                Supplier = "EcoSupplier1"
            });
        }
    }
}
