using Microsoft.EntityFrameworkCore;
using yoked.Entities;

namespace yoked.Data
{
    public class YokedDbContext : DbContext
    {
        public YokedDbContext(DbContextOptions<YokedDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }  
    }
}
