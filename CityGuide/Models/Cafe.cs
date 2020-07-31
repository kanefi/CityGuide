using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.Models
{
    public class Cafe
    {
        public int CafeId { get; set; }
        public string CafeName { get; set; }
        public int Rating { get; set; }
        public string Address { get; set; }
        public List<Gallery> Galleries { get; set; }

    }
}
