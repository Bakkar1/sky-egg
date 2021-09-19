using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sky_egg.Models
{
    public class SQLSkyEggRepository : ISkyEgg
    {
        private readonly AppDbContext appDbContext;

        public SQLSkyEggRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public SkyEggProduct Add(SkyEggProduct product)
        {
            appDbContext.SkyEggProducts.Add(product);
            appDbContext.SaveChanges();
            return product;
        }

        public Photo Add(Photo photo)
        {
            appDbContext.Photos.Add(photo);
            appDbContext.SaveChanges();
            return photo;
        }

        public SkyEggProduct Delete(int Id)
        {
            SkyEggProduct product =  appDbContext.SkyEggProducts.Find(Id);
            if (product != null)
            {
                appDbContext.SkyEggProducts.Remove(product);
                appDbContext.SaveChanges();
            }
            return product;
        }

        public List<string> DeletePhotos(int productId)
        {
            var photos = appDbContext.Photos.Where(ph => ph.SkyEggProductId == productId);
            List<string> photoPaths = new List<string>();
            if (photos != null && photos.Count() > 0)
            {
                foreach (Photo photo in photos)
                {
                    photoPaths.Add(photo.PhotoPath);
                    appDbContext.Photos.Remove(photo);
                }
            }
            appDbContext.SaveChanges();
            return photoPaths;
        }

        public IEnumerable<SkyEggProduct> GetAllProduct()
        {
            return appDbContext.SkyEggProducts;
        }

        public IEnumerable<SkyEggProduct> GetAllProductByCategorie(Categories categorie)
        {
            return appDbContext.SkyEggProducts.Where(pro => pro.Categrie == categorie.ToString());
        }

        public IEnumerable<Photo> GetPhotos(int productId)
        {
            return appDbContext.Photos.Where(photo => photo.SkyEggProductId == productId);
        }

        public SkyEggProduct Read(int Id)
        {
            return appDbContext.SkyEggProducts.Find(Id);
        }

        public SkyEggProduct Update(SkyEggProduct product)
        {
            var pro = appDbContext.SkyEggProducts.Attach(product);
            pro.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            appDbContext.SaveChanges();
            return product;

        }

        public Photo Update(Photo photo)
        {
            var pro = appDbContext.Photos.Attach(photo);
            pro.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            appDbContext.SaveChanges();
            return photo;
        }
    }
}
