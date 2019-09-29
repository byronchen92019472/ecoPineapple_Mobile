using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class AnnouncementData
    {
        public static IList<Announcement> Announce { get; private set; }

        static AnnouncementData()
        {
            Announce = new List<Announcement>();

            Announce.Add(new Announcement
            {
                Title = "Christchurch - Strike 4 Climate NZ (Sep 27 2019) ",
                Details =
                    "Join us for Christchurch's third climate strike, and this time, we're going" +
                    " intergenerational. Bring your siblings, friends, parents, grandparents, " +
                    "teachers and children because the climate crisis is everyone's issue!\n\n" +
                    "Event will be held on Friday, 27 September 2019 from 13:00-15:00 at the " +
                    "Cathedral Sq, Christchurch Central, Christchurch 8011, New Zealand",
                DateTime = "09/26/2019 11:50:06",
            });
        }
    }
}
