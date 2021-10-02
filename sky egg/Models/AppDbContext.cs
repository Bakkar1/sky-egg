using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sky_egg.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SkyEggProduct> SkyEggProducts { get; set; }
        public DbSet<Photo> Photos { get; set; }
        //public DbSet<Color> Colors { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkyEggProduct>().HasData(
                new SkyEggProduct()
                {
                    Id = 1,
                    ProductName = "Dreamegg D3 Sound Machine",
                    Prise = 30.99f,
                    //Features = "Timer & Volume Control",
                    Colors = "Grey",
                    Categrie = Categories.Sound_Machines.ToString()
                },
                new SkyEggProduct()
                {
                    Id = 2,
                    ProductName = "HEPA Air Purifier 4-in-1 for Home",
                    Prise = 119.99f,
                    //Features = "Much Powerful Performance - CADR 189m³/h + True HEPA Filter;Effective Air Filtration - Refresh the Air in a Small or Mid-Size Room(250 Sq Ft (23 m²) )in 20 Min",
                    Colors = null,
                    Categrie = Categories.Air_Purifiers.ToString()
                },
                new SkyEggProduct()
                {
                    Id = 3,
                    ProductName = "Dreamegg 2L Cool Mist Humidifier - Grey",
                    Prise = 39.99f,
                    //Features = "EFFECTIVELY COMBAT DRYNESS;HOUGHTFUL TIMER FUNCTION",
                    Colors = null,
                    Categrie = Categories.Humidifiers.ToString()
                }
            );
            modelBuilder.Entity<Photo>().HasData(
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
                     PhotoId = 8,
                     PhotoPath = "c13cdd4d-b4eb-4178-853c-3f6483d7208eDreamegg 2L.jpg",
                     SkyEggProductId = 3
                 }
            );
            modelBuilder.Entity<Feature>().HasData(
                 new Feature()
                 {
                     FeatureId = 1,
                     ProductFature = "Timer & Volume Control",
                     SkyEggProductId = 1
                 },
                new Feature()
                {
                    FeatureId = 2,
                    ProductFature = "Much Powerful Performance - CADR 189m³/h",
                    SkyEggProductId = 2
                },
                new Feature()
                {
                    FeatureId = 3,
                    ProductFature = "Effective Air Filtration - Refresh the Air in a Small or Mid-Size Room(250 Sq Ft (23 m²) )in 20 Min",
                    SkyEggProductId = 2
                },
                new Feature()
                {
                    FeatureId = 4,
                    ProductFature = "EFFECTIVELY COMBAT DRYNESS;HOUGHTFUL TIMER FUNCTION",
                    SkyEggProductId = 3
                }
            );
        }
    }
}
