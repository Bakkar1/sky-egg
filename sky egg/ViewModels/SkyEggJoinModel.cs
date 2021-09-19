using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sky_egg.Models;

namespace sky_egg.ViewModels
{
    public class SkyEggJoinModel
    {
        public SkyEggProduct skyEggProduct { get; set; }
        public IEnumerable<Photo> photos { get; set; }
    }
}
