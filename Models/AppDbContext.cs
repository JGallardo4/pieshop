using Microsoft.EntityFrameworkCore;

namespace pieshop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
				{
					
				}

				public DbSet<Pie> Pies { get; set; }
				public DbSet<Category> Categories { get; set; }
    }
}