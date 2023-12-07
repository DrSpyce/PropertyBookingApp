using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domain.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<PropertyAmenity>()
                .HasKey(cb => new { cb.PropertyId, cb.AmenityId });

            base.OnModelCreating(builder);
        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
    }
}
