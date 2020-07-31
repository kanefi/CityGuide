using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.Models
{
    public class Walk
    {
        public int WalkId { get; set; }
        public string WalkName { get; set; }
        public int Rating { get; set; }
        public string Address { get; set; }

        public List<Pub> Pubs { get; set; }
    }
}
