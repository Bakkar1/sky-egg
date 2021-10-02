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
        #region Add
        SkyEggProduct Add(SkyEggProduct product);
        Photo Add(Photo photo);
        Feature Add(Feature feature);
        #endregion
        #region Update
        SkyEggProduct Update(SkyEggProduct product);
        Photo Update(Photo product);
        Feature Update(Feature feature);
        #endregion
        #region Read
        SkyEggProduct Read(int Id);
        IEnumerable<Photo> GetPhotos(int productId);
        IEnumerable<Feature> GetFeatures(int productId);
        Feature GetFeature(int productId);
        #endregion
        #region Delete
        SkyEggProduct Delete(int Id);
        List<string> DeletePhotos(int productId);
        #endregion
    }
}
