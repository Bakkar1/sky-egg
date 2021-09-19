﻿using Microsoft.AspNetCore.Mvc;
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
                    skyEggProduct = pro,
                    photos = _ISkyEgg.GetPhotos(pro.Id)
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
            return AddUpdate(model, Actions.Add);
        }
        public ViewResult Read(int Id)
        {
            SkyEggJoinModel model = new SkyEggJoinModel()
            {
                skyEggProduct = _ISkyEgg.Read(Id),
                photos = _ISkyEgg.GetPhotos(Id)

            };

            return View(model);

            //SkyEggProduct skyEggProduct = _ISkyEgg.Read(Id);
            //IEnumerable<Photo> photos =  _ISkyEgg.GetPhotos(Id);
            //return View(skyEggProduct);
            
        }
        [HttpGet]
        public ViewResult Update(int Id)
        {
            SkyEggProduct pro = _ISkyEgg.Read(Id);
            SkyEggCreateViewModel skyEggProduct = new SkyEggCreateViewModel()
            {
                Id = pro.Id,
                ProductName = pro.ProductName,
                Prise = pro.Prise,
                Features = pro.Features,
                Colors = pro.Colors,
                Categrie = (Categories)Enum.Parse(typeof(Categories), pro.Categrie),
                IEnumPhotos = _ISkyEgg.GetPhotos(Id)
        };
            return View(skyEggProduct);
        }
        [HttpPost]
        public IActionResult Update(SkyEggCreateViewModel model)
        {
            return AddUpdate(model, Actions.Update);
        }
        public RedirectToActionResult Delete(int Id, Categories _categorie)
        {
            List<string> paths = _ISkyEgg.DeletePhotos(Id);
            SkyEggProduct skyEggProduct = _ISkyEgg.Delete(Id);
            // remove photos from de folder images
            //if (paths != null && paths.Count() > 0)
            //{
            //    string wwwRootFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
            //    string imagePth = null;
            //    foreach(string photoPath in paths)
            //    {
            //        imagePth = Path.Combine(wwwRootFolder, photoPath);
            //        if (System.IO.File.Exists(imagePth))
            //        {
            //            System.IO.File.Delete(imagePth);
            //        }
            //    }
            //}

            string nameAction = _categorie.ToString().Replace("_","").ToLower();

            return RedirectToAction(nameAction, new { categorie = _categorie });
        }
        
        public IActionResult AddUpdate(SkyEggCreateViewModel model, Actions action)
        {
            if (ModelState.IsValid)
            {
                SkyEggProduct skyEggProduct = new SkyEggProduct()
                {
                    Id = model.Id,
                    ProductName = model.ProductName,
                    Prise = model.Prise,
                    Features = model.Features,
                    Colors = model.Colors,
                    Categrie = model.Categrie.ToString(),
                };
                if (action == Actions.Add)
                {
                    _ISkyEgg.Add(skyEggProduct);
                }
                else if (action == Actions.Update) {
                    _ISkyEgg.Update(skyEggProduct);
                }

                string uniqueFileName = null;
                if (model.Photos != null && model.Photos.Count > 0)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    Photo newPhoto = null;
                    foreach (IFormFile photo in model.Photos)
                    {
                        uniqueFileName = Guid.NewGuid().ToString() + photo.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        photo.CopyTo(new FileStream(filePath, FileMode.Create));
                        newPhoto = new Photo()
                        {
                            PhotoPath = uniqueFileName,
                            SkyEggProductId = skyEggProduct.Id
                        };
                        _ISkyEgg.Add(newPhoto);
                    }
                }
                return RedirectToAction("Read", new { Id = skyEggProduct.Id });
            }
            return View();
        }
        #endregion
    }
}