using Lehen_webgunea.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Lehen_webgunea.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        
    }
}
