using CoSeClothes.Models;
using Microsoft.EntityFrameworkCore;

namespace CoSeClothes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Category> Categories { get; set; }
    }
}
