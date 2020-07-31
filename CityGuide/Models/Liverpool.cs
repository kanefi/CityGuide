using CityGuide.Models.Manchester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.Models
{
    public class Liverpool
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<Gallery> Galleries { get; set; }
        public List<Cafe> Cafes { get; set; }
        public List<Walk> Walks { get; set; }
        public List<Museum> Museums { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public List<Pub> Pubs { get; set; }

    }
}
