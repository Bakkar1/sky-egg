using Microsoft.AspNetCore.Http;
using sky_egg.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sky_egg.ViewModels
{
    public class SkyEggCreateViewModel
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        [RegularExpression("[0-9]+([,][0-9]+)?")]
        public float Prise { get; set; }
        [Required]
        public string Features { get; set; }
        [Required]
        public string Colors { get; set; }
        [Required]
        public Categories Categrie { get; set; }
        public List<IFormFile> Photos { get; set; }
        public IEnumerable<Photo> IEnumPhotos { get; set; }
    }
}
