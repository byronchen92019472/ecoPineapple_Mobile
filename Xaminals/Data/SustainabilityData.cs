using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class SustainabilityData
    {
        public static IList<Info> Sustainability { get; private set; }

        static SustainabilityData()
        {
            Sustainability = new List<Info>();

            Sustainability.Add(new Info
            {
                Heading = "Baboon",
                Text = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                ImageSource = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });
        }
    }
}
