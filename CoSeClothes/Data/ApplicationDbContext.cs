using CoSeClothes.Models;
using Microsoft.EntityFrameworkCore;

namespace CoSeClothes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Shirts", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Jeans", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Jackets", DisplayOrder = 3 }
            );
        }
    }
}
