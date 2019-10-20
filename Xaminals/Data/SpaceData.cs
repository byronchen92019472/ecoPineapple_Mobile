using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class SpaceData
    {
        public static IList<Space> Sp { get; private set; }

        static SpaceData()
        {
            Sp = new List<Space>();

            Sp.Add(new Space
            {
                Name = "HyperX",
                Details = "This trip will take you to Mars",
                ImageSource = "falconheavy.png",
                Cost = "$50000000",
                Supplier = "SpaceX"
            });
        }
    }
}
