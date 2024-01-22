using Microsoft.EntityFrameworkCore;
using OLX_AspNet.Data.Entities;

namespace OLX_AspNet.Data
{
    public class OLXDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public OLXDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasData(new[]
            {
                new Item() { Id = 1,Description="Something", Title = "iPhone X", Category = "Electronics", Price = 650, Image = "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png", Time=new DateTime(2010, 10, 10), Address="Rivne" },
              
            });

        }


    }
}