using System;

using Microsoft.EntityFrameworkCore;

using api.Models.Product;

using Crud.BaseContext;

namespace api.Data.Context
{
    public class AppDbContext : BaseDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(p =>
            {
                p.HasKey(k => k.Id);
                p.HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "laptop the best",
                    Price = 192.0M,
                    CreatedAt = DateTimeOffset.Now
                },
                new Product()
                {
                    Id = 2,
                    Name = "Pc",
                    Description = "pc the better than laptop",
                    Price = 400.0M,
                    CreatedAt = DateTimeOffset.Now.AddMinutes(1)
                },
                new Product()
                {
                    Id = 3,
                    Name = "glass",
                    Description = "glass is good",
                    Price = 0,
                    CreatedAt = DateTimeOffset.Now.AddMinutes(2)
                },
                new Product()
                {
                    Id = 4,
                    Name = "ball",
                    Description = "ball for footbal game and another...",
                    Price = 0,
                    CreatedAt = DateTimeOffset.Now.AddMinutes(3)
                },
                new Product()
                {
                    Id = 5,
                    Name = "dress",
                    Description = "dress for man",
                    Price = 0,
                    CreatedAt = DateTimeOffset.Now.AddMinutes(4)
                });
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
