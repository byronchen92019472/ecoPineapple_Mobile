using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class SpaceData
    {
        public static IList<Space> Sp { get; private set; }

        static SpaceData()
        {
            Sp = new List<Space>
            {
                new Space
                {
                    Name = "Falcon Heavy",
                    Details = "Partially reusable heavy-lift launch vehicle",
                    ImageSource = "falconheavy.png",
                    Cost = "$150,000,000",
                    Supplier = "SpaceX"
                }
            };
        }
    }
}
