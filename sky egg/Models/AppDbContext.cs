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
        //public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SkyEggProduct>().HasData(
            //    new SkyEggProduct()
            //    {
            //        Id = 1,
            //        ProductName = "Dreamegg D11 Sound Machine",
            //        Prise = 30.99f,
            //        Features = ";Timer & Volume Control",
            //        Colors = "Grey",
            //        Categrie = Categories.Sound_Machines.ToString()
            //        //PhotoPath = "392bbac0-796d-4c73-b0a4-5e1eb34d6b04Sound_Machines .jpg"
            //    },
            //    new SkyEggProduct()
            //    {
            //        Id = 2,
            //        ProductName = "HEPA Air Purifier 4-in-1 for Home",
            //        Prise = 119.99f,
            //        Features = "Much Powerful Performance - CADR 189m³/h + True HEPA Filter;Effective Air Filtration - Refresh the Air in a Small or Mid-Size Room(250 Sq Ft (23 m²) )in 20 Min",
            //        Colors = null,
            //        Categrie = Categories.Humidifiers.ToString()
            //        //PhotoPath = "56e1d082-b379-4f50-a882-56225abdddd3HEPA.jpg"
            //    },
            //    new SkyEggProduct()
            //    {
            //        Id = 3,
            //        ProductName = "Dreamegg 2L Cool Mist Humidifier - Grey",
            //        Prise = 39.99f,
            //        Features = "EFFECTIVELY COMBAT DRYNESS;HOUGHTFUL TIMER FUNCTION",
            //        Colors = null,
            //        Categrie = Categories.Air_Purifiers.ToString()
            //        //PhotoPath = "c13cdd4d-b4eb-4178-853c-3f6483d7208eDreamegg 2L.jpg"
            //    }
            //);
        }
    }
}
