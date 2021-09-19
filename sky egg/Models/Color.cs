using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sky_egg.Models;

namespace sky_egg.Models
{
    public class Color
    {
        public int ColorId { get; set; }
        public string HexColor { get; set; }
        public int SkyEggProductId { get; set; }
        public SkyEggProduct SkyEggProduct { get; set; }
    }
}
