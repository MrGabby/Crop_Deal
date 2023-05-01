using Crop_Deal.Models;
using Microsoft.EntityFrameworkCore;
namespace Crop_Deal.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Crop> Crops { get; set; }

        public DbSet<Crop_detail> Crop_details { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
