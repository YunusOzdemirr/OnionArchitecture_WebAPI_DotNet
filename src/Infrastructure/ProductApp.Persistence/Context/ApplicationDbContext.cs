using System;
using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Pen", Value = 10, Quantity = 100, CreatedDate = DateTime.Now },
                new Product() { Id = 2, Name = "Papper A4", Value = 1, Quantity = 1000, CreatedDate = DateTime.Now },
                new Product() { Id = 3, Name = "Book", Value = 30, Quantity = 300, CreatedDate = DateTime.Now },
                new Product() { Id = 4, Name = "Backpack", Value = 50, Quantity = 200, CreatedDate = DateTime.Now });
            base.OnModelCreating(modelBuilder);
        }
    }
}

