using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sky_egg.Models;

namespace sky_egg.Models
{
    public interface ISkyEgg
    {
        IEnumerable<SkyEggProduct> GetAllProduct();
        IEnumerable<SkyEggProduct> GetAllProductByCategorie(Categories categorie);
        SkyEggProduct Add(SkyEggProduct product);
        SkyEggProduct Update(SkyEggProduct product);
        SkyEggProduct Read(int Id);
        SkyEggProduct Delete(int Id);
        Photo Add(Photo photo);
        IEnumerable<Photo> GetPhotos(int productId);
        Photo Update(Photo product);
        List<string> DeletePhotos(int productId);
    }
}
