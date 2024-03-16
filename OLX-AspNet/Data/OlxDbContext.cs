using Microsoft.EntityFrameworkCore;
using OLX_AspNet.Data.Entities;

namespace OLX_AspNet.Data
{
    public class OLXDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }


        public OLXDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>()
               .HasOne(x => x.Category)
               .WithMany(x => x.Items)
               .HasForeignKey(x => x.CategoryId);
            modelBuilder.Entity<Item>().Property(x => x.CategoryId).HasDefaultValue(9); // "Other"

            modelBuilder.Entity<Category>().HasData(new[]
           {
                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Sport" },
                new Category() { Id = 3, Name = "Fashion" },
                new Category() { Id = 4, Name = "Home & Garden" },
                new Category() { Id = 5, Name = "Transport" },
                new Category() { Id = 6, Name = "Toys & Hobbies" },
                new Category() { Id = 7, Name = "Musical Instruments" },
                new Category() { Id = 8, Name = "Art" },
                new Category() { Id = 9, Name = "Other" }
            });

            modelBuilder.Entity<Item>().HasData(new[]
            {
                new Item() { Id = 1,Description="Something", Title = "iPhone X", CategoryId = 1, Price = 650, Image = "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png", Time=new DateTime(2010, 10, 10), Address="Rivne" },
              
            });

        }


    }
}