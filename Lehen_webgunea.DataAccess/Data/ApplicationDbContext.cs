using Lehen_webgunea.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Lehen_webgunea.DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Category21Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Category21Id = 2, Name = "Scifi", DisplayOrder = 2 },
                new Category { Category21Id = 3, Name = "History", DisplayOrder = 3 }
                );
        }


    }
}
