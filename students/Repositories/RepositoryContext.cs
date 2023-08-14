using Microsoft.EntityFrameworkCore;
using students.Models;
using students.Repositories.Config;

namespace students.Repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfig());
        }
    }
}
