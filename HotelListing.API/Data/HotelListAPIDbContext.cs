using HotelListing.API.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data
{
    public class HotelListAPIDbContext : IdentityDbContext<ApiUser>
    {
        public HotelListAPIDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Hotel> Hotels { get;set; }
        public DbSet<Country> Countries { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration (new RoleConfiguration());
            modelBuilder.ApplyConfiguration ( new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
            
        }
    }
}
