using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sky_egg.Models
{
    public class MockSkyEggReository : ISkyEgg
    {
        private List<SkyEggProduct> productsList;
        private List<Photo> photosList;
        public MockSkyEggReository()
        {
            InitialProducts();
        }
        public SkyEggProduct Add(SkyEggProduct product)
        {
            int newId = productsList.Max(pro => pro.Id) + 1;
            product.Id = newId;
            productsList.Add(product);

            return product;
        }

        public Photo Add(Photo photo)
        {
            int newId = photosList.Max(pro => pro.PhotoId) + 1;
            photo.PhotoId = newId;
            photosList.Add(photo);

            return photo;
        }

        public SkyEggProduct Delete(int Id)
        {
            SkyEggProduct product = productsList.FirstOrDefault(pro => pro.Id == Id);
            productsList.Remove(product);
            return product;
        }

        public List<string> DeletePhotos(int productId)
        {
            var photos = photosList.Where(ph => ph.SkyEggProductId == productId).ToList();
            List<string> photoPaths = new List<string>();
            if (photos != null && photos.Count() > 0)
            {
                foreach (Photo photo in photos)
                {
                    photoPaths.Add(photo.PhotoPath);
                    photosList.Remove(photo);
                }
            }
            return photoPaths;
        }

        public IEnumerable<SkyEggProduct> GetAllProduct()
        {
            return productsList;
        }

        public IEnumerable<SkyEggProduct> GetAllProductByCategorie(Categories categorie)
        {
            //IEnumerable<SkyEggProduct> categorieList = from pro in productsList
            //                                           where pro.Categrie == categorie.ToString()
            //                                           select pro;
            //return categorieList;
            return productsList.Where(pro => pro.Categrie == categorie.ToString());
        }

        public IEnumerable<Photo> GetPhotos(int productId)
        {
            return photosList.Where(photo => photo.SkyEggProductId == productId);
        }

        public SkyEggProduct Read(int Id)
        {
            return productsList.FirstOrDefault(pro => pro.Id == Id);
        }

        public SkyEggProduct Update(SkyEggProduct product)
        {
            SkyEggProduct pro = productsList.FirstOrDefault(prod => prod.Id == product.Id);
            pro.ProductName = product.ProductName;
            pro.Prise = product.Prise;
            pro.Features = product.Features;
            pro.Colors = product.Colors;
            pro.Categrie = product.Categrie;
            return pro;
        }

        public Photo Update(Photo newPhoto)
        {
            var photo = photosList.FirstOrDefault(ph => ph.PhotoId == newPhoto.PhotoId);

            photo.PhotoId = newPhoto.PhotoId;
            photo.PhotoPath = newPhoto.PhotoPath;
            photo.SkyEggProductId = newPhoto.SkyEggProductId;
            return photo;
        }

        private void InitialProducts()
        {
            productsList = new List<SkyEggProduct>()
            {
                new SkyEggProduct(){
                    Id= 1,
                    ProductName = "Dreamegg D3 Sound Machine" ,
                    Prise = 30.99f,
                    Features = "Timer & Volume Control",
                    Colors = "Grey" ,
                    Categrie = Categories.Sound_Machines.ToString()
                    //PhotoPath = "392bbac0-796d-4c73-b0a4-5e1eb34d6b04Sound_Machines .jpg"
                },
                new SkyEggProduct(){
                    Id= 2,
                    ProductName = "HEPA Air Purifier 4-in-1 for Home" ,
                    Prise = 119.99f,
                    Features = "Much Powerful Performance - CADR 189m³/h + True HEPA Filter;Effective Air Filtration - Refresh the Air in a Small or Mid-Size Room(250 Sq Ft (23 m²) )in 20 Min",
                    Colors = null ,
                    Categrie = Categories.Air_Purifiers.ToString()
                    //PhotoPath = "56e1d082-b379-4f50-a882-56225abdddd3HEPA.jpg"
                },
                new SkyEggProduct(){
                    Id= 3,
                    ProductName = "Dreamegg 2L Cool Mist Humidifier - Grey" ,
                    Prise = 39.99f,
                    Features = "EFFECTIVELY COMBAT DRYNESS;HOUGHTFUL TIMER FUNCTION",
                    Colors = null ,
                    Categrie = Categories.Humidifiers.ToString()
                    //PhotoPath = "c13cdd4d-b4eb-4178-853c-3f6483d7208eDreamegg 2L.jpg"
                }
            };
            photosList = new List<Photo>()
            {
                 new Photo()
                 {
                     PhotoId = 1,
                     PhotoPath = "d8789136-410e-4115-95b9-4fbabc0a35fdD1 Sound Machine3.jpg",
                     SkyEggProductId = 1
                 },
                 new Photo()
                 {
                     PhotoId = 2,
                     PhotoPath = "d7ac2bd4-8645-4291-be0b-ec91afaab4c1D1 Sound Machine2.jpg",
                     SkyEggProductId = 1
                 },
                 new Photo()
                 {
                     PhotoId = 3,
                     PhotoPath = "d3fd7c36-7186-4a40-b045-b55eb71b076bD1 Sound Machine.jpg",
                     SkyEggProductId = 1
                 },
                 new Photo()
                 {
                     PhotoId = 4,
                     PhotoPath = "dc36cfbe-9fbf-455a-a4e5-7187809bdc00hepa6.png",
                     SkyEggProductId = 2
                 },
                 new Photo()
                 {
                     PhotoId = 5,
                     PhotoPath = "dfe9c871-a6fd-41d8-88cd-9b2c61aa0d50hepa5.jpg",
                     SkyEggProductId = 2
                 },
                 new Photo()
                 {
                     PhotoId = 6,
                     PhotoPath = "754fe19f-d3a4-4686-8665-c6f8c64b288ehepa4.jpg",
                     SkyEggProductId = 2
                 },
                 new Photo()
                 {
                     PhotoId = 7,
                     PhotoPath = "02826809-730c-4080-a3d3-53e9dcebbb12hepa3.png",
                     SkyEggProductId = 2
                 }
                 ,
                 new Photo()
                 {
                     PhotoId = 7,
                     PhotoPath = "c13cdd4d-b4eb-4178-853c-3f6483d7208eDreamegg 2L.jpg",
                     SkyEggProductId = 3
                 }
            };
        }
    }
}
