using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sky_egg.Models
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string ProductFature { get; set; }
        public int SkyEggProductId { get; set; }
        public SkyEggProduct SkyEggProduct { get; set; }

    }
}
