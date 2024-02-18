using Microsoft.EntityFrameworkCore;
using MVC_CRUD1.Models;

namespace MVC_CRUD1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> categories { get; set; }
    }
}
