using sky_egg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sky_egg.ViewModels
{
    public class SkyEggUpdateViewModel : SkyEggCreateViewModel
    {
        public List<Photo> ExistingPhotos { get; set; }
    }
}
