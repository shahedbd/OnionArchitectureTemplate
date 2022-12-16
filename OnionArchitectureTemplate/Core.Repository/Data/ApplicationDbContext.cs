using Core.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Branch> Branch { get; set; }
    }
}
