using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class ProductData
    {
        public static IList<Product> Prod { get; private set; }

        static ProductData()
        {
            Prod = new List<Product>
            {
                new Product
                {
                    Name = "EcoCup",
                    Details = "Cup made of recyclable materials",
                    ImageSource = "sustain1.png",
                    Cost = "$3.00",
                    Supplier = "EcoSupplier1"
                },

                new Product
                {
                    Name = "EcoBowl",
                    Details = "Bowl made of recyclable materials",
                    ImageSource = "sustain2.png",
                    Cost = "$5.00",
                    Supplier = "EcoSupplier1"
                },

                new Product
                {
                    Name = "EcoContainer",
                    Details = "Container made of recyclable materials",
                    ImageSource = "sustain3.png",
                    Cost = "$5.00",
                    Supplier = "EcoSupplier2"
                },

                new Product
                {
                    Name = "EcoCutlery",
                    Details = "Cutlery made of recyclable materials",
                    ImageSource = "sustain4.png",
                    Cost = "$8.00",
                    Supplier = "EcoSupplier2"
                }
            };
        }
    }
}
