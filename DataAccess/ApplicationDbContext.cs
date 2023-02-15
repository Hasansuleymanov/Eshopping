using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get;set; }
        public DbSet<BannerProduct> BannerProducts { get; set; }
        public DbSet <Collection>Collections { get; set; }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<Picture>Pictures { get; set; }
        public DbSet<ProductToCollection> ProductToCollections { get; set; }
        public DbSet<ProductToPicture>ProductToPictures { get; set; }
    }
}