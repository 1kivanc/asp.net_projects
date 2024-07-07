using Foody.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.Context
{
    public class FoodyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;initial catalog=FoodyDb;integrated security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product>  Products{ get; set; }
        public DbSet<Review>  Reviews{ get; set; }
        public DbSet<Slider>  Sliders{ get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
    }
}
