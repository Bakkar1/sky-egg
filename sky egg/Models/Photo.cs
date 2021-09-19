using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace sky_egg.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoPath { get; set; }
        public int? SkyEggProductId { get; set; }
        public SkyEggProduct SkyEggProduct { get; set; }
    }
}
