using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.Models
{
    public class Gallery
    {
        public int GalleryId { get; set; }
        public string GalleryName { get; set; }
        public int Rating { get; set; }
        public string Address { get; set; }

        public List<Pub> Pubs { get; set; }
        public List<Cafe> Cafes { get; set; }
    }
}
