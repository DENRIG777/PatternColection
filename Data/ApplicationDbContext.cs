using Microsoft.EntityFrameworkCore;
using PatternColection.Models;

namespace PatternColection.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        { 
        }

        public DbSet<Pattern> patterns { get; set; }
    }
}
