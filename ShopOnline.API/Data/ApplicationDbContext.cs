using Microsoft.EntityFrameworkCore;
using ShopOnline.API.Models;

namespace ShopOnline.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Sembrar Categorías iniciales
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electrónica" },
                new Category { Id = 2, Name = "Ropa y Accesorios" }
            );

            // 2. Sembrar Productos iniciales (asegúrate de que el CategoryId coincida)
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Smartphone X",
                    Description = "Última generación con alta capacidad de almacenamiento",
                    Price = 699.99m,
                    Stock = 15,
                    ImageUrl = "https://via.placeholder.com/150",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Camiseta Deportiva",
                    Description = "Tela transpirable para entrenamiento",
                    Price = 25.50m,
                    Stock = 40,
                    ImageUrl = "https://via.placeholder.com/150",
                    CategoryId = 2
                }
            );
        }
    }
}