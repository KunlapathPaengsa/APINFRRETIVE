using APINFRRETIVE.Domain;
using Microsoft.EntityFrameworkCore;

namespace APINFRRETIVE.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Character> MyProperty { get; set; }
    }
}