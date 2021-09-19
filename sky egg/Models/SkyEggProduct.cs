using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sky_egg.Models
{
    public class SkyEggProduct
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float Prise { get; set; }
        public string Features { get; set; }
        //public List<Feature> Features { get; set; }
        public string Colors { get; set; }
        //public List<Color> Colors { get; set; }
        public string Categrie { get; set; }
        //public string PhotoPath { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
