using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sky_egg.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using sky_egg.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace sky_egg.Controllers
{
    public class Collections : Controller
    {
        private readonly ISkyEgg _ISkyEgg;

        public IWebHostEnvironment hostingEnvironment { get; }

        public Collections(ISkyEgg iSkyEgg, IWebHostEnvironment hostingEnvironment)
        {
            _ISkyEgg = iSkyEgg;
            this.hostingEnvironment = hostingEnvironment;
        }
        public ViewResult Index(Categories categorie)
        {
            return View(GetModels(categorie));

            //return View(_ISkyEgg.GetAllProductByCategorie(categorie));
        }
        public List<SkyEggJoinModel> GetModels(Categories categorie)
        {
            //IEnumerable<SkyEggJoinModel> skyEggJoinModels = Enumerable.Empty<SkyEggJoinModel>();;
            //SkyEggJoinModel model = null;
            //foreach (SkyEggProduct pro in _ISkyEgg.GetAllProductByCategorie(categorie))
            //{
            //    model = new SkyEggJoinModel()
            //    {
            //        skyEggProduct = pro,
            //        photos = _ISkyEgg.GetPhotos(pro.Id)
            //    };
            //    skyEggJoinModels.Append(model);
            //}
            //return skyEggJoinModels;

            List<SkyEggJoinModel> skyEggJoinModels = new List<SkyEggJoinModel>();
            SkyEggJoinModel model = null;
            List<SkyEggProduct> products = _ISkyEgg.GetAllProductByCategorie(categorie).ToList();
            foreach (SkyEggProduct pro in products)
            {
                model = new SkyEggJoinModel()
                {
                    SkyEggProduct = pro,
                    Photos = _ISkyEgg.GetPhotos(pro.Id)
                };
                skyEggJoinModels.Add(model);
            }
            return skyEggJoinModels;
        }
        #region get list by categories
        public ViewResult SoundMachines(Categories categorie)
        {
            //return View("Sound-Machines",_ISkyEgg.GetAllProductByCategorie(categorie));
            return View("Sound-Machines", GetModels(categorie));
        }
        public ViewResult AirPurifiers(Categories categorie)
        {
            //return View("Air-Purifiers", _ISkyEgg.GetAllProductByCategorie(categorie));
            return View("Air-Purifiers", GetModels(categorie));
        }
        public ViewResult Humidifiers(Categories categorie)
        {
            //return View(_ISkyEgg.GetAllProductByCategorie(categorie));
            return View(GetModels(categorie));

        }
        #endregion
        #region data manipulation
        [HttpGet]
        public ViewResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(SkyEggCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                SkyEggProduct skyEggProduct = new SkyEggProduct()
                {
                    ProductName = model.ProductName,
                    Prise = model.Prise,
                    //Features = model.Features,
                    Colors = model.Colors,
                    Categrie = model.Categrie.ToString(),
                };
                _ISkyEgg.Add(skyEggProduct);

                //add Feauters
                Feature feature = new Feature() 
                    {
                        ProductFature = model.Features,
                        SkyEggProductId = skyEggProduct.Id
                    };
                _ISkyEgg.Add(feature);

                ProcessUploadedFile(model, skyEggProduct);

                return RedirectToAction("Read", new { Id = skyEggProduct.Id });
            }
            return View();

        }

        private void ProcessUploadedFile(SkyEggCreateViewModel model, SkyEggProduct skyEggProduct)
        {
            string uniqueFileName = null;
            if (model.Photos != null && model.Photos.Count > 0)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                Photo newPhoto = null;
                foreach (IFormFile photo in model.Photos)
                {
                    uniqueFileName = Guid.NewGuid().ToString() + photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using(FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        photo.CopyTo(fs);
                    }
                    //photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    newPhoto = new Photo()
                    {
                        PhotoPath = uniqueFileName,
                        SkyEggProductId = skyEggProduct.Id
                    };
                    _ISkyEgg.Add(newPhoto);
                }
            }
        }

        public ViewResult Read(int Id)
        {
            SkyEggJoinModel model = new SkyEggJoinModel()
            {
                SkyEggProduct = _ISkyEgg.Read(Id),
                Photos = _ISkyEgg.GetPhotos(Id),
                Features = _ISkyEgg.GetFeatures(Id)

            };
            if(model.SkyEggProduct == null)
            {
                
                return View("ProductNotFound", Id);
            }

            return View(model);

            //SkyEggProduct skyEggProduct = _ISkyEgg.Read(Id);
            //IEnumerable<Photo> photos =  _ISkyEgg.GetPhotos(Id);
            //return View(skyEggProduct);
            
        }
        [HttpGet]
        public ViewResult Update(int Id)
        {
            SkyEggProduct pro = _ISkyEgg.Read(Id);
            SkyEggUpdateViewModel skyEggProduct = new SkyEggUpdateViewModel()
            {
                Id = pro.Id,
                ProductName = pro.ProductName,
                Prise = pro.Prise,
                Features = _ISkyEgg.GetFeatures(Id).FirstOrDefault().ProductFature,
                Colors = pro.Colors,
                Categrie = (Categories)Enum.Parse(typeof(Categories), pro.Categrie),
                ExistingPhotos = (_ISkyEgg.GetPhotos(Id)).ToList()
            };
            return View(skyEggProduct);
        }
        [HttpPost]
        public IActionResult Update(SkyEggUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                SkyEggProduct skyEggProduct = new SkyEggProduct()
                {
                    Id = model.Id,
                    ProductName = model.ProductName,
                    Prise = model.Prise,
                    //Features = model.Features,
                    Colors = model.Colors,
                    Categrie = model.Categrie.ToString(),
                };
                _ISkyEgg.Update(skyEggProduct);

                //update Feauters
                Feature feature = _ISkyEgg.GetFeature(skyEggProduct.Id);
                feature.ProductFature = model.Features;
                _ISkyEgg.Update(feature);


                if (model.Photos != null)
                {
                    if(model.ExistingPhotos != null)
                    {
                        // delete old photos from photos table
                        List<string> paths = _ISkyEgg.DeletePhotos(skyEggProduct.Id);

                        // delete photos from images folder
                        string absolutewwwRootPath = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        //foreach (Photo photo in model.ExistingPhotos)
                        //{
                        //    string filePath = Path.Combine(absolutewwwRootPath, photo.PhotoPath);
                        //    System.IO.File.Delete(filePath);

                        //}
                        foreach (string photoPath in paths)
                        {
                            string filePath = Path.Combine(absolutewwwRootPath, photoPath);
                            if (System.IO.File.Exists(filePath))
                            {
                                System.IO.File.Delete(filePath);
                            }
                        }
                    }
                }
                // upload new photos to images folder and to photos tabel
                ProcessUploadedFile(model, skyEggProduct);
                return RedirectToAction("Read", new { Id = skyEggProduct.Id });
            }
            return View(model);
        }
        public RedirectToActionResult Delete(int Id, Categories _categorie)
        {
            List<string> paths = _ISkyEgg.DeletePhotos(Id);
            SkyEggProduct skyEggProduct = _ISkyEgg.Delete(Id);
            
            //remove photos from de folder images
            if (paths != null && paths.Count() > 0)
            {
                string wwwRootFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                string imagePth = null;
                foreach (string photoPath in paths)
                {
                    imagePth = Path.Combine(wwwRootFolder, photoPath);
                    if (System.IO.File.Exists(imagePth))
                    {
                        System.IO.File.Delete(imagePth);
                    }
                }
            }

            string nameAction = _categorie.ToString().Replace("_","").ToLower();

            return RedirectToAction(nameAction, new { categorie = _categorie });
        }
        #endregion
    }
}
