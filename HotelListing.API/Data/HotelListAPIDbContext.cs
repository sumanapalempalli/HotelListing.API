using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data
{
    public class HotelListAPIDbContext : DbContext
    {
        public HotelListAPIDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Hotel> Hotels { get;set; }
        public DbSet<Country> Countries { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId=1,
                    Name="Jamaica",
                    ShortName="JM"
                    
                },
                new Country
                {
                    CountryId=2,
                    Name="Bahamas",
                    ShortName="BS"
                },
                new Country
                {
                    CountryId=3,
                    Name="Cayman Island",
                    ShortName="CI"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id=1,
                    Name="Sandals Resort and Spa",
                    Address="Negril",
                    CountryId=1,
                    Rating=4.5
                },
                new Hotel
                {
                    Id=2,
                    Name="Comfort Suites",
                    Address="George Town",
                    CountryId=3,
                    Rating=4.3
                },
                new Hotel
                {
                    Id=3,
                    Name="Grand Palldium",
                    Address="Nassua",
                    CountryId=2,
                    Rating=4
                }
                );
            
        }
    }
}
