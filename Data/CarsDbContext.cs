using Cars.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cars.Data
{
    public class CarsDbContext : IdentityDbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
